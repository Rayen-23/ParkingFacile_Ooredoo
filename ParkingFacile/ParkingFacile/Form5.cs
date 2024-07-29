using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace ParkingFacile
{
    public partial class Form5 : Form
    {
        private const String FilePath = "userInfo.dat";
        public Form5()
        {
            InitializeComponent();
        }

        private void payement_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(numero.Text) || String.IsNullOrEmpty(cvv.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !!");
            }else if (date.Value == DateTime.Now)
            {
                MessageBox.Show("Changer le date d'expiration !!");
            }else if (numero.Text.Length < 11 || numero.Text.Length > 11)
            {
                MessageBox.Show("Le N°Carte doit contient 11 chiffre !!");
            }else if (cvv.Text.Length<3 || cvv.Text.Length>3)
            {
                MessageBox.Show("Le CVV doit contient 3 chiffre !!");
            }else if (Regex.IsMatch(numero.Text, @"^\d+$") == false)
            {
                MessageBox.Show("Verifier votre numero du carte il doit contient just avec des chiffres !!");
            }else if (Regex.IsMatch(cvv.Text, @"^\d+$") == false)
            {
                MessageBox.Show("Verifier votre CVV il doit contient just avec des chiffres !!");
            }else if (date.Value < DateTime.Now)
            {
                MessageBox.Show("Votre carte est expirer !!");
            }
            else
            {
                string connectionString = "database=parking_facile; server=localhost; user id=root; pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string updateQuery = "UPDATE place SET PaiementClient=@payer WHERE NomClient=@nom";
                        MySqlCommand command = new MySqlCommand(updateQuery, connection);
                        Check check = Check.Load(FilePath);
                        command.Parameters.AddWithValue("@nom", check.Username);
                        command.Parameters.AddWithValue("@payer","OUI");
                        command.ExecuteNonQuery();
                        MessageBox.Show("Votre paiement est effectuer avec succer !!");
                        envoiEmail(check.Username);
                        Form4 form = new Form4();
                        form.Show();
                        this.Hide();
                    }catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
        private void envoiEmail (String nom)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("rtrayen4@gmail.com");
                string connectionString = "database=parking_facile; server=localhost; user id=root; pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM client WHERE NomClient = @nom";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@nom", nom);
                        using (MySqlDataReader mdr = command.ExecuteReader())
                        {
                            if (mdr.Read())
                            {
                                mail.To.Add(mdr.GetString("EmailClient"));
                            }
                        }
                    }
                }
                mail.Subject = "Votre paiement est effectuer avec succer !!";
                mail.Body = "Vous avez payez 5 TND le "+ Convert.ToString(DateTime.Now) +" pour votre place sur notre application 'Parkinf Facile Ooredoo' .";
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("rtrayen4@gmail.com", "kthmdeqnvkdeajjn");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
