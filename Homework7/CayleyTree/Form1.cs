using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CayleyTree
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1;
        double th2;
        double per1;
        double per2;

        public Form1()
        {
            InitializeComponent();
        }

        private void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if(n == 0)
            {
                return;
            }
            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, per2 * leng, th - th2);
        }

        private void drawLine(double x0,double y0,double x1,double y1)
        {
            Pen pen = null;
            foreach(Control control in pnlColorArea.Controls)
            {
                RadioButton button = (RadioButton)control;
                if(button.Checked)
                {
                    switch(button.Text)
                    {
                        case "红色":
                            pen = Pens.Red;
                            break;
                        case "黑色":
                            pen = Pens.Black;
                            break;
                        case "黄色":
                            pen = Pens.Yellow;
                            break;
                        case "绿色":
                            pen = Pens.Green;
                            break;
                        case "蓝色":
                            pen = Pens.Blue;
                            break;
                        case "橘色":
                            pen = Pens.Orange;
                            break;
                    }
                }
            }
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }
        

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if(graphics == null)
            {
                graphics = pnlDrawArea.CreateGraphics();
            }
            graphics.Clear(Form1.DefaultBackColor);
            double leng;
            try
            {
                leng = double.Parse(txtLength.Text);
            }
            catch (FormatException)
            {
                txtLength.Text = "100";
                leng = 100;
            }
            per1 = double.Parse(lblRightPerValue.Text);
            per2 = double.Parse(lblLeftPerValue.Text);
            th1 = tkbRightTh.Value * Math.PI / 180;
            th2 = tkbLeftTh.Value * Math.PI / 180;
            drawCayleyTree(int.Parse(cmbDepth.Text), 200, 310, leng, -Math.PI / 2);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDepth.SelectedIndex = 9;
            txtLength.Text = "100";
        }

        private void tkbRightPer_Scroll(object sender, EventArgs e)
        {
            double per = (double)tkbRightPer.Value / 100.0;
            lblRightPerValue.Text = per.ToString();
        }

        private void tkbLeftPer_Scroll(object sender, EventArgs e)
        {
            double per = (double)tkbLeftPer.Value / 100.0;
            lblLeftPerValue.Text = per.ToString();
        }

        private void tkbRightTh_Scroll(object sender, EventArgs e)
        {
            lblRightThValue.Text = tkbRightTh.Value.ToString() + "°";
        }

        private void tkbLeftTh_Scroll(object sender, EventArgs e)
        {
            lblLeftThValue.Text = tkbLeftTh.Value.ToString() + "°";
        }
    }
}
