
namespace HospitalManagementSystem.Presentation
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hesabımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.secretaryOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientOperationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientAddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.patientExaminationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AliceBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesabımToolStripMenuItem,
            this.userOperationsToolStripMenuItem,
            this.appointmentOperationsToolStripMenuItem,
            this.patientOperationsToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(869, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hesabımToolStripMenuItem
            // 
            this.hesabımToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordOperationsToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.hesabımToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hesabımToolStripMenuItem.Image")));
            this.hesabımToolStripMenuItem.Name = "hesabımToolStripMenuItem";
            this.hesabımToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.hesabımToolStripMenuItem.Text = "Hesap Bilgileri";
            // 
            // changePasswordOperationsToolStripMenuItem
            // 
            this.changePasswordOperationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordOperationsToolStripMenuItem.Image")));
            this.changePasswordOperationsToolStripMenuItem.Name = "changePasswordOperationsToolStripMenuItem";
            this.changePasswordOperationsToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.changePasswordOperationsToolStripMenuItem.Text = "Parola İşlemleri";
            this.changePasswordOperationsToolStripMenuItem.Click += new System.EventHandler(this.changePasswordOperationsToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("logOutToolStripMenuItem.Image")));
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.logOutToolStripMenuItem.Text = "Çıkış Yap";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // userOperationsToolStripMenuItem
            // 
            this.userOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doctorOperationsToolStripMenuItem,
            this.secretaryOperationsToolStripMenuItem});
            this.userOperationsToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.userOperationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userOperationsToolStripMenuItem.Image")));
            this.userOperationsToolStripMenuItem.Name = "userOperationsToolStripMenuItem";
            this.userOperationsToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.userOperationsToolStripMenuItem.Text = "Kullanıcı İşlemleri";
            // 
            // doctorOperationsToolStripMenuItem
            // 
            this.doctorOperationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doctorOperationsToolStripMenuItem.Image")));
            this.doctorOperationsToolStripMenuItem.Name = "doctorOperationsToolStripMenuItem";
            this.doctorOperationsToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.doctorOperationsToolStripMenuItem.Text = "Doktor İşlemleri";
            this.doctorOperationsToolStripMenuItem.Click += new System.EventHandler(this.doctorOperationsToolStripMenuItem_Click);
            // 
            // secretaryOperationsToolStripMenuItem
            // 
            this.secretaryOperationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("secretaryOperationsToolStripMenuItem.Image")));
            this.secretaryOperationsToolStripMenuItem.Name = "secretaryOperationsToolStripMenuItem";
            this.secretaryOperationsToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.secretaryOperationsToolStripMenuItem.Text = "Sekreter İşlemleri";
            this.secretaryOperationsToolStripMenuItem.Click += new System.EventHandler(this.secretaryOperationsToolStripMenuItem_Click);
            // 
            // appointmentOperationsToolStripMenuItem
            // 
            this.appointmentOperationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("appointmentOperationsToolStripMenuItem.Image")));
            this.appointmentOperationsToolStripMenuItem.Name = "appointmentOperationsToolStripMenuItem";
            this.appointmentOperationsToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.appointmentOperationsToolStripMenuItem.Text = "Randevu İşlemleri";
            this.appointmentOperationsToolStripMenuItem.Click += new System.EventHandler(this.appointmentOperationsToolStripMenuItem_Click);
            // 
            // patientOperationsToolStripMenuItem
            // 
            this.patientOperationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.patientAddToolStripMenuItem,
            this.patientExaminationToolStripMenuItem});
            this.patientOperationsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientOperationsToolStripMenuItem.Image")));
            this.patientOperationsToolStripMenuItem.Name = "patientOperationsToolStripMenuItem";
            this.patientOperationsToolStripMenuItem.Size = new System.Drawing.Size(141, 24);
            this.patientOperationsToolStripMenuItem.Text = "Hasta İşlemleri";
            // 
            // patientAddToolStripMenuItem
            // 
            this.patientAddToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientAddToolStripMenuItem.Image")));
            this.patientAddToolStripMenuItem.Name = "patientAddToolStripMenuItem";
            this.patientAddToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.patientAddToolStripMenuItem.Text = "Hasta Ekle";
            this.patientAddToolStripMenuItem.Click += new System.EventHandler(this.patientAddToolStripMenuItem_Click);
            // 
            // patientExaminationToolStripMenuItem
            // 
            this.patientExaminationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("patientExaminationToolStripMenuItem.Image")));
            this.patientExaminationToolStripMenuItem.Name = "patientExaminationToolStripMenuItem";
            this.patientExaminationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.patientExaminationToolStripMenuItem.Text = "Hasta Muayene";
            this.patientExaminationToolStripMenuItem.Click += new System.EventHandler(this.patientExaminationToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("statisticsToolStripMenuItem.Image")));
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.statisticsToolStripMenuItem.Text = "İstatistik";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(869, 437);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.Text = "Anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomePage_FormClosing);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hesabımToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem secretaryOperationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientAddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patientExaminationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
    }
}