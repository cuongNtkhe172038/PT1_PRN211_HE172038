using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ptb1win
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Double.Parse(txtA.Text);
                double b = Double.Parse(txtB.Text);
                // logic
                if (a != 0)
                {
                    lblResult.Text = "PT co 1 No :" + (-b / a);
                }
                else if (b == 0)
                {
                    lblResult.Text = "PT co VSN";
                }
                else
                {
                    lblResult.Text = "PT VN";
                }
            }
            catch
            {
                lblResult.ForeColor = Color.Red;    // doi mau font chu
                lblResult.Text = "Input Err";
            };
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();   
            // txtCardID.Text = "";
        }
    }
}
