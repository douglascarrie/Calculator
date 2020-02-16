using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_basic_calc
{
    /// <summary>
    /// Basic calc
    /// </summary>
    public partial class Form1 : Form
    {
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        #endregion



        

        #region Operator Functions

        private void DivideButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("/");
        }

        private void TimesButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("x");
        }
        private void MinusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("-");
        }

        private void PlusButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("+");
        } 
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            CalculateEquation();
        }
        #endregion

        #region Number Methods

        private void SevenButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("7");
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("8");
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("9");
        }

       
        private void SixButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("6");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("5");
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("4");
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("3");
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            InsertTextValue("0");
            
        }

       

        private void PointButton_Click(object sender, EventArgs e)
        {
            InsertTextValue(".");
        }

        #endregion

        #region Clearing methods

        /// <summary>
        /// Clears input text
        /// </summary>
        /// <param name="sender">The event sender</param>
        /// <param name="e">the event arguments</param>
        private void CEButton_Click(object sender, EventArgs e)
        {
            this.UserInputText.Text = string.Empty;

            // Focus user input
            FocusInputText();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            if (this.UserInputText.Text.Length < this.UserInputText.SelectionStart + 1)
                return;

            this.UserInputText.Text = this.UserInputText.Text.Remove(this.UserInputText.SelectionStart, 1);
        }
        #endregion


        #region Private Helpers

        /// <summary>
        /// Focuses user input text
        /// </summary>
        private void FocusInputText ()
        {
            this.UserInputText.Focus();
        }

        /// <summary>
        /// Inserts given num into text box
        /// </summary>
       
        private void InsertTextValue(string value)
        {
            this.UserInputText.Text = this.UserInputText.Text.Insert(this.UserInputText.SelectionStart, value);
        }

        private void CalculateEquation()
        {

        }
        #endregion

    }
}
