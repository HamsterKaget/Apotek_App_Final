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
    public partial class Login : Form
    {
        public static string conn = @"Data Source=DESKTOP-8U0KF06\SQLEXPRESS;Initial Catalog=db_apotek;Integrated Security=True";
        public static string[] loginData;
        SqlConnection db = new SqlConnection(conn);
        Form1 form1;

        public Login(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Semua Field Harus Diisi");
            } else
            {
                string query = "SELECT * FROM Tbl_User WHERE Username='" + username + "' AND Password='" + password + "'";
                loginData = login(query);

                if (loginData == null)
                {
                    MessageBox.Show("Username atau Password anda salah");

                } else
                {
                    switch (loginData[1])
                    {
                        case "Admin":
                            this.Close();
                            form1.showForm(new Log());
                            form1.ShowPanel("all");
                            break;
                        case "Apoteker":
                            this.Close();
                            form1.showForm(new ManageResep());
                            form1.ShowPanel("logout");
                            break;
                        case "Kasir":
                            this.Close();
                            form1.showForm(new ManageTransaction());
                            form1.ShowPanel("logout");
                            break;
                    }
                }
            }
            
        }

        private string[] login(string query)
        {
            SqlDataAdapter sda = new SqlDataAdapter(query, db);
            DataTable dt = new DataTable();
            string[] Arr;
            db.Open();
            sda.SelectCommand.ExecuteNonQuery();
            sda.Fill(dt);
            db.Close();
         

            try
            {
                Arr = dt.Rows[0].ItemArray.Select(x => x.ToString()).ToArray();
                return Arr;
            } catch (Exception ex )
            {
                Arr = null;
                return Arr;
            }

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
