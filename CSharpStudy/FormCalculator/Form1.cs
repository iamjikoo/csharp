using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace FormCalculator
{
    public partial class Form1 : Form
    {

        StringBuilder sbEquation = new StringBuilder();
        StringBuilder sbNumber = new StringBuilder();

        String symbol = "";

        //CalcAttributes attr = CalcAttributes.None;
       
        double operand1 = 0;
        double operand2 = 0;

        double savedResult = 0;

        bool hasOperator = false;
        //char preInput = '\0';
        
        //StringBuilder sb

        //[Flags]
        //enum CalcAttributes
        //{
        //    None = 0,

        //    hasOperator = 1 << 0, // 0x01
        //    hasOperand1 = 1 << 1, // 0x02
        //    hasOperand2 = 1 << 2, // 0x04
        //    hasEqual    = 1 << 3  // 0x08
               
        //}

        //void SetFlag(CalcAttributes flag)    { attr |= flag;  }
        //void ClearFlag(CalcAttributes flag)  { attr &= ~flag; }
        //void ToggleFlag(CalcAttributes flag) { attr ^= flag;  }

        //void ClearAllFlags() { attr = CalcAttributes.None; }

        public double CalculateOperation()
        {
            double output = 0.0;

            switch (symbol)
            {
                case "+":
                    output = operand1 + operand2;
                    break;

                case "-":
                    output = operand1 - operand2; 
                    break;

                case "×": // * 
                    output = operand1 * operand2;
                    break;

                case "÷": // /
                    output = operand1 / operand2;
                    break;

                default:
                    break;
            }

            return output;

        }

        void UpdateEquation()
        {
            // + , -, * / 기준으로 공백넣기 
            lbl_equation.Text = sbEquation.ToString();
        }

        void UpdateResultLabel(string number)
        {
            double result = double.Parse(number);
            lbl_result.Text = string.Format("{0:#,###.################}", result); // format a number with comma 123,456
            //lbl_result.Text = string.Format("{0:NG16}", result); // format a number with comma 123,456
            //lbl_result.Text = string.Format("{0:#,##0;(#,##0);Zero}", result);
        }

        void UpdateInput()
        {
            double result = (sbNumber.Length > 0) ? double.Parse(sbNumber.ToString()) : 0;
            lbl_result.Text = string.Format("{0:#,##0.################}", result);
        }

        void UpdateOutput()
        {
        }

        bool HasEquationEqual()
        {
            return (sbEquation.ToString().EndsWith("="));
        }

        public void SetOperator(string symbol)
        {
            if (hasOperator)
            {
                if (this.symbol != symbol)
                {
                    this.symbol = symbol;

                    sbEquation.Remove(sbEquation.Length - 1, 1);
                    sbEquation.Append(symbol);

                    //ReplaceLastEquation();

                    
                    UpdateEquation();
                }
            } else 
            {
                this.symbol = symbol;
                hasOperator = true;

                // if the equation includes equal sign, 
                if (sbEquation.ToString().EndsWith("="))
                {
                    operand1 = savedResult;
                    savedResult = 0;

                    sbEquation.Clear();
                } else
                {
                    if (sbNumber.Length > 0)
                    {
                        operand1 = double.Parse(sbNumber.ToString());
                        sbNumber.Clear();

                    } else
                    {
                        operand1 = 0;
                        UpdateResultLabel(savedResult.ToString());

                    }
                    //operand1 = (sbNumber.Length > 0) ? double.Parse(sbNumber.ToString()): 0;
                    //sbNumber.Clear();
                }

                //if (sbNumber.Length > 0)
                //{
                //    operand1 = double.Parse(sbNumber.ToString());
                //} else
                //{
                //    operand1 = savedResult;
                //    savedResult = 0;
                //}

                // update equation label
                //sbEquation.Append(sbNumber.ToString());
                sbEquation.Append(operand1.ToString());
                sbEquation.Append(symbol);
                UpdateEquation();

            }

        }

        public void ResetOperator(string symbol)
        {
            this.symbol = "";
            hasOperator = false;
        }

        public void SetOperand(string number)
        {
            // check previous equation
            if (sbEquation.ToString().EndsWith("="))
            {
                sbNumber.Clear();
                sbEquation.Clear();

                UpdateEquation();
                hasOperator = false;
            }

            // if number includes ., check the size to 17
            int maxLen = 16;
            if (sbNumber.ToString().IndexOf('.') >= 0)
            {
                maxLen += 1;
            }

            if (sbNumber.Length < maxLen)
            {
                sbNumber.Append(number);

                UpdateResultLabel(sbNumber.ToString());

            }
        }


        private void btn_decimal_Click(object sender, EventArgs e)
        {
            if (sbNumber.Length > 1)
                sbNumber.Append(".");
            lbl_result.Text = sbNumber.ToString();
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            //operand1 = double.Parse(sbOperand1.ToString());

            // update operand 2
            operand2 = double.Parse(sbNumber.ToString());
            sbNumber.Clear();

            double result = CalculateOperation();
            UpdateResultLabel(result.ToString());

            // Update equation
            sbEquation.Append(operand2.ToString());
            sbEquation.Append("=");

            UpdateEquation();


            // clear 
            hasOperator = false;

            // save operand1
            // save result
            savedResult = result;
            operand1 = savedResult;
        }

        private void btn_c_Click(object sender, EventArgs e)
        {

            hasOperator = false;

            sbEquation.Clear();
            UpdateEquation();

            sbNumber.Clear();
            UpdateInput();

        }

        private void btn_ce_Click(object sender, EventArgs e)
        {
            sbNumber.Clear();

            UpdateInput();

            if (HasEquationEqual())
            {
                sbEquation.Clear();
                hasOperator = false;

                UpdateEquation();
            }

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (sbNumber.Length > 0)
            {
                sbNumber.Remove(sbNumber.Length - 1, 1);

                UpdateInput();
            }
            else
            {
                if (HasEquationEqual())
                {
                    sbEquation.Clear();
                    hasOperator = false;

                    UpdateEquation();
                }
            }

        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            SetOperator("+");
        }
        private void btn_subtract_Click(object sender, EventArgs e)
        {
            SetOperator("-");
        }
        private void btn_multiply_Click(object sender, EventArgs e)
        {
            SetOperator("×");
        }
        private void btn_divide_Click(object sender, EventArgs e)
        {
            SetOperator("÷");
        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            SetOperand("1");
        }     

        private void btn_two_Click(object sender, EventArgs e)
        {
            SetOperand("2");
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            SetOperand("3");
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            SetOperand("4");
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            SetOperand("5");
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            SetOperand("6");
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            SetOperand("7");
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            SetOperand("8");
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            SetOperand("9");
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            SetOperand("0");
        }
        private void btn_sign_Click(object sender, EventArgs e)
        {

        }

        private void btn_fraction_Click(object sender, EventArgs e)
        {

        }

        private void btn_square_Click(object sender, EventArgs e)
        {

        }

        private void btn_sqrt_Click(object sender, EventArgs e)
        {

        }

        private void btn_percentage_Click(object sender, EventArgs e)
        {

        }
        public Form1()
        {
            InitializeComponent();
        }

    } // class

} // namespace
