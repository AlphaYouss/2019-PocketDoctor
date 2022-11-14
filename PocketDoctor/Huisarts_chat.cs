using System;
using System.Timers;
using System.Threading;
using System.Windows.Forms;

namespace PocketDoctor
{
    public partial class Huisarts_chat : Form
    {
        private int userID;

        public Huisarts_chat(int userID)
        {
            InitializeComponent();
            this.userID = userID;
        }

        private void sluit_chat_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hoofdmenu = new Hoofdmenu(userID);
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }

        private void terug_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hoofdmenu = new Hoofdmenu(userID);
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
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

        private void verzend_bericht_Click(object sender, EventArgs e)
        {
            string bericht = invoerBox.Text;
            DateTime tijd = DateTime.Now;

            bericht = bericht.ToLower();

            if((bericht.Contains("hallo") || bericht.Contains("hoi") || bericht.Contains("hi") || bericht.Contains("hey") || bericht.Contains("hee") || bericht.Contains("ha") || bericht.Contains("yo") || bericht.Contains("fakka") || bericht.Contains("ewa") || bericht.Contains("sup") || bericht.Contains("ey") || bericht.Contains("yow")))
            {
                chatBox.Items.Add("Ik: " + bericht);
                datum_chatBox.Items.Add(tijd);
                invoerBox.Text = String.Empty;
                reactietijd();
                datum_chatBox.Items.Add(tijd);
                chatBox.Items.Add("Huisarts: Goedendag, waarmee kan ik u helpen?");
            }
            else if ((bericht.Contains("pijn"))){
                chatBox.Items.Add("Ik: " + bericht);
                datum_chatBox.Items.Add(tijd);
                invoerBox.Text = String.Empty;
                reactietijd();
                datum_chatBox.Items.Add(tijd);
                chatBox.Items.Add("Huisarts: Waar zit de pijn precies?");
            }
            else
            {
                chatBox.Items.Add("Ik: " + bericht);
                datum_chatBox.Items.Add(tijd);
                invoerBox.Text = String.Empty;
                reactietijd();
                datum_chatBox.Items.Add(tijd);
                chatBox.Items.Add("Huisarts: Hier kan ik je niet mee helpen.");         
            }
        }

        private void reactietijd()
        {
            chatBox.Invalidate();
            chatBox.Update();
            chatBox.Refresh();

            Application.DoEvents();
            Thread.Sleep(1000);
        }
    }
}
