using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClearHistory_Click(object sender, EventArgs e)
        {
            RtDisplayHistory.Clear();
            if (RtDisplayHistory.Text == string.Empty)
            {
                RtDisplayHistory.Text = "there's no history yet";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text == "0")
            {
                txtDisp1.Text = "9";
            }
            else
            {
                txtDisp1.Text += "9";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text == "0")
            {
                txtDisp1.Text = "0";
            }
            else
            {
                txtDisp1.Text += "0";
            }
        }

        private void btndeci_Click(object sender, EventArgs e)
        {
            if (!txtDisp1.Text.Contains("."))
            {
                txtDisp1.Text += ".";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text == "0")
            {
                txtDisp1.Text = "1";
            }
            else
            {
                txtDisp1.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text == "0")
            {
                txtDisp1.Text = "2";
            }
            else
            {
                txtDisp1.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text == "0")
            {
                txtDisp1.Text = "3";
            }
            else
            {
                txtDisp1.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text == "0")
            {
                txtDisp1.Text = "4";
            }
            else
            {
                txtDisp1.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text == "0")
            {
                txtDisp1.Text = "5";
            }
            else
            {
                txtDisp1.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text == "0")
            {
                txtDisp1.Text = "6";
            }
            else
            {
                txtDisp1.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text == "0")
            {
                txtDisp1.Text = "7";
            }
            else
            {
                txtDisp1.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text == "0")
            {
                txtDisp1.Text = "8";
            }
            else
            {
                txtDisp1.Text += "8";
            }
        }

        private void btnmp_Click(object sender, EventArgs e)
        {
            if (txtDisp1.Text.Contains("-"))
            {
                txtDisp1.Text = txtDisp1.Text.Trim('-');
            }
            else
            {
                txtDisp1.Text = "-" + txtDisp1.Text;
            }
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtDisp1.Text);
            txtDisp1.Clear();
            operators = "-";
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtDisp1.Text);
            txtDisp1.Clear();
            operators = "+";
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtDisp1.Text);
            txtDisp1.Clear();
            operators = "/";
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtDisp1.Text);
            txtDisp1.Clear();
            operators = "*";
        }

        private void btnage_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(txtDisp1.Text);
            txtDisp1.Clear();
            operators = "%";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(txtDisp1.Text);
                    Result = valueFirst - valueSecond;
                    txtDisp1.Text = Result.ToString();
                    RtDisplayHistory.AppendText($"{valueFirst}{valueSecond}={txtDisp1.Text}\n");
                    break;
                case "+":
                    valueSecond = decimal.Parse(txtDisp1.Text);
                    Result = valueFirst + valueSecond;
                    txtDisp1.Text = Result.ToString();
                    RtDisplayHistory.AppendText($"{valueFirst}{valueSecond}={txtDisp1.Text}\n");
                    break;
                case "*":
                    valueSecond = decimal.Parse(txtDisp1.Text);
                    Result = valueFirst * valueSecond;
                    txtDisp1.Text = Result.ToString();
                    RtDisplayHistory.AppendText($"{valueFirst}{valueSecond}={txtDisp1.Text}\n");
                    break;
                case "/":
                    valueSecond = decimal.Parse(txtDisp1.Text);
                    Result = valueFirst / valueSecond;
                    txtDisp1.Text = Result.ToString();
                    RtDisplayHistory.AppendText($"{valueFirst}{valueSecond}={txtDisp1.Text}\n");
                    break;
                case "%":
                    valueSecond = decimal.Parse(txtDisp1.Text);
                    Result = valueFirst % valueSecond;
                    txtDisp1.Text = Result.ToString();
                    RtDisplayHistory.AppendText($"{valueFirst}{valueSecond}={txtDisp1.Text}\n");
                    break;
                default: txtDisp2.Text=$"{txtDisp1.Text}=";
                    break;
            }
            Result=decimal.Parse(txtDisp1.Text);
            operators=string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            txtDisp1.Text = "0";
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            pnlHistory.Height = (pnlHistory.Height == 5) ? pnlHistory.Height = 345 : 5;        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState= FormWindowState.Normal;    
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState= FormWindowState.Normal;
            }
        }
    }
}
