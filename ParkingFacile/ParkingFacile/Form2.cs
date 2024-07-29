using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParkingFacile
{
    public partial class Form2 : Form
    {
        MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd=");
        public Form2()
        {
            InitializeComponent();
        }

        private void inscrire_Click(object sender, EventArgs e)
        {
            string pattern = @"^.*@(gmail|hotmail)\.com$|^.*@(gmail|hotmail)\.fr$";
            if (String.IsNullOrEmpty(nom.Text) || String.IsNullOrEmpty(email.Text) || String.IsNullOrEmpty(passe.Text) || String.IsNullOrEmpty(repasse.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !!");
            }else if (Regex.IsMatch(email.Text, pattern, RegexOptions.IgnoreCase) == false)
            {
                MessageBox.Show("Verifier le format de votre adresse email !!");
            }else if (passe.Text != repasse.Text)
            {
                MessageBox.Show("Votre mot de passe n'est pas comme votre re_mot de passe !!");
            }
            else
            {
                string connectionString = "database=parking_facile; server=localhost; user id=root; pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string checkQuery = "SELECT COUNT(*) FROM client WHERE NomClient = @nom";
                        string checkQuery2 = "SELECT COUNT(*) FROM client WHERE EmailClient = @email";
                        MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                        MySqlCommand checkCommand2 = new MySqlCommand(checkQuery2, connection);
                        checkCommand.Parameters.AddWithValue("@nom", nom.Text);
                        checkCommand2.Parameters.AddWithValue("@email", email.Text);
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        int count2 = Convert.ToInt32(checkCommand2.ExecuteScalar());
                        if(count == 0 && count2 == 0)
                        {
                            string insertQuery = "INSERT INTO client (NomClient, EmailClient, MotDePasseClient) VALUES (@nom, @email, @passe)";
                            MySqlCommand command = new MySqlCommand(insertQuery, connection);
                            command.Parameters.AddWithValue("@nom", nom.Text.ToUpper());
                            command.Parameters.AddWithValue("@email", email.Text);
                            command.Parameters.AddWithValue("@passe", passe.Text);
                            command.ExecuteNonQuery();
                            MessageBox.Show("Votre compte a été ajouté avec succès.");
                            Form3 form =new Form3();
                            form.Show();
                            this.Hide();

                        }else if (count != 0)
                        {
                            MessageBox.Show("Il y'a un compte déja avec c'ette nom d'utilisateur !!");
                        }else if (count2 != 0)
                        {
                            MessageBox.Show("Il y'a un compte déja avec c'ette adresse email !!");
                        }
                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    connection.Close();
                }
            }
        }

        private void connecter_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
