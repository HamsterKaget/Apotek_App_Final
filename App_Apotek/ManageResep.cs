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
    public partial class ManageResep : Form
    {
        SqlConnection db = new SqlConnection(Login.conn);
        int id;
        public ManageResep()
        {
            InitializeComponent();
            load("Select * From Tbl_Resep");
        }
        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            dateTimePicker1.Value = DateTime.Now;
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
            load("Select * from Tbl_Resep");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                try
                {
                    id = Int32.Parse(row.Cells[0].Value.ToString());
                    textBox1.Text = row.Cells[1].Value.ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(row.Cells[2].Value.ToString());
                    textBox2.Text = row.Cells[4].Value.ToString();
                    textBox3.Text = row.Cells[3].Value.ToString();
                    textBox4.Text = row.Cells[5].Value.ToString();
                    textBox5.Text = row.Cells[6].Value.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            load("Select * from Tbl_Resep Where Nama_Pasien='%" + textBox6.Text + "%' OR Nama_Dokter='%" + textBox6.Text + "%'");
            clear();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string NoResep = textBox1.Text;
                string NamaPasien = textBox2.Text;
                string Tanggal = dateTimePicker1.Value.ToString();
                string NamaDokter = textBox3.Text;
                string NamaObat = textBox4.Text;
                string Jumlah = textBox5.Text;




                if (string.IsNullOrEmpty(NoResep) || string.IsNullOrEmpty(NamaPasien) || string.IsNullOrEmpty(Tanggal) || string.IsNullOrEmpty(NamaDokter) || string.IsNullOrEmpty(NamaObat) || string.IsNullOrEmpty(Jumlah))
                {
                    MessageBox.Show("Semua field harus diisi !");

                }
                else
                {
                    string query = "INSERT into Tbl_Resep(No_Resep, Tgl_Resep, Nama_Dokter, Nama_Pasien, Nama_ObatDibeli, Jumlah_ObatDibeli) Values ('" + NoResep + "' , '" + Convert.ToDateTime(Tanggal) + "' , '" +  NamaDokter + "'  , '" + NamaPasien + "' , '" + NamaObat + "'  , '" + Convert.ToInt64(Jumlah) + "' )";
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
            crud("Delete from Tbl_User WHERE id_Resep='"+id+"'");
            clear();
        }
    }
}
