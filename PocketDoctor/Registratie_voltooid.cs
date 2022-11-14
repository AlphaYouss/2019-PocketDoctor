using System;
using System.Windows.Forms;

namespace PocketDoctor
{
    public partial class Registratie_voltooid : Form
    {
        public Registratie_voltooid()
        {
            InitializeComponent();
        }

        private void inlogKnop_Click(object sender, EventArgs e)
        {
            this.Hide();
            var inloggen = new Inlogscherm();
            inloggen.Closed += (s, args) => this.Close();
            inloggen.Show();
        }
    }
}
