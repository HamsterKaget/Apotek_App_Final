using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace App_Apotek
{
    public partial class ManageUser : Form
    {
        SqlConnection db = new SqlConnection(Login.conn);
        int id;

        public ManageUser()
        {
            InitializeComponent();
            load("Select * from Tbl_User");
        }

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Items.Clear();
            cari.Text = "";
        }

        private void load(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, db);
            DataTable dt = new DataTable();

            db.Open();
            sda.SelectCommand.ExecuteNonQuery();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            db.Close();
            
        }

        private void crud(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, db);
            db.Open();
            sda.SelectCommand.ExecuteNonQuery();
            db.Close();
            load("Select * from Tbl_User");
        }


        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string tipeUser = comboBox1.SelectedItem.ToString();
                string Nama = textBox1.Text;
                string Telepon = textBox2.Text;
                string Alamat = textBox3.Text;
                string Username = textBox4.Text;
                string Password = textBox5.Text;
                

                if (string.IsNullOrEmpty(tipeUser) || string.IsNullOrEmpty(Nama) || string.IsNullOrEmpty(Telepon) || string.IsNullOrEmpty(Alamat) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Semua field harus diisi !");
                    
                }
                else
                {
                    string query = "INSERT into Tbl_User(Tipe_User, Nama_User, Telpon, Alamat, Username, Password) Values ('" + tipeUser + "' , '" + Nama + "' , '" + Telepon + "'  , '" + Alamat + "'  , '" + Username + "'  , '" + Password + "'  )";
                    crud(query);
                }

            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

            clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                try
                {
                    id = Int32.Parse(row.Cells[0].Value.ToString());
                } catch (Exception ex)
                {
                    
                }

                comboBox1.SelectedItem = row.Cells[1].Value.ToString();
                textBox1.Text = row.Cells[2].Value.ToString();
                textBox2.Text = row.Cells[4].Value.ToString();
                textBox3.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[5].Value.ToString();
                textBox5.Text = row.Cells[6].Value.ToString();

            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string tipeUser = comboBox1.SelectedItem.ToString();
                string Nama = textBox1.Text;
                string Telepon = textBox2.Text;
                string Alamat = textBox3.Text;
                string Username = textBox4.Text;
                string Password = textBox5.Text;


                if (string.IsNullOrEmpty(tipeUser) || string.IsNullOrEmpty(Nama) || string.IsNullOrEmpty(Telepon) || string.IsNullOrEmpty(Alamat) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Semua field harus diisi !");

                }
                else
                {
                    string query = "Update Tbl_User Set Tipe_User='" + tipeUser + "' , Nama_User='"+Nama+ "' , Alamat='"+Alamat+ "' , Telpon='"+Telepon+ "' , Username='"+Username+ "' , Password='"+Password+ "' WHERE Id_User='"+ id +"'";
                    crud(query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            clear();
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string tipeUser = comboBox1.SelectedItem.ToString();
                string Nama = textBox1.Text;
                string Telepon = textBox2.Text;
                string Alamat = textBox3.Text;
                string Username = textBox4.Text;
                string Password = textBox5.Text;


                if (string.IsNullOrEmpty(tipeUser) || string.IsNullOrEmpty(Nama) || string.IsNullOrEmpty(Telepon) || string.IsNullOrEmpty(Alamat) || string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
                {
                    MessageBox.Show("Silahkan pilih data dari gridview untuk dihapus");
                }
                else
                {
                    string query = "DELETE FROM Tbl_User WHERE Id_User='" + id + "'";
                    crud(query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            clear();
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            load("Select * From Tbl_User WHERE Nama_User Like '%"+cari.Text+"%' OR Username Like '%"+ cari.Text + "%'");
        }
    }
}
