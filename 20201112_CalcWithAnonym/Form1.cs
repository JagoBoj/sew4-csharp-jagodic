using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201112_CalcWithAnonym
{
    public partial class Form1 : Form
    {
        public delegate double MathOperationsHandler(double x, double y);
        MathOperationsHandler MathOperations;

        public Form1()
        {
            InitializeComponent();
        }

        private void rdoConnectSum_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoConnectSum.Checked)
            {
                MathOperations = delegate (double x, double y)
                {
                    return x + y;
                };
            }
        }

        private void rdoConnectDiff_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoConnectDiff.Checked)
            {
                MathOperations = delegate (double x, double y)
                {
                    return x - y;
                };
            }
        }

        private void cmdCompute_Click(object sender, EventArgs e)
        {
            if (MathOperations != null)
            {
                double inputX = Convert.ToDouble(txtX.Text);
                double inputY = Convert.ToDouble(txtY.Text);

                txtResult.Text = MathOperations(inputX, inputY).ToString();
            }
            else
            {
                MessageBox.Show("Mit keiner Methode verbunden!");
            }
        }

        private void CmdDelete_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }
    }
}
