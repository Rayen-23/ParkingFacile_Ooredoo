using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data.MySqlClient;

namespace ParkingFacile
{
    public partial class Form3 : Form
    {
        private const string FilePath = "userInfo.dat";
        private Check check;
        public Form3()
        {
            InitializeComponent();
            check = Check.Load(FilePath);
            nom.Text = check.Username;
        }

        private void inscrire_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }

        private void connecter_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(nom.Text)||String.IsNullOrEmpty(passe.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !!");
            }
            else
            {
                using(MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd="))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM client WHERE NomClient = @NomClient";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NomClient", nom.Text.ToUpper());

                        using (MySqlDataReader mdr = command.ExecuteReader())
                        {
                            if (mdr.Read())
                            {
                                if (mdr.GetString("MotDePasseClient") != passe.Text)
                                {
                                    MessageBox.Show("Votre mot de passe est incorrecte !!");
                                }
                                else
                                {
                                    check.Username=nom.Text;
                                    check.Save(FilePath);
                                    Form4 form = new Form4();
                                    form.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Votre compte n'ai pas trouvé !!");
                            }
                        }
                    }
                }
            }
        }

        private void oublier_Click(object sender, EventArgs e)
        {
            Form6 form = new Form6();
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
