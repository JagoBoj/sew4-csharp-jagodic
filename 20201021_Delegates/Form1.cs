using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20201021_Delegates
{
    public partial class Delegates_Form : Form
    {
        delegate string GluekwunschHandler(string sender);
        GluekwunschHandler Gluekwunsch;
        Person helene = new Person("Helene");

        public Delegates_Form()
        {
            InitializeComponent();
        }

        private void BtnCallMethod_Click(object sender, EventArgs e)
        {
            if (Gluekwunsch != null)
            {
                lblOut.Text = Gluekwunsch(helene.Name);
            }
            else MessageBox.Show("Mit keiner Methode verbunden!");
        }

        private void CbxConnection_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxConnection.Checked)
            {
                Gluekwunsch = new GluekwunschHandler(helene.ZumGeburtstag);
                Gluekwunsch += new GluekwunschHandler(helene.ZumNamensTag);

                lblOut.Text = "connected";
            }
            if (!cbxConnection.Checked)
            {
                Gluekwunsch -= new GluekwunschHandler(helene.ZumGeburtstag);
                Gluekwunsch -= new GluekwunschHandler(helene.ZumNamensTag);

                lblOut.Text = "disconnected";
            }
        }
    }
}
