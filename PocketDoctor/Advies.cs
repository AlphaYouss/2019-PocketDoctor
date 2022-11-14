using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PocketDoctor
{
    public partial class Advies : Form
    {
        private int OplossingId;
        private int OorzaakId;
        private int userID;
        private string ziekte;
        private DatabaseHandler dbh;

        public Advies(int OplossingId, int OorzaakId, int userID, string ziekte)
        {
            InitializeComponent();
            this.userID = userID;
            this.OplossingId = OplossingId;
            this.OorzaakId = OorzaakId;
            this.ziekte = ziekte;

            dbh = new DatabaseHandler();

            dbh.TestConnection();
            dbh.OpenConnectionToDB();


            using (SqlCommand cmd = new SqlCommand("SELECT Beschrijving FROM Oorzaak WHERE Id =  @Id", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("Id", OorzaakId);

                beschrijvingBox.Text = Convert.ToString(cmd.ExecuteScalar());
            }

            using (SqlCommand cmd = new SqlCommand("SELECT Advies FROM Oplossing WHERE Id =  @Id", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("Id", OplossingId);

                adviesBox.Text = Convert.ToString(cmd.ExecuteScalar());
            }

            ziekteLabel.Text = ziekte;

            dbh.CloseConnectionToDB();
        }

        private void terug_Click(object sender, EventArgs e)
        {
            Hoofdmenu hoofdmenu = new Hoofdmenu(userID);
            hoofdmenu.Show();
            this.Hide();
        }

        private void chat_Click(object sender, EventArgs e)
        {
            Huisarts_chat huisartschat = new Huisarts_chat(userID);
            huisartschat.Show();
            this.Hide();
        }

        private void uitloggen_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Inlogscherm = new Inlogscherm();
            Inlogscherm.Closed += (s, args) => this.Close();
            Inlogscherm.Show();
        }

        private void Persoonsgegevens_aanpassen_Click(object sender, EventArgs e)
        {
            this.Hide();
            var profiel = new Profiel(userID);
            profiel.Closed += (s, args) => this.Close();
            profiel.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var hoofdmenu = new Hoofdmenu(userID);
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }
    }
}
