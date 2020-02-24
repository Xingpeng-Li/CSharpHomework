using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Window
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            error.Text = "";
            result.Text = "";
            int number1, number2;  //两个操作数
            int res;  //结果
            try
            {
                number1 = Int32.Parse(num1.Text);
                number2 = Int32.Parse(num2.Text);
                //根据操作符计算结果
                switch (op.Text)
                {
                    case "+":
                        res = number1 + number2;
                        break;
                    case "-":
                        res = number1 - number2;
                        break;
                    case "*":
                        res = number1 * number2;
                        break;
                    case "/":
                        if (number2 == 0)
                        {
                            error.Text = "Error:divide by 0!";  //除数为0
                            return;
                        }
                        else
                        {
                            res = number1 / number2;
                        }
                        break;
                    default:
                        error.Text = "Error:please choose an operator!";
                        return;
                }
                //输出结果
                result.Text = $"Result:{res}.";
            }
            catch (FormatException)
            {
                error.Text = "Error:invalid format!";
            }
            catch (OverflowException)
            {
                error.Text = "Error:overflow!";
            }
            finally
            {
                //clear
                num1.Clear();
                num2.Clear();
            }
        }
    }
}
