using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_
{
    public partial class Form1 : Form
    {
        public static string Number1 = "";
        public static string Number2 = "";
        public static string result = "";
        public static string Operation;


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Info_Click_1(object sender, EventArgs e)
        {
            Info info = new Info();
            info.Show();
        }
        
        private void btn_Del_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void btn_N1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void btn_N2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void btn_N3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void btn_N4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void btn_N5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void btn_N6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void btn_N7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void btn_N8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void btn_N9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void btn_N0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (Number1=="")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("ابتدا عدد را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
                else
                {
                    Number1 = textBox1.Text;
                    Operation = "+";
                    textBox1.Text = "";
                }
            }

            
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            if (Number1 == "")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("ابتدا عدد را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
                else
                {
                    Number1 = textBox1.Text;
                    Operation = "-";
                    textBox1.Text = "";
                }
            }
        }

        private void btn_T_Click(object sender, EventArgs e)
        {
            if (Number1 == "")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("ابتدا عدد را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
                else
                {
                    Number1 = textBox1.Text;
                    Operation = "/";
                    textBox1.Text = "";
                }
            }
        }

        private void btn_X_Click(object sender, EventArgs e)
        {
            if (Number1 == "")
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("ابتدا عدد را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
                }
                else
                {
                    Number1 = textBox1.Text;
                    Operation = "X";
                    textBox1.Text = "";
                }
            }
        }

        private void btn_result_Click(object sender, EventArgs e)
        {
            if (Number1 == "")
            {
                MessageBox.Show("ابتدا عدد را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading);
            }
            else
            {
                Number2 = textBox1.Text;
                CheckOperation();
                textBox1.Text = result;
            }

        }

        private void CheckOperation()
        {
            if (Operation == "+")
            {
                result = Convert.ToString(Convert.ToInt32(Number1) + Convert.ToInt32(Number2));
            }else if(Operation == "-")            
            {
                result = Convert.ToString(Convert.ToInt32(Number1) - Convert.ToInt32(Number2));
            }
            else if(Operation == "X")            
            {
                result = Convert.ToString(Convert.ToInt32(Number1) * Convert.ToInt32(Number2));
            }
            else if(Operation == "/")            
            {
                result = Convert.ToString(Convert.ToInt32(Number1) / Convert.ToInt32(Number2));
            }
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            Number1 = "";
            Number2 = "";
            result = "";
        }
    }
}
