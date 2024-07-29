using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParkingFacile
{
    public partial class Form6 : Form
    {
        int sCode;
        public Form6()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pattern = @"^.*@(gmail|hotmail)\.com$|^.*@(gmail|hotmail)\.fr$";
            if (String.IsNullOrEmpty(email.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !!");
            }else if (Regex.IsMatch(email.Text, pattern, RegexOptions.IgnoreCase) == false)
            {
                MessageBox.Show("Verifier le format de votre adresse email !!");
            }
            else if (ChecEmail()==false)
            {
                MessageBox.Show("Il n'a pas un client avec c'ette adresse email!!");
            }
            else
            {
                EnvoierEmail();
                envoier.Visible = false;
                chec.Visible = true;
                code.Visible = true;
                label1.Visible = true;
            }
        }
        private Boolean ChecEmail()
        {
            string connectionString = "database=parking_facile; server=localhost; user id=root; pwd=";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string checkQuery = "SELECT COUNT(*) FROM client WHERE EmailClient = @email";
                    MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                    checkCommand.Parameters.AddWithValue("@email", email.Text);
                    int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                    if (count != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return false;
        }
        private void EnvoierEmail()
        {
            Random _random = new Random();
            sCode = _random.Next();
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("rtrayen4@gmail.com");
                mail.To.Add(email.Text);
                mail.Subject = "Votre code de récupération du compte Parking Facile !!";
                mail.Body = "Votre Code depuis Parking Facile App est : " + sCode;
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("rtrayen4@gmail.com", "kthmdeqnvkdeajjn");
                smtpServer.EnableSsl = true;
                smtpServer.Send(mail);
                MessageBox.Show("Votre code a été envoyé avec succès !", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chec_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(code.Text))
            {
                MessageBox.Show("Veuillez remplir le champ du code!!");
            }
            else if (sCode != Convert.ToInt32(code.Text))
            {
                MessageBox.Show("Votre code est incorte!!");
            }
            else
            {
                MessageBox.Show("Votre code est correcte, Bienvenue "+userName(email.Text));
                chec.Visible=false;
                enregistrer.Visible = true;
                passe.Visible = true;
                repasse.Visible = true;
                label2.Visible = true;
                label4.Visible = true;
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(passe.Text) || String.IsNullOrEmpty(repasse.Text))
            {
                MessageBox.Show("Ecrire votre nouveau mot de passe SVP!!");
            }
            else if (passe.Text != repasse.Text)
            {
                MessageBox.Show("Il faut que votre mot de passe soit comme votre re-mot de passe!!");
            }
            else if (checkRepass() == true)
            {
                MessageBox.Show("Cette Mot de passe est utilisé déja dans ce compte !!");
            }
            else
            {
                string connectionString = "database=parking_facile; server=localhost; user id=root; pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string updateQuery = "UPDATE client SET MotDePasseClient = @passe WHERE EmailClient = @email";
                        MySqlCommand command = new MySqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@passe", passe.Text);
                        command.Parameters.AddWithValue("@email", email.Text);
                        command.ExecuteNonQuery();
                        MessageBox.Show("Votre mot de passe a changé.");
                        Form3 form = new Form3();
                        form.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
        private Boolean checkRepass()
        {
            Boolean check=false;
            string connectionString = "database=parking_facile; server=localhost; user id=root; pwd=";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM client WHERE EmailClient = @email";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@email", email.Text);
                    using (MySqlDataReader mdr = command.ExecuteReader())
                    {
                        if (mdr.Read())
                        {
                            if (mdr.GetString("MotDePasseClient") == passe.Text)
                            {
                                return check = true;
                            }
                        }
                    }
                }
            }
            return check;
        }
        private String userName (string email)
        {
            String name="";
            string connectionString = "database=parking_facile; server=localhost; user id=root; pwd=";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM client WHERE EmailClient = @email";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@email", email);
                    using (MySqlDataReader mdr = command.ExecuteReader())
                    {
                        if (mdr.Read())
                        {
                            name = mdr.GetString("NomClient")+" .";
                        }
                    }
                }
            }
            return name;
        }
    }
}
