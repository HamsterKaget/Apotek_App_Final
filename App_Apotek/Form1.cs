namespace App_Apotek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HidePanel();
            Login login = new Login(this);
            showForm(login);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void HidePanel()
        {
            panelLogut.Visible = false;
            panelMenu.Visible = false;
        }

        public void ShowPanel(string panel)
        {
            if (panel == "all")
            {
                panelLogut.Visible = true;
                panelMenu.Visible =true;
            } else if ( panel == "logout")
            {
                panelLogut.Visible = true;
            }
        }

        private Form activeForm = null;

        public void showForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            HidePanel();
            Login login = new Login(this);
            showForm(login);

        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            ManageUser manageUser = new ManageUser();
            showForm(manageUser);
        }

        private void buttonDrug_Click(object sender, EventArgs e)
        {
            ManageDrug manageDrug = new ManageDrug();
            showForm(manageDrug);
        }

        private void buttonReport_Click(object sender, EventArgs e)
        {
            ManageReport manageReport = new ManageReport();
            showForm(manageReport);
        }
    }
}