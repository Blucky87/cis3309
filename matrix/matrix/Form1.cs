using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace matrix
{
    public partial class Form1 : Form
    {
        //Operation enumeration to store radio button state
        enum Operation
        {
            Multiplication, Addition, Subtraction
        }

        //the 3 matrices
        private Matrix matrixA, matrixB, matrixC;
        //current operation selected on the radio buttons
        private Operation operation;

        public Form1()
        {
            InitializeComponent();
            //set the current operation to multiplication
            operation = Operation.Multiplication;

            //setup the matrices
            matrixA = new Matrix(0,0);
            matrixB = new Matrix(0, 0);
            matrixC = new Matrix(0, 0);

            //collect all the text boxes that must have integers in them checked with a listener on Leave
            List<TextBox> mustBeIntegers = new List<TextBox>();
            mustBeIntegers.Add(textBoxMatrixARows);
            mustBeIntegers.Add(textBoxMatrixAColumns);
            mustBeIntegers.Add(textBoxMatrixBRows);
            mustBeIntegers.Add(textBoxMatrixBColumns);

            //loop through all the collected textboxes and add an anon function to their Leave listener
            mustBeIntegers.ForEach(textBox => textBox.Leave += (sender, args) =>
            {
                int number = 0;

                //check if the textbox's text is not a valid integer
                if (!Int32.TryParse(textBox.Text, out number))
                {
                    //set the invalid integer's textbox as empty
                    textBox.Text = String.Empty;
                    //set focus to the textbox
                    textBox.Focus();
                    //show popup with message saying what went wrong
                    MessageBox.Show("Must be an integer", "Warning");
                }
            });
        }
       
        #region radiobutton_events
        private void radioButtonMultiply_CheckedChanged(object sender, EventArgs e)
        {
            //set operation as multiplication
            operation = Operation.Multiplication;
        }

        private void radioButtonAddition_CheckedChanged(object sender, EventArgs e)
        {
            //set operation as addition
            operation = Operation.Addition;
        }

        private void radioButtonSubtraction_CheckedChanged(object sender, EventArgs e)
        {
            //set operation as subtraction
            operation = Operation.Subtraction;
        }
        #endregion

        //event when you click the calculate button
        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            //try to perform the matrix operation methods
            try
            {
                //switch on the radio buttons
                switch (operation)
                {
                    //perform multiplication
                    case Operation.Multiplication:
                        matrixC = matrixA.Multiply(matrixB);
                        break;
                    //perform addition
                    case Operation.Addition:
                        matrixC = matrixA.Addition(matrixB);
                        break;
                    //perform subtraction
                    case Operation.Subtraction:
                        matrixC = matrixA.Subtraction(matrixB);
                        break;
                    //? should not hit
                    default:
                        matrixC = new Matrix(0, 0);
                        break;
                }
                //update the matrix textbox display for matrix C
                textBoxMatrixCDisplay.Text = matrixC.ToString();
            }
            //catch if the math operation threw an exception
            catch (InvalidOperationException err)
            {
                //clear the matrix C textbox
                textBoxMatrixCDisplay.Text = String.Empty;
                //display exception message
                MessageBox.Show(err.Message, "Warning");
            }
        }

        //event for when clicking the identiy button
        private void buttonMatrixBIdentity_Click(object sender, EventArgs e)
        {
            //try to convert the matric into an Identity
            try
            {
                //try to trun matrix B into an Identity matrix
                matrixB.MakeIdentity();
                //update the matrix B disaply textbox
                textBoxMatrixBDisplay.Text = matrixB.ToString();
            }
            //catch an exception thrown by turning the matrix into an idenity
            catch (InvalidOperationException err)
            {
                //display the exception
                MessageBox.Show(err.Message, "Warning");
            }
        }

        //event for clicking the generate matrix A button
        private void buttonMatrixAGenerate_Click(object sender, EventArgs e)
        {
            //get the rows and column text box text
            string matrixRows = textBoxMatrixARows.Text;
            string matrixColumns = textBoxMatrixAColumns.Text;

            //try to make a matrix out of the text entered in the text boxes
            try
            {
                //create matrix A from textbox text
                matrixA = new Matrix(matrixRows, matrixColumns);
                //update matrix A display text
                textBoxMatrixADisplay.Text = matrixA.ToString();
            }
            //catch exception thrown from making matrix
            catch (InvalidOperationException err)
            {
                //display exception
                MessageBox.Show(err.Message, "Warning");
            }
        }

        //event for clicking the generate matrix B button
        private void buttonMatrixBGenerate_Click(object sender, EventArgs e)
        {
            //get the row and column text box text
            string matrixRows = textBoxMatrixBRows.Text;
            string matrixColumns = textBoxMatrixBColumns.Text;

            //try to make a matrix from the textbox text
            try
            {
                //create matrix B from row and column text
                matrixB = new Matrix(matrixRows, matrixColumns);
                //update maxtrix B textbox text
                textBoxMatrixBDisplay.Text = matrixB.ToString();
            }
            //catch exception thrown from creating matrix
            catch (InvalidOperationException err)
            {
                //display exception
                MessageBox.Show(err.Message, "Warning");
            }
        }

        //event for when you click the clear button
        private void buttonMatrixAllClear_Click(object sender, EventArgs e)
        {
            //clear the matrices
            ClearMatrix();
            //clear text boxes displaying the matrices
            ClearMatrixTextBox();
        }

        //clears the matrixes in the forms
        private void ClearMatrix()
        {
            //set all the matrices to new empties
            matrixA = new Matrix(0, 0);
            matrixB = new Matrix(0, 0);
            matrixC = new Matrix(0, 0);
        }

        //clears the matrix display textboxes
        private void ClearMatrixTextBox()
        {
            //set the display textboxes to empty
            textBoxMatrixADisplay.Text = String.Empty;
            textBoxMatrixBDisplay.Text = String.Empty;
            textBoxMatrixCDisplay.Text = String.Empty;
        }
    }
}
