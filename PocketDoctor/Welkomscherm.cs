using System;
using System.Windows.Forms;

namespace PocketDoctor
{
    public partial class Welkomscherm : Form
    {
        public Welkomscherm()
        {
            InitializeComponent();
        }

        private void registratieKnop_Click(object sender, EventArgs e)
        {
            this.Hide();
            var registreren = new Registratie();
            registreren.Closed += (s, args) => this.Close();
            registreren.Show();
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
