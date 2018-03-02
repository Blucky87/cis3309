using System;
using System.Runtime.Remoting.Messaging;
using System.Text;

namespace matrix
{
    //class for handling matrix information and to perform calculations
    //IEquatable interface for typesafe equality check
    class Matrix
    {
        //the 2 dimentional array behind the matrix storage
        public double[,] matrix { get; set; }

        //wrappers for getting matrix info
        public int Rows => matrix.GetLength(0);
        public int Cols => matrix.GetLength(1);

        //constructor for ints
        public Matrix(int rows, int columns)
        {
            //create the 2d array
            matrix = new double[rows, columns];
            //fill matrix with random numbers
            populateRand();
        }

        //constructor for strings
        public Matrix(string rows, string columns)
        {
            //number of rows for matrix
            int intRows = 0;
            //number of columns for matrix
            int intColumns = 0;

            //holds value of true if the string paramaters are valid integers
            bool isValidIntegers =
                Int32.TryParse(rows, out intRows) && Int32.TryParse(columns, out intColumns);

            //throw exception if the strings are not valid integers
            if (!isValidIntegers) throw new InvalidOperationException("Please enter an integer");

            //create the 2d array
            matrix = new double[intRows, intColumns];
            //fill matrix with random numbers
            populateRand();
        }


        public void populateRand()
        {
            //create random object
            Random rand = new Random();

            //loop through the matrix 
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    //set the element in the matrix as a random double between 0 and 10
                    this[i, j] = rand.NextDouble() * 10.0;
                }
            }
        }

        public void populateOrd()
        {
            double number = 0.0;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    this[i, j] = number += 1.0;
                }
            }
        }

        //converts the matrix into an identity of the same size
        public void makeId()
        {
            //throw exception if matrix is not a square
            if (Rows != Cols)
                throw new Exception("Rows and Cols of matrix must be equal");

            //loop through the matrix
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    //if the element is diagonal from the top left make it 1
                    if (i == j)
                        matrix[i, j] = 1.0;
                    else
                        matrix[i, j] = 0.0;
                }
            }
        }

        //adds the matrix to the one passed in and returns the answer as a new matrix 
        public Matrix Addition(Matrix otherMatrix)
        {

            if (object.Equals(otherMatrix, null))
                throw new Exception("Matrix is null");
            if (!dimsEqual(otherMatrix))
                throw new Exception("Dimensions don't match");

            Matrix newMatrix = new Matrix(Rows, Cols);

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    newMatrix[i, j] = this[i, j] + otherMatrix[i, j];
                }
            }

            return newMatrix;
        }

        //perform the subtraction operation on the matrix passed in
        public Matrix Subtraction(Matrix otherMatrix)
        {
            if (object.Equals(otherMatrix, null))
                throw new Exception("Matrix is null");
            if (!dimsEqual(otherMatrix))
                throw new Exception("Dimensions don't match");

            Matrix newMatrix = new Matrix(Rows, Cols);

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    newMatrix[i, j] = this[i, j] - otherMatrix[i, j];
                }
            }

            return newMatrix;
        }

        //perform the multiplication operation on the matrix passed in
        public Matrix Multiply(Matrix otherMatrix)
        {
            if (object.Equals(otherMatrix,null))
                throw new ArgumentNullException("Matrix is null");
            if (!dimsEqual(otherMatrix))
                throw new ArgumentException("Dimensions don't match");

            //create new matrix to store answer
            Matrix newMatrix = new Matrix(Rows, otherMatrix.Cols);

            //loop through matrix
            for (int i = 0; i < newMatrix.Rows; i++)
            {
                for (int j = 0; j < newMatrix.Cols; j++)
                {
                    //init the element
                    newMatrix[i, j] = 0;

                    //perform operation and store the answer in the new matrix
                    //taken from: https://stackoverflow.com/questions/6311309/how-can-i-multiply-two-matrices-in-c
                    for (int k = 0; k < Cols; k++)
                        newMatrix.matrix[i, j] = 
                            newMatrix[i,j] + (this[i, k] * otherMatrix[k, j]);
                }
            }
            //return new matrix holding the answer
            return newMatrix;
        }

        //checks if the matrices have same number of columns
        public bool colsEqual(Matrix matrix)
        {
            return Cols == matrix.Cols;
        }

        //checks if the matrices have the same number of rows
        public bool rowsEqual(Matrix matrix)
        {
            return Rows == matrix.Rows;
        }

        //checks if the matrices have the same dimensions
        public bool dimsEqual(Matrix matrix)
        {
            return colsEqual(matrix) && rowsEqual(matrix);
        }

        public double this[int row, int column] {
            get => matrix[row, column];
            set => matrix[row, column] = value;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Matrix otherMatrix = obj as Matrix;

            if (!rowsEqual(otherMatrix) || !colsEqual(otherMatrix))
                return false;

            for (int i = 0; i < Rows; ++i)
            {
                for (int j = 0; j < Cols; ++j)
                {
                    if (otherMatrix[i, j] != this[i, j]) return false;
                }
            }

            return true;
        }

        public override int GetHashCode()
        {
            return sum().GetHashCode();
        }

        public Matrix clone()
        {
            Matrix newMatrix = new Matrix(Rows, Cols);

            for (int i = 0; i < this.Rows; ++i)
            {
                for (int j = 0; j < this.Cols; ++j)
                {
                    newMatrix[i, j] = this[i, j];
                }
            }

            return newMatrix;
        }

        public void clone(Matrix otherMatrix)
        {
            matrix = new double[otherMatrix.Rows, otherMatrix.Cols];

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    this[i, j] = otherMatrix[i, j];
                }
            }
        }

        //add all the elements in the matrix
        public double sum()
        {
            double total = 0;

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    total += this[i, j];
                }
            }

            return total;
        }

        public bool Equals(Matrix other)
        {
            if (other == null) return false;
            //return false if other is null or a different size matrix
            if (!dimsEqual(other)) return false;

            //check if all numbers are the same
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (matrix[i, j] != other.matrix[i, j])
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        //override the tostring to make output easier
        public override string ToString()
        {
            //create stringbuilder to piece together the matrix
            StringBuilder output = new StringBuilder();

            //loop through the matrix
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    //create a string holding the element of the matrix
                    string element = String.Format("{0:f1}",matrix[i, j]);
                    string mod = String.Empty;

                    //better formatting for last column in the matrix row
                    if (j != Cols - 1)
                        mod = "\t";
 
                    //add the element string with modifier to the string builder
                    output.Append(element + mod);
                }

                //add a newline to the stringbuilder for a new row in the matrix
                output.AppendLine();
            }
            //return the built up string
            return output.ToString();
        }

        public static bool operator ==(Matrix A, Matrix B)
        {
            if (!object.Equals(A, null))
                return A.Equals(B);

            return object.Equals(B, null);
        }

        public static bool operator !=(Matrix A, Matrix B)
        {
            return !(A == B);
        }

        public static Matrix operator +(Matrix A, Matrix B)
        {
            if (object.Equals(A, null) || object.Equals(B, null))
                throw new Exception("One or both vectors are null");
            if (!A.dimsEqual(B))
                throw new Exception("Dimensions don't match");

            return A.Addition(B);
        }

        public static Matrix operator -(Matrix A, Matrix B)
        {
            if (object.Equals(A,null) || object.Equals(B,null))
                throw new Exception("One or both vectors are null");
            if (!A.dimsEqual(B))
                throw new Exception("Dimensions don't match");

            return A.Subtraction(B);
        }

        public static Matrix operator *(Matrix A, Matrix B)
        {
            if (object.Equals(A, null) || object.Equals(B, null))
                throw new Exception("One or both vectors are null");
            if (A.Rows != B.Cols || A.Cols != B.Rows)
                throw new Exception("Dimension mismatch for multiplication");

            return A.Multiply(B);
        }

    }
}
