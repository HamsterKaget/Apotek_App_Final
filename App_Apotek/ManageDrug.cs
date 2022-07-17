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
    public partial class ManageDrug : Form
    {
        SqlConnection db = new SqlConnection(Login.conn);
        int id;
        public ManageDrug()
        {
            InitializeComponent();
            load("Select * FROM Tbl_Obat");
        }

        private void clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
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
            load("Select * from Tbl_Obat");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                try
                {
                    id = Int32.Parse(row.Cells[0].Value.ToString());
                }
                catch (Exception ex)
                {

                }

                textBox1.Text = row.Cells[1].Value.ToString();
                textBox2.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Value =  Convert.ToDateTime(row.Cells[3].Value.ToString());
                textBox3.Text = row.Cells[4].Value.ToString();
                textBox4.Text = row.Cells[5].Value.ToString();

            }
        }

        private void cari_TextChanged(object sender, EventArgs e)
        {
            load("Select * from Tbl_Obat Where Nama_Obat='" + cari.Text + "' OR Kode_Obat='" + cari.Text + "'");
            clear();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            try
            {   
                string KodeObat = textBox1.Text;
                string NamaObat = textBox2.Text;
                string Expired = dateTimePicker1.Value.ToString();
                string Total = textBox3.Text;
                string Price = textBox4.Text;



                if (string.IsNullOrEmpty(KodeObat) || string.IsNullOrEmpty(NamaObat) || string.IsNullOrEmpty(Expired) || string.IsNullOrEmpty(Total) || string.IsNullOrEmpty(Price))
                {
                    MessageBox.Show("Semua field harus diisi !");

                }
                else
                {
                    string query = "INSERT into Tbl_Obat(Kode_Obat, Nama_Obat, Expired_Date, Jumlah, Harga) Values ('" + KodeObat + "' , '" + NamaObat + "' , '" + Convert.ToDateTime(Expired) + "'  , '" + Convert.ToInt64(Total) + "'  , '" + Convert.ToInt64(Price) + "' )";
                    crud(query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            clear();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            try
            {
                string KodeObat = textBox1.Text;
                string NamaObat = textBox2.Text;
                string Expired = dateTimePicker1.Value.ToString();
                string Total = textBox3.Text;
                string Price = textBox4.Text;



                if (string.IsNullOrEmpty(KodeObat) || string.IsNullOrEmpty(NamaObat) || string.IsNullOrEmpty(Expired) || string.IsNullOrEmpty(Total) || string.IsNullOrEmpty(Price))
                {
                    MessageBox.Show("Semua field harus diisi !");

                }
                else
                {
                    string query = "Update Tbl_Obat Set Kode_Obat='" + KodeObat + "' , Nama_Obat='" + NamaObat + "' , Expired_Date='" + Convert.ToDateTime(Expired) + "' , Jumlah='" + Convert.ToInt64(Total) + "' , Harga='" + Convert.ToInt64(Price) + "' WHERE Id_Obat='" + id + "'";
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
                string KodeObat = textBox1.Text;
                string NamaObat = textBox2.Text;
                string Expired = dateTimePicker1.Value.ToString();
                string Total = textBox3.Text;
                string Price = textBox4.Text;



                if (string.IsNullOrEmpty(KodeObat) || string.IsNullOrEmpty(NamaObat) || string.IsNullOrEmpty(Expired) || string.IsNullOrEmpty(Total) || string.IsNullOrEmpty(Price))
                {
                    MessageBox.Show("Silahkan pilih data dari table yang ingin dihapus !");

                }
                else
                {
                    string query = "delete from Tbl_Obat where id='" + id + "'";
                    crud(query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            clear();
        }
    }
}
