using System;
using System.Windows.Forms;
using MySqlConnector;

namespace WinFormsApp_adoConnectMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //ado-net-poo-student
        private void button1_Click(object sender, EventArgs e)
        {
            string connectString = "Server=localhost;User ID=root; Password=''; Database=ado-net-poo-student";
            
            try
            {
                using (MySqlConnection connect = new MySqlConnection(connectString))
                {
                    connect.Open();
                    MessageBox.Show("Connexion a la DB avec success", "success", MessageBoxButtons.OK, MessageBoxIcon.Information );
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur de connexion a la DB " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error );
            }
        }
    }
}
