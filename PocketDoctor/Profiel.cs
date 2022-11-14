using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Globalization;

namespace PocketDoctor
{
    public partial class Profiel : Form
    {
        private int userID;
        private DatabaseHandler dbh;

        public Profiel(int userID)
        {
            SqlDataReader dataReader;

            InitializeComponent();

            this.userID = userID;
            dbh = new DatabaseHandler();

            dbh.TestConnection();
            dbh.OpenConnectionToDB();

            using (SqlCommand cmd = new SqlCommand("SELECT * FROM Persoon WHERE Id =  @Id", dbh.GetCon()))
            {
                cmd.Parameters.AddWithValue("Id", userID);

                dataReader = cmd.ExecuteReader();
                dataReader.Read();

                voornaamBox.Text = dataReader.GetString(1);
                achternaamBox.Text = dataReader.GetString(2);

                DateTime geboorteDatum = dataReader.GetDateTime(3);
                string sGeboorteDatum = geboorteDatum.ToString("dd-MM-yyyy");

                gebdatumBox.Text = sGeboorteDatum;
                Telnrbox.Text = Convert.ToString(dataReader.GetInt32(4));
                mailadresBox.Text = dataReader.GetString(5);

                bool geslacht = (bool)dataReader["Geslacht"];
                if (geslacht == true)
                {
                    geslachtBox.SelectedItem = "Man";
                }
                else
                {
                    geslachtBox.SelectedItem = "Vrouw";
                }

                BSNbox.Text = dataReader.GetString(7);
            }

            dbh.CloseConnectionToDB();

            voornaamBox.Enabled = false;
            achternaamBox.Enabled = false;
            gebdatumBox.Enabled = false;
            wwBox.Enabled = false;
            verifWwBox.Enabled = false;
            BSNbox.Enabled = false;
        }

        private void saveKnop_Click(object sender, EventArgs e)
        {
            byte geslacht;
            bool check = true;

            if (Telnrbox.Text.Length < 8)
            {
                MessageBox.Show("Voer een volledig telefoonnummer in alstublieft.");
                Telnrbox.Text = String.Empty;

                check = false;
            }

            if (mailadresBox.Text.Length < 10)
            {
                MessageBox.Show("Voer een correcte e-mail in alstublieft.");
                mailadresBox.Text = String.Empty;

                check = false;
            }

            Regex regex = new Regex(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            bool isValid = regex.IsMatch(mailadresBox.Text.Trim());
            if (!isValid)
            {
                check = false;
            }

            if(check == true)
            {
                if (geslachtBox.Text == "Man")
                {
                    geslacht = 1;
                }
                else
                {
                    geslacht = 0;
                }

                string queryUpdate = "UPDATE Persoon SET Geslacht = '" + geslacht + "' , Telefoonnummer = '" + Telnrbox.Text + "' , Mail = '" + mailadresBox.Text + "' WHERE Id = '" + userID + "'";

                dbh.TestConnection();
                dbh.Execute(queryUpdate);

                MessageBox.Show("Gegevens gewijzigd!", "Melding", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                var hoofdmenu = new Hoofdmenu(userID);
                hoofdmenu.Closed += (s, args) => this.Close();
                hoofdmenu.Show();
            }
            else
            {
                MessageBox.Show("Gegevens niet geldig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void terugKnop_Click(object sender, EventArgs e)
        {
            this.Hide();
            var hoofdmenu = new Hoofdmenu(userID);
            hoofdmenu.Closed += (s, args) => this.Close();
            hoofdmenu.Show();
        }

        private void Telnrbox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Telnrbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Alleen cijfers alstublieft.");
                Telnrbox.Text = "";
            }
        }
    }
}
