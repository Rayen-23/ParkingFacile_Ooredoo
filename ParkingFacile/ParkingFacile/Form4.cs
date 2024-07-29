using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParkingFacile
{
    public partial class Form4 : Form
    {
        private const String FilePath = "userInfo.dat";
        public Form4()
        {
            InitializeComponent();
            LoadUserInfo();
            LoadCarInfo();
            Direction();
            VerifPlaceReserver();
            VerifMonPlace();
            placeDispo();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void oui_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nom_Click(object sender, EventArgs e)
        {
            
        }
        private void LoadUserInfo()
        {
            Check check = Check.Load(FilePath);
            nom.Text = check.Username;
        }
        private void LoadCarInfo()
        {
            using (MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd="))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM place WHERE NomClient = @NomClient";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    Check check = Check.Load(FilePath);
                    command.Parameters.AddWithValue("@NomClient", check.Username.ToUpper());
                    using (MySqlDataReader mdr = command.ExecuteReader())
                    {
                        if(mdr.Read())
                        {
                            marque.Text = mdr.GetString("MarqueClient");
                            place.Text = mdr.GetString("PlaceClient");
                            paiement.Text = mdr.GetString("PaiementClient");
                            supprimer.Visible = true;
                            if (mdr.GetString("PaiementClient") == "non")
                            {
                                paiement.Text = "NON !!";
                                paiement.ForeColor = Color.Red;
                                payement.Visible = true;
                            }
                            else
                            {
                                paiement.Text = "OUI !!";
                                paiement.ForeColor = Color.Green;
                            }
                        }
                        else
                        {
                            marque.Text = "****";
                            place.Text = "****";
                            paiement.Text = "****";
                            supprimer.Visible = false;
                        }
                    }
                }
            }
        }

        private void enregistrer_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(comboBoxMarque.Text) || String.IsNullOrEmpty(comboBoxPlace.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !!");
            }
            else
            {
                string connectionString = "database=parking_facile; server=localhost; user id=root; pwd=";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string checkQuery = "SELECT COUNT(*) FROM place WHERE NomClient = @nom";
                        MySqlCommand checkCommand = new MySqlCommand(checkQuery, connection);
                        Check check = Check.Load(FilePath);
                        checkCommand.Parameters.AddWithValue("@nom", check.Username.ToUpper());
                        int count = Convert.ToInt32(checkCommand.ExecuteScalar());
                        if(count == 0)
                        {
                            string insertQuery = "INSERT INTO place (NomClient, MarqueClient, PlaceClient, paiementClient) VALUES (@nom, @marque, @place, @paiement)";
                            MySqlCommand command = new MySqlCommand(insertQuery, connection);
                            command.Parameters.AddWithValue("@nom", check.Username.ToUpper());
                            command.Parameters.AddWithValue("@marque", comboBoxMarque.Text);
                            command.Parameters.AddWithValue("@place", comboBoxPlace.Text);
                            command.Parameters.AddWithValue("@paiement", "non");
                            command.ExecuteNonQuery();
                            MessageBox.Show("Votre place est ajouté avec succès.");
                            non.Checked = true;
                            LoadCarInfo();
                            Direction();
                            VerifMonPlace();
                        }
                        else
                        {
                            MessageBox.Show("c'ette utilisateur a une place, Il faut de supprimer ton ancien place tout d'abord !!");
                            non.Checked = true;
                        }
                    }catch (Exception ex)
                    {
                        MessageBox.Show("Erreur : " + ex.Message);
                    }
                }
            }
        }

        private void non_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }
        private void Direction()
        {
            using (MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd="))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM place WHERE NomClient = @NomClient";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    Check check = Check.Load(FilePath);
                    command.Parameters.AddWithValue("@NomClient", check.Username.ToUpper());
                    using (MySqlDataReader mdr = command.ExecuteReader())
                    {
                        if (mdr.Read())
                        {
                            switch (mdr.GetString("PlaceClient"))
                            {
                                case "A1":
                                    dir1.Visible = true;
                                    dir2.Visible = true;
                                    dir5.Visible = true;
                                    break;
                                case "A2":
                                    dir1.Visible = true;
                                    dir2.Visible = true;
                                    dir3.Visible = true;
                                    dir6.Visible = true;
                                    break;
                                case "A3":
                                    dir1.Visible = true;
                                    dir2.Visible = true;
                                    dir3.Visible = true;
                                    dir4.Visible = true;
                                    dir7.Visible = true;
                                    break;
                                case "B1":
                                    dir1.Visible = true;
                                    dir2.Visible = true;
                                    dir3.Visible = true;
                                    dir4.Visible = true;
                                    dir8.Visible = true;
                                    break;
                                case "B2":
                                    dir1.Visible = true;
                                    dir2.Visible = true;
                                    dir3.Visible = true;
                                    dir4.Visible = true;
                                    dir9.Visible = true;
                                    break;
                                case "B3":
                                    dir1.Visible = true;
                                    dir2.Visible = true;
                                    dir3.Visible = true;
                                    dir4.Visible = true;
                                    dir10.Visible = true;
                                    break;
                                case "C1":
                                    dir1.Visible = true;
                                    dir2.Visible = true;
                                    dir3.Visible = true;
                                    dir4.Visible = true;
                                    dir11.Visible = true;
                                    break;
                                case "C2":
                                    dir1.Visible = true;
                                    dir2.Visible = true;
                                    dir3.Visible = true;
                                    dir12.Visible = true;
                                    break;
                                case "C3":
                                    dir1.Visible = true;
                                    dir2.Visible = true;
                                    dir13.Visible = true;
                                    break;
                                default:break;
                            }
                        }
                    }
                }
            }
        }
        private void VerifMonPlace ()
        {
            using (MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd="))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM place WHERE NomClient = @NomClient";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    Check check = Check.Load(FilePath);
                    command.Parameters.AddWithValue("@NomClient", check.Username.ToUpper());
                    using (MySqlDataReader mdr = command.ExecuteReader())
                    {
                        if (mdr.Read())
                        {
                            switch (mdr.GetString("PlaceClient"))
                            {
                                case "A1":
                                    A1.ForeColor = Color.Green;
                                    break;
                                case "A2":
                                    A2.ForeColor = Color.Green;
                                    break;
                                case "A3":
                                    A3.ForeColor = Color.Green;
                                    break;
                                case "B1":
                                    B1.ForeColor = Color.Green;
                                    break;
                                case "B2":
                                    B2.ForeColor = Color.Green;
                                    break;
                                case "B3":
                                    B3.ForeColor = Color.Green;
                                    break;
                                case "C1":
                                    C1.ForeColor = Color.Green;
                                    break;
                                case "C2":
                                    C2.ForeColor = Color.Green;
                                    break;
                                case "C3":
                                    C3.ForeColor = Color.Green;
                                    break;
                                default:break;
                            }
                        }
                    }
                }
            }
        }
        public void VerifPlaceReserver()
        {
            using (MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd="))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM place WHERE NomClient != @NomClient";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    Check check = Check.Load(FilePath);
                    command.Parameters.AddWithValue("@NomClient", check.Username.ToUpper());
                    using (MySqlDataReader mdr = command.ExecuteReader())
                    {
                        while(mdr.Read())
                        {
                            switch (mdr.GetString("PlaceClient"))
                            {
                                case "A1":
                                    A1.ForeColor = Color.Red;
                                    break;
                                case "A2":
                                    A2.ForeColor = Color.Red;
                                    break;
                                case "A3":
                                    A3.ForeColor = Color.Red;
                                    break;
                                case "B1":
                                    B1.ForeColor = Color.Red;
                                    break;
                                case "B2":
                                    B2.ForeColor = Color.Red;
                                    break;
                                case "B3":
                                    B3.ForeColor = Color.Red;
                                    break;
                                case "C1":
                                    C1.ForeColor = Color.Red;
                                    break;
                                case "C2":
                                    C2.ForeColor = Color.Red;
                                    break;
                                case "C3":
                                    C3.ForeColor = Color.Red;
                                    break;
                                default: break;
                            }
                        }
                    }
                }
            }
        }

        private void deconnecter_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
            this.Hide();
        }

        private void payement_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.Show();
            this.Hide();
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd="))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM place WHERE NomClient=@nom";
                using (MySqlCommand command = new MySqlCommand(deleteQuery, connection))
                {
                    Check check = Check.Load(FilePath);
                    command.Parameters.AddWithValue("@nom", check.Username.ToUpper());
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Votre place a été supprimé avec succés.");
                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Il y'a un probleme, fait c'ette action plus tard!!");
                        Form4 form4 = new Form4();
                        form4.Show();
                        this.Hide();
                    }
                }

            }
        }
        public void placeDispo()
        {
            using (MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd="))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM place";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader mdr = command.ExecuteReader())
                    {
                        while (mdr.Read())
                        {
                            for(int i = 0;i<comboBoxPlace.Items.Count;i++)
                            {
                                if (comboBoxPlace.Items[i].ToString() == mdr.GetString("PlaceClient"))
                                {
                                    comboBoxPlace.Items.RemoveAt(i);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (paiement.Text=="NON !!")
            {
                label_payement.Visible = !label_payement.Visible;
            }else if (paiement.Text=="OUI !!" || paiement.Text == "****")
            {
                label_payement.Visible = false;
            }
        }
    }
}
