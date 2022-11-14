using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Globalization;

namespace PocketDoctor
{
    public partial class Registratie : Form
    {
        private DatabaseHandler dbh;

        public bool check = true;

        public Registratie()
        {
            InitializeComponent();

            dbh = new DatabaseHandler();
            geslachtBox.SelectedIndex = 0;
        }

        private void terugKnop_Click(object sender, EventArgs e)
        {
            this.Hide();
            var terug = new Welkomscherm();
            terug.Closed += (s, args) => this.Close();
            terug.Show();
        }

        private void registratieKnop_Click(object sender, EventArgs e)
        {
            check = true;

            if (voornaamBox.Text.Length < 2)
            {
                MessageBox.Show("Voer een volledige voornaam in alstublieft.");
                voornaamBox.Text = String.Empty;

                check = false;
            }

            if (achternaamBox.Text.Length < 2)
            {
                MessageBox.Show("Voer een volledige achternaam in alstublieft.");
                achternaamBox.Text = String.Empty;

                check = false;
            }

            if (gebdatumBox.Text.Length < 10)
            {
                MessageBox.Show("Voer een correcte datum in alstublieft.");
                gebdatumBox.Text = String.Empty;

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

            if (wwBox.Text.Length < 5)
            {
                MessageBox.Show("Uw wachtwoord is te zwak. Voer een sterker wachtwoord in alstublieft.");
                wwBox.Text = String.Empty;

                check = false;
            }

            if (wwBox.Text != verifWwBox.Text && wwBox.Text != "")
            {
                MessageBox.Show("Het herhaalde wachtwoord komt niet overeen met het ingevoerde wachtwoord!");
                verifWwBox.Text = String.Empty;

                check = false;
            }

            if (Telnrbox.Text.Length < 8)
            {
                MessageBox.Show("Voer een volledig telefoonnummer in alstublieft.");
                Telnrbox.Text = String.Empty;

                check = false;
            }

            if (BSNbox.Text.Length < 9)
            {
                MessageBox.Show("Voer een volledig BSN-nummer in alstublieft.");
                BSNbox.Text = String.Empty;

                check = false;
            }

            if (check == true) {
                
                byte geslacht;
                try
                {
                    DateTime geboorteDatum = DateTime.ParseExact(gebdatumBox.Text, "dd-mm-yyyy", CultureInfo.GetCultureInfo("nl-NL"));
                    gebdatumBox.Text = geboorteDatum.ToString("yyyy-MM-dd");
                }
                catch
                {
                    MessageBox.Show("You fucked up fam");
                }
                if (geslachtBox.Text == "Man")
                {
                    geslacht = 1;
                }
                else
                {
                    geslacht = 0;
                }

                dbh.TestConnection();
                dbh.OpenConnectionToDB();

                bool exist = false;

                using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Persoon] WHERE BSN = @BSN", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("BSN", BSNbox.Text);

                    exist = (int)cmd.ExecuteScalar() > 0;
                }

                dbh.CloseConnectionToDB();

                if (exist)
                {
                    MessageHandler.ShowMessage("Gebruiker bestaat al!");
                }
                else
                {
                    string password = wwBox.Text;

                    var saltBytes = new byte[16];
                    var provider = new RNGCryptoServiceProvider();
                    provider.GetNonZeroBytes(saltBytes);

                    var salt = Convert.ToBase64String(saltBytes);
                    var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
                    var hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

                    string sql = "INSERT INTO [Persoon] ([Naam], [Achternaam], [Geboortedatum], [Telefoonnummer], [Mail], [Geslacht], [BSN], [Wachtwoord], [Salt], [Aangemaakt]) VALUES ('" + voornaamBox.Text + "', '" + achternaamBox.Text + "', '" + gebdatumBox.Text + "', '" + Telnrbox.Text + "', '" + mailadresBox.Text + "', '" + geslacht + "', '" + BSNbox.Text + "', '" + hashPassword + "', '" + salt + "', '" + DateTime.Now + "')";

                    dbh.Execute(sql);

                    this.Hide();
                    var registreren = new Registratie_voltooid();
                    registreren.Closed += (s, args) => this.Close();
                    registreren.Show();
                }  
            }
        }

        private void VoornaamBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(voornaamBox.Text, "[^a-zA-Z .]"))
            {
                MessageBox.Show("Alleen letters alstublieft.");
                voornaamBox.Text = "";
            }
        }

        private void AchternaamBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(achternaamBox.Text, "[^a-zA-Z .]"))
            {
                MessageBox.Show("Alleen letters alstublieft.");
                achternaamBox.Text = "";
            }
        }

        private void Telnrbox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(Telnrbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Alleen cijfers alstublieft.");
                Telnrbox.Text = "";
            }
        }

        private void BSNbox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(BSNbox.Text, "[^0-9]"))
            {
                MessageBox.Show("Alleen cijfers alstublieft.");
                BSNbox.Text = "";
            }
        }

        private void GebdatumBox_TextChanged(object sender, EventArgs e)
        {
            if (Regex.IsMatch(gebdatumBox.Text, "[^0-9-]"))
            {
                MessageBox.Show("Alleen datums alstublieft.");
                gebdatumBox.Text = "";
            }
        }
    }
}
