using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace PocketDoctor
{
    class DatabaseHandler
    {
        private SqlConnection con;

        public DatabaseHandler()
        {
            string Path = Environment.CurrentDirectory;
            string[] appPath = Path.Split(new string[] { "bin" }, StringSplitOptions.None);
            AppDomain.CurrentDomain.SetData("DataDirectory", appPath[0]);

            con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\db.mdf';Integrated Security=True;Connect Timeout=30");
        }

        public void TestConnection()
        {
            bool open = false;

            try
            {
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    open = true;
                }

                con.Close();
            }

            if (!open)
            {
                MessageBox.Show("Programma wordt afgelosten, kan geen verbinding maken met de database.");
                Application.Exit();
            }
        }

        public void OpenConnectionToDB()
        {
            con.Open();
        }

        public void CloseConnectionToDB()
        {  
            con.Close();
        }

        public SqlConnection GetCon()
        {
            return con;
        }

        public void Execute(string query)
        {
            SqlCommand queryExecute = new SqlCommand(query, con);

            try
            {
                TestConnection();
                OpenConnectionToDB();

                queryExecute.Prepare();
                queryExecute.ExecuteReader();

                CloseConnectionToDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");

                CloseConnectionToDB();
            }
        }
    }
}