using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ParkingFacile
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nom.Text) || String.IsNullOrEmpty(passe.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs !!");
            }
            else
            {
                using (MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd="))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM admin WHERE nomAdmin = @nomAdmin";
                    using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NomAdmin", nom.Text.ToUpper());
                        using (MySqlDataReader mdr = command.ExecuteReader())
                        {
                            if(mdr.Read())
                            {
                                if (mdr.GetString("motDePasseAdmin") != passe.Text)
                                {
                                    MessageBox.Show("Verifier Votre mot de Passe !!");
                                }
                                else
                                {
                                    MessageBox.Show("Bienvenue :)");
                                    par1.Visible = true;
                                    radioButton1.Visible = true;
                                    radioButton2.Visible = true;
                                    afficher.Visible = true;
                                    label2.Visible = true;
                                    supprimer.Visible=true;
                                    deconnecter.Visible = true;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Il n'a pas du compte avec c'ette nom d'utilisateur !!");
                            }
                        }
                    }

                }
            }
        }

        private void afficher_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                listView1.Visible = true;
                listView2.Visible = false;
                comptes();
            }
            else if (radioButton2.Checked == true)
            {
                listView1.Visible = false;
                listView2.Visible = true;
                places();
            }

        }
        private void comptes()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            listView1.Columns.Add("NomClient", 200);
            listView1.Columns.Add("EmailClient", 200);
            listView1.Columns.Add("MotDePasseClient", 200);
            using (MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd="))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM client";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader mdr = command.ExecuteReader())
                    {
                        listView1.Items.Clear();
                        while(mdr.Read())
                        {
                            string[] arr = new string[30];
                            arr[0] = mdr.GetString("NomClient");
                            arr[1] = mdr.GetString("EmailClient");
                            arr[2] = mdr.GetString("MotDePasseClient");
                            ListViewItem item = new ListViewItem(arr);
                            listView1.Items.Add(item);
                        }
                    }
                }
            }
        }
        private void places()
        {
            listView2.View = View.Details;
            listView2.GridLines = true;
            listView2.FullRowSelect = true;
            listView2.Columns.Add("NomClient", 100);
            listView2.Columns.Add("MarqueClient", 100);
            listView2.Columns.Add("PlaceClient", 100);
            listView2.Columns.Add("PaiementClient", 100);
            using (MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd="))
            {
                connection.Open();
                string selectQuery = "SELECT * FROM place";
                using (MySqlCommand command = new MySqlCommand(selectQuery, connection))
                {
                    using (MySqlDataReader mdr = command.ExecuteReader())
                    {
                        listView2.Items.Clear();
                        while (mdr.Read())
                        {
                            string[] arr = new string[30];
                            arr[0] = mdr.GetString("NomClient");
                            arr[1] = mdr.GetString("MarqueClient");
                            arr[2] = mdr.GetString("PlaceClient");
                            arr[3] = mdr.GetString("PaiementClient");
                            ListViewItem item = new ListViewItem(arr);
                            listView2.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                if(listView1.SelectedItems.Count > 0)
                {
                    String id = listView1.SelectedItems[0].SubItems[0].Text;
                    DeleteFormDatabaseClient(id);
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                    MessageBox.Show("Le ligne est supprimer, Merci :)");
                }
                else
                {
                    MessageBox.Show("Selectionner une ligne SVP !!");
                }
            }else if (radioButton2.Checked)
            {
                if (listView2.SelectedItems.Count > 0)
                {
                    String id = listView2.SelectedItems[0].SubItems[0].Text;
                    DeleteFormDatabasePlace(id);
                    listView2.Items.Remove(listView2.SelectedItems[0]);
                    MessageBox.Show("Le ligne est supprimer, Merci :)");
                }
                else
                {
                    MessageBox.Show("Selectionner une ligne SVP !!");
                }
            }
        }
        private void DeleteFormDatabaseClient(String id)
        {
            using (MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd="))
            {
                connection.Open();
                String query = "DELETE FROM client WHERE NomClient = @nom";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", id);
                    command.ExecuteReader();
                    DeleteFormDatabasePlace(id);
                }
            }
        }
        private void DeleteFormDatabasePlace(String id)
        {
            using (MySqlConnection connection = new MySqlConnection("database=parking_facile; server=localhost; user id=root; pwd="))
            {
                connection.Open();
                String query = "DELETE FROM place WHERE NomClient = @nom";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nom", id);
                    command.ExecuteReader();
                }
            }
        }

        private void deconnecter_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
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
