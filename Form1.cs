using System.Windows.Forms;
using MySqlConnector;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;User ID= root;Password='';Database=ado-net01";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    //Console.WriteLine("Connexion � la base de donn�es r�ussie.");
                    MessageBox.Show("Connexion � la base de donn�es r�ussie.", "Succ�s", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de connexion � la base de donn�es : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
