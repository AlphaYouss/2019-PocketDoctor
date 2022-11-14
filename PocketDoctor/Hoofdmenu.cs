using System;
using System.Windows.Forms;

namespace PocketDoctor
{
    public partial class Hoofdmenu : Form
    {
        private int userID;
        public Hoofdmenu(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void klachtenlijst_Click(object sender, EventArgs e)
        {
            this.Hide();
            var klachtenlijst = new Klachtenlijst(userID);
            klachtenlijst.Closed += (s, args) => this.Close();
            klachtenlijst.Show();
        }

        private void advies_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //var advies = new Advies(userID);
            //advies.Closed += (s, args) => this.Close();
            //advies.Show();
        }

        private void huisartschat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var huisartschat = new Huisarts_chat(userID);
            huisartschat.Closed += (s, args) => this.Close();
            huisartschat.Show();
        }

        private void Persoonsgegevens_wijzigen_Click(object sender, EventArgs e)
        {
            this.Hide();
            var profiel = new Profiel(userID);
            profiel.Closed += (s, args) => this.Close();
            profiel.Show();
        }

        private void uitloggen_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Inlogscherm = new Inlogscherm();
            Inlogscherm.Closed += (s, args) => this.Close();
            Inlogscherm.Show();
        }
    }
}
