﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace matrix
{
    public partial class Form1 : Form
    {
        //Operation enumeration to store radio button state
        enum Operation
        {
            Multiplication, Addition, Subtraction, ABeq
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
            matrixA = null;
            matrixB = null;
            matrixC = null;

            //collect all the text boxes that must have integers in them; to have checked with a listener on Leave
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

        private void radioButtonABeq_CheckedChanged(object sender, EventArgs e)
        {
            operation = Operation.ABeq;
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
                        matrixC = matrixA * matrixB;
                        textBoxMatrixCDisplay.Text = matrixC.ToString();
                        break;
                    //perform addition
                    case Operation.Addition:
                        matrixC = matrixA + matrixB;
                        textBoxMatrixCDisplay.Text = matrixC.ToString();
                        break;
                    //perform subtraction
                    case Operation.Subtraction:
                        matrixC = matrixA - matrixB;
                        textBoxMatrixCDisplay.Text = matrixC.ToString();
                        break;
                    case Operation.ABeq:
                        textBoxMatrixCDisplay.Text = matrixA == matrixB ? "A is equal to B" : "A is not equal to B";
                        break;
                    //? should not hit
                    default:
                        matrixC = new Matrix(0, 0);
                        break;
                }
            }
            //catch if the math operation threw an exception
            catch (Exception err)
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
                if (matrixB != null)
                {
                    //try to trun matrix B into an Identity matrix
                    matrixB.makeId();
                    //update the matrix B disaply textbox
                    textBoxMatrixBDisplay.Text = matrixB.ToString();
                }
                else
                {
                    MessageBox.Show("Matrix B is null");
                }
            }
            //catch an exception thrown by turning the matrix into an idenity
            catch (Exception err)
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
            catch (Exception err)
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
            catch (Exception err)
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
            matrixA = null;
            matrixB = null;
            matrixC = null;
        }

        private void buttonClone_Click(object sender, EventArgs e)
        {
            if (matrixA == null)
            {
                MessageBox.Show("Matrix A is null");
                return;
            }

            matrixB = new Matrix(matrixA.Rows, matrixA.Cols);
            matrixB.clone(matrixA);
            textBoxMatrixBDisplay.Text = matrixB.ToString();
        }

        //clears the matrix display textboxes
        private void ClearMatrixTextBox()
        {
            //set the display textboxes to empty
            textBoxMatrixADisplay.Text = String.Empty;
            textBoxMatrixBDisplay.Text = String.Empty;
            textBoxMatrixCDisplay.Text = String.Empty;
        }

        //event for exit button click
        private void buttonExit_Click(object sender, EventArgs e)
        {
            //close the form
            Close();
        }

    }
}
