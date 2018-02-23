using System;
using System.Text;

namespace matrix
{

    //class for handling matrix information and to perform calculations
    class Matrix
    {
        //the 2 dimentional array behind the matrix storage
        public double[,] Element { get; set; }

        //wrappers for getting matrix info
        public int NumberOfRows => Element.GetLength(0);
        public int NumberOfColumns => Element.GetLength(1);

        //constructor for ints
        public Matrix(int rows, int columns)
        {
            //create the 2d array
            Element = new double[rows, columns];
            //fill matrix with random numbers
            populate();
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
            Element = new double[intRows, intColumns];
            //fill matrix with random numbers
            populate();
        }


        public void populate()
        {
            //create random object
            Random rand = new Random();

            //loop through the matrix 
            for (int i = 0; i < NumberOfRows; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    //set the element in the matrix as a random double between 0 and 10
                    Element[i, j] = rand.NextDouble() * 10.0;
                }
            }
        }

        //converts the matrix into an identity of the same size
        public void MakeIdentity()
        {
            //throw exception if matrix is not a square
            if (NumberOfRows != NumberOfColumns)
                throw new InvalidOperationException("Rows and Cols of matrix must be equal");

            //loop through the matrix
            for (int i = 0; i < NumberOfRows; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    //if the element is diagonal from the top left make it 1
                    if (i == j)
                        Element[i, j] = 1.0;
                    else
                        Element[i, j] = 0.0;
                }
            }
        }

        //adds the matrix to the one passed in and returns the answer as a new matrix 
        public Matrix Addition(Matrix matrix)
        {
            //throw exception if matrix is not initialized or nonexistant
            if (NumberOfRows == 0 || NumberOfColumns == 0 || matrix == null || matrix.NumberOfRows == 0 || matrix.NumberOfColumns == 0)
                throw new InvalidOperationException("Please initialize A and B matrix");

            //throw exception if the matrices are incompatible dimensions for the operation
            if (NumberOfRows != matrix.NumberOfRows || NumberOfColumns != matrix.NumberOfColumns)
                throw new InvalidOperationException("Please check dimensions of A and B matrices");

            //create a new matrix to hold the result of the operation
            Matrix newMatrix = new Matrix(NumberOfRows, NumberOfColumns);

            //loop through the matrix
            for (int i = 0; i < NumberOfRows; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    //perform the addition operation on the 2 matrices and store the answer in the new matrix
                    newMatrix.Element[i, j] = Element[i, j] + matrix.Element[i, j];
                }
            }

            //return the new matrix holding the answer
            return newMatrix;
        }

        //perform the subtraction operation on the matrix passed in
        public Matrix Subtraction(Matrix matrix)
        {
            //throw exception if either matrix is invalid or non existant
            if(NumberOfRows == 0 || NumberOfColumns == 0 || matrix == null || matrix.NumberOfRows == 0 || matrix.NumberOfColumns == 0)
                throw new InvalidOperationException("Please initialize A and B matrix");

            //throw an exception if the 2 matrices are incompatible to have the operation performed
            if (NumberOfRows != matrix.NumberOfRows || NumberOfColumns != matrix.NumberOfColumns)
                throw new InvalidOperationException("Please check dimensions of A and B matrices");

            //create new matrix to store answers
            Matrix newMatrix = new Matrix(NumberOfRows, NumberOfColumns);

            //loop through matrix
            for (int i = 0; i < NumberOfRows; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    //perform operation and store answer in new matrix
                    newMatrix.Element[i, j] = Element[i, j] - matrix.Element[i, j];
                }
            }

            //return new matrix holding the answer
            return newMatrix;
        }

        //perform the multiplication operation on the matrix passed in
        public Matrix Multiply(Matrix matrix)
        {
            //throw exception if either matrix is invalic or non existant
            if (NumberOfRows == 0 || NumberOfColumns == 0 || matrix == null || matrix.NumberOfRows == 0 || matrix.NumberOfColumns == 0)
                throw new InvalidOperationException("Please initialize A and B matrix");

            //throw an exception if the 2 matrices are unable to be multiplied
            if (NumberOfColumns != matrix.NumberOfRows)
                throw new InvalidOperationException("Please check dimensions of A and B matrices");

            //create new matrix to store answer
            Matrix newMatrix = new Matrix(NumberOfRows, matrix.NumberOfColumns);

            //loop through matrix
            for (int i = 0; i < newMatrix.NumberOfRows; i++)
            {
                for (int j = 0; j < newMatrix.NumberOfColumns; j++)
                {
                    //init the element
                    newMatrix.Element[i, j] = 0;

                    //perform operation and store the answer in the new matrix
                    //taken from: https://stackoverflow.com/questions/6311309/how-can-i-multiply-two-matrices-in-c
                    for (int k = 0; k < NumberOfColumns; k++)
                        newMatrix.Element[i, j] = 
                            newMatrix.Element[i,j] + (Element[i, k] * matrix.Element[k, j]);
                }
            }
            //return new matrix holding the answer
            return newMatrix;
        }

        //override the tostring to make output easier
        public override string ToString()
        {
            //create stringbuilder to piece together the matrix
            StringBuilder toString = new StringBuilder();

            //loop through the matrix
            for (int i = 0; i < NumberOfRows; i++)
            {
                for (int j = 0; j < NumberOfColumns; j++)
                {
                    //create a string holding the element of the matrix
                    string element = String.Format("{0:f1}",Element[i, j]);
                    //add the element string to the string builder
                    toString.Append(element + "\t");
                }

                //add a newline to the stringbuilder for a new row in the matrix
                toString.AppendLine();
            }
            //return the built up string
            return toString.ToString();
        }
    }
}
