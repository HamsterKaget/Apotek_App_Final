namespace App_Apotek
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelLogut = new System.Windows.Forms.Panel();
            this.buttonLogOut = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonDrug = new System.Windows.Forms.Button();
            this.buttonUser = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelChild = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelLogut.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(50)))), ((int)(((byte)(66)))));
            this.panelMain.Controls.Add(this.panelLogut);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Controls.Add(this.panelLogo);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(250, 629);
            this.panelMain.TabIndex = 0;
            // 
            // panelLogut
            // 
            this.panelLogut.Controls.Add(this.buttonLogOut);
            this.panelLogut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelLogut.Location = new System.Drawing.Point(0, 550);
            this.panelLogut.Name = "panelLogut";
            this.panelLogut.Size = new System.Drawing.Size(250, 79);
            this.panelLogut.TabIndex = 2;
            // 
            // buttonLogOut
            // 
            this.buttonLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogOut.FlatAppearance.BorderSize = 0;
            this.buttonLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(184)))), ((int)(((byte)(205)))));
            this.buttonLogOut.Location = new System.Drawing.Point(0, 29);
            this.buttonLogOut.Name = "buttonLogOut";
            this.buttonLogOut.Size = new System.Drawing.Size(250, 50);
            this.buttonLogOut.TabIndex = 3;
            this.buttonLogOut.Text = "> LogOut";
            this.buttonLogOut.UseVisualStyleBackColor = true;
            this.buttonLogOut.Click += new System.EventHandler(this.buttonLogOut_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.buttonReport);
            this.panelMenu.Controls.Add(this.buttonDrug);
            this.panelMenu.Controls.Add(this.buttonUser);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 129);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 216);
            this.panelMenu.TabIndex = 1;
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonReport.Location = new System.Drawing.Point(0, 100);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(250, 50);
            this.buttonReport.TabIndex = 2;
            this.buttonReport.Text = "Kelola Laporan";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonDrug
            // 
            this.buttonDrug.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDrug.FlatAppearance.BorderSize = 0;
            this.buttonDrug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDrug.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDrug.Location = new System.Drawing.Point(0, 50);
            this.buttonDrug.Name = "buttonDrug";
            this.buttonDrug.Size = new System.Drawing.Size(250, 50);
            this.buttonDrug.TabIndex = 1;
            this.buttonDrug.Text = "Kelola Obat";
            this.buttonDrug.UseVisualStyleBackColor = true;
            this.buttonDrug.Click += new System.EventHandler(this.buttonDrug_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonUser.FlatAppearance.BorderSize = 0;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonUser.Location = new System.Drawing.Point(0, 0);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(250, 50);
            this.buttonUser.TabIndex = 0;
            this.buttonUser.Text = "Kelola User";
            this.buttonUser.UseVisualStyleBackColor = true;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 129);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App_Apotek.Properties.Resources.download_removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(45, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(153, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelChild
            // 
            this.panelChild.AutoScroll = true;
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.panelChild.Controls.Add(this.pictureBox2);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(250, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(808, 629);
            this.panelChild.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(301, 229);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(225, 225);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1058, 629);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelMain);
            this.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.MinimumSize = new System.Drawing.Size(1080, 685);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMain.ResumeLayout(false);
            this.panelLogut.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelChild.ResumeLayout(false);
            this.panelChild.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMain;
        private Panel panelLogut;
        private Button buttonLogOut;
        private Panel panelMenu;
        private Button buttonReport;
        private Button buttonDrug;
        private Button buttonUser;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Panel panelChild;
        private PictureBox pictureBox2;
    }
}