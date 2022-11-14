using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace PocketDoctor
{
    public partial class Inlogscherm : Form
    {
        private DatabaseHandler dbh;

        private string hashedPassword;
        private string salt;

        public Inlogscherm()
        {
            InitializeComponent();

            dbh = new DatabaseHandler();
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
            this.Hide();
            var registreren = new Registratie();
            registreren.Closed += (s, args) => this.Close();
            registreren.Show();
        }

        private void inlogKnop_Click(object sender, EventArgs e)
        {
            bool bsnGoed = false;
            bool wwGoed = false;

            if (bsn.Text.Length < 9)
            {
                MessageBox.Show("Voer een volledig BSN-nummer in alstublieft.");
                bsn.Text = String.Empty;
            }
            else
            {
                bsnGoed = true;
            }

            if (ww.Text.Length < 5)
            {
                MessageBox.Show("Uw wachtwoord is te zwak. Voer een sterker wachtwoord in alstublieft.");
                ww.Text = String.Empty;
            }
            else
            {
                wwGoed = true;
            }

            if (wwGoed == true && bsnGoed == true)
            {

                dbh.TestConnection();
                dbh.OpenConnectionToDB();

                bool exist = false;

                using (SqlCommand cmd = new SqlCommand("SELECT Salt FROM Persoon WHERE BSN =  @BSN", dbh.GetCon()))
                {
                    cmd.Parameters.AddWithValue("BSN", bsn.Text);

                    this.salt = Convert.ToString(cmd.ExecuteScalar());
                }

                if (salt != "")
                {
                    var saltBytes = Convert.FromBase64String(this.salt);
                    var rfc2898DeriveBytes = new Rfc2898DeriveBytes(ww.Text, saltBytes, 10000);
                    hashedPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

                    using (SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM [Persoon] WHERE BSN = @BSN AND Wachtwoord = @Wachtwoord", dbh.GetCon()))
                    {
                        cmd.Parameters.AddWithValue("BSN", bsn.Text);
                        cmd.Parameters.AddWithValue("Wachtwoord", hashedPassword);

                        exist = (int)cmd.ExecuteScalar() > 0;
                    }

                    if (exist)
                    {
                        int userID;

                        using (SqlCommand cmd = new SqlCommand("SELECT Id FROM Persoon WHERE BSN =  @BSN", dbh.GetCon()))
                        {
                            cmd.Parameters.AddWithValue("BSN", bsn.Text);

                            userID = Convert.ToInt16(cmd.ExecuteScalar());
                        }

                        this.Hide();
                        var inloggen = new Hoofdmenu(userID);
                        inloggen.Closed += (s, args) => this.Close();
                        inloggen.Show();
                    }
                    else
                    {
                        MessageHandler.ShowMessage("Verkeerde BSN en/of wachtwoord!");
                    }
                }
                else
                {
                    MessageHandler.ShowMessage("Gebruiker bestaat niet.");
                }      
                dbh.CloseConnectionToDB();
            }
        }

        private void Bsn_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(bsn.Text, "[^0-9]"))
            {
                MessageBox.Show("Alleen cijfers alstublieft.");
                bsn.Text = "";
            }
        }
    }
}
