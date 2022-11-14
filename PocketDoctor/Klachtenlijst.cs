using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PocketDoctor
{
    public partial class Klachtenlijst : Form
    {
        private int userID;
        private DatabaseHandler dbh;

        public Klachtenlijst(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            dbh = new DatabaseHandler();
        }

        private void terug_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hoofdmenu = new Hoofdmenu(userID);
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }

        private void uiloggen_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Inlogscherm = new Inlogscherm();
            Inlogscherm.Closed += (s, args) => this.Close();
            Inlogscherm.Show();
        }

        private void persoongegevens_wijzigen_Click(object sender, EventArgs e)
        {
            this.Hide();
            var profiel = new Profiel(userID);
            profiel.Closed += (s, args) => this.Close();
            profiel.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hoofdmenu = new Hoofdmenu(userID);
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double temperatuur = Convert.ToDouble(tempBox.Value);

            int OorzaakId = 0;
            int OplossingId = 0;
            bool huts = false;

            string ziekte;
            if(moeJa.Checked == false && moeNee.Checked == false || hoofdpijnJa.Checked == false && hoofdpijnNee.Checked == false || spierpijnJa.Checked == false && spierpijnNee.Checked == false || misselijkJa.Checked == false && misselijkNee.Checked == false)
            {
                MessageBox.Show("Vul alle velden in alstublieft.");
                huts = true;
            }

            //
            // Koorts
            //

            if (temperatuur > 38 && moeJa.Checked == true && hoofdpijnNee.Checked == true && misselijkNee.Checked == true && spierpijnJa.Checked == true)
            {
                dbh.TestConnection();
                dbh.OpenConnectionToDB();

                using (SqlCommand cmd = new SqlCommand("SELECT Id FROM Oorzaak WHERE Naam =  @Koorts", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("Koorts", "Koorts");

                    OorzaakId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (SqlCommand cmd = new SqlCommand("SELECT OplossingId FROM Oorzaak WHERE Id =  @Id", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("Id", OorzaakId);

                    OplossingId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                dbh.CloseConnectionToDB();

                ziekte = "Koorts";

                this.Hide();
                var advies = new Advies(OplossingId, OorzaakId, userID, ziekte);
                advies.Closed += (s, args) => this.Close();
                advies.Show();
            }

            //
            // Migraine
            //


            else if (temperatuur >= 35.5 && temperatuur <= 38 && moeJa.Checked == true && hoofdpijnJa.Checked == true && misselijkNee.Checked == true && spierpijnNee.Checked == true)
            {
                dbh.TestConnection();
                dbh.OpenConnectionToDB();

                using (SqlCommand cmd = new SqlCommand("SELECT Id FROM Oorzaak WHERE Naam =  @Migraine", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("Migraine", "Migraine");

                    OorzaakId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (SqlCommand cmd = new SqlCommand("SELECT OplossingId FROM Oorzaak WHERE Id =  @Id", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("Id", OorzaakId);

                    OplossingId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                dbh.CloseConnectionToDB();

                ziekte = "Migraine";

                this.Hide();
                var advies = new Advies(OplossingId, OorzaakId, userID, ziekte);
                advies.Closed += (s, args) => this.Close();
                advies.Show();
            }

            //
            // Stress
            //

            else if (temperatuur >= 35.5 && temperatuur <= 38 && moeJa.Checked == true && hoofdpijnJa.Checked == true && misselijkNee.Checked == true && spierpijnJa.Checked == true)
            {
                dbh.TestConnection();
                dbh.OpenConnectionToDB();

                using (SqlCommand cmd = new SqlCommand("SELECT Id FROM Oorzaak WHERE Naam =  @Stress", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("Stress", "Stress");

                    OorzaakId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                using (SqlCommand cmd = new SqlCommand("SELECT OplossingId FROM Oorzaak WHERE Id =  @Id", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("Id", OorzaakId);

                    OplossingId = Convert.ToInt32(cmd.ExecuteScalar());
                }

                dbh.CloseConnectionToDB();

                ziekte = "Stress";

                this.Hide();
                var advies = new Advies(OplossingId, OorzaakId, userID, ziekte);
                advies.Closed += (s, args) => this.Close();
                advies.Show();
            }
            else if(huts == true)
            {
                
            }
            else
            {
                MessageBox.Show("Dit bestaat nog niet");
            }
        }
    }
}
