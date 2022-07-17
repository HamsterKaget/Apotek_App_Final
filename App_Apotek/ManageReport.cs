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
    public partial class ManageReport : Form
    {
        SqlConnection db = new SqlConnection(Login.conn);
        public ManageReport()
        {
            InitializeComponent();
            load("SELECT Tgl_Transaksi, Total_Bayar FROM Tbl_Transaksi ");
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

        private void button_search_Click(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = dateTimePicker2.Value;

            if(from >= to)
            {
                MessageBox.Show("Tanggal mulai harus lebih kecil dari tanggal sampai");
            } else
            {
                load("SELECT Tgl_Transaksi, Total_Bayar FROM Tbl_Transaksi WHERE Tgl_Transaksi>='" + from + "' AND Tgl_Transaksi<='" + to + "'");
            }
        }
    }
}
