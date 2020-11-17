using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201112_CalcWithLambda
{
    public partial class Form1 : Form
    {
        Func<double, double, double> MathOperations;
        Action<string> OutputOperations;

        public Form1()
        {
            InitializeComponent();
        }

        private void rdoConnectSum_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoConnectSum.Checked)
            {
                MathOperations = (x, y) => x + y;
            }
        }

        private void rdoConnectDiff_CheckedChanged(object sender, EventArgs e)
        {
            if ( rdoConnectDiff.Checked )
            {
                MathOperations = (x, y) => x - y;
            }
        }

        private void cmdCompute_Click(object sender, EventArgs e)
        {
            if (MathOperations != null)
            {
                double inputX = Convert.ToDouble(txtX.Text);
                double inputY = Convert.ToDouble(txtY.Text);

                OutputOperations = (string output) => txtResult.Text = output;
                OutputOperations += ( string output ) => MessageBox.Show(output);
                
                OutputOperations(MathOperations(inputX, inputY).ToString());
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
