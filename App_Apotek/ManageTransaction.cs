using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Apotek
{
    public partial class ManageTransaction : Form
    {
        public ManageTransaction()
        {
            InitializeComponent();
        }

        private void ManageTransaction_Load(object sender, EventArgs e)
        {
            label9.Text = Login.loginData[2];
        }


    }
}
