
namespace HospitalManagementSystem.Presentation
{
    partial class DoctorOperationsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorOperationsPage));
            this.listViewDoctor = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderGender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderSpeciality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxSpeciality = new System.Windows.Forms.ComboBox();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.radioButtonWoman = new System.Windows.Forms.RadioButton();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.btnGenderSearch = new System.Windows.Forms.Button();
            this.btnSpecialitySearch = new System.Windows.Forms.Button();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.comboBoxSpeciality = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnNameSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewDoctor
            // 
            this.listViewDoctor.BackColor = System.Drawing.Color.White;
            this.listViewDoctor.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeaderEmail,
            this.columnHeaderPhone,
            this.columnHeaderAdress,
            this.columnHeaderGender,
            this.columnHeaderSpeciality});
            this.listViewDoctor.FullRowSelect = true;
            this.listViewDoctor.GridLines = true;
            this.listViewDoctor.HideSelection = false;
            this.listViewDoctor.Location = new System.Drawing.Point(7, 108);
            this.listViewDoctor.Name = "listViewDoctor";
            this.listViewDoctor.Size = new System.Drawing.Size(1046, 458);
            this.listViewDoctor.TabIndex = 0;
            this.listViewDoctor.UseCompatibleStateImageBehavior = false;
            this.listViewDoctor.View = System.Windows.Forms.View.Details;
            this.listViewDoctor.SelectedIndexChanged += new System.EventHandler(this.listViewDoctor_SelectedIndexChanged);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 30;
            // 
            // columnHeaderFirstName
            // 
            this.columnHeaderFirstName.Text = "İsim";
            this.columnHeaderFirstName.Width = 100;
            // 
            // columnHeaderLastName
            // 
            this.columnHeaderLastName.Text = "Soyisim";
            this.columnHeaderLastName.Width = 100;
            // 
            // columnHeaderEmail
            // 
            this.columnHeaderEmail.Text = "Email";
            this.columnHeaderEmail.Width = 150;
            // 
            // columnHeaderPhone
            // 
            this.columnHeaderPhone.Text = "Telefon Numarası";
            this.columnHeaderPhone.Width = 100;
            // 
            // columnHeaderAdress
            // 
            this.columnHeaderAdress.Text = "Adres";
            this.columnHeaderAdress.Width = 180;
            // 
            // columnHeaderGender
            // 
            this.columnHeaderGender.Text = "Cinsiyet";
            this.columnHeaderGender.Width = 50;
            // 
            // columnHeaderSpeciality
            // 
            this.columnHeaderSpeciality.Text = "Uzmanlık";
            this.columnHeaderSpeciality.Width = 200;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAdress);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBoxSpeciality);
            this.groupBox1.Controls.Add(this.radioButtonMan);
            this.groupBox1.Controls.Add(this.radioButtonWoman);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 575);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Doktor İşlemleri";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(166, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 22);
            this.txtEmail.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Email";
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(166, 235);
            this.txtAdress.Multiline = true;
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(217, 156);
            this.txtAdress.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(166, 192);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(217, 22);
            this.txtPhone.TabIndex = 17;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(166, 119);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(217, 22);
            this.txtLastName.TabIndex = 16;
            this.txtLastName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastName_KeyPress);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(166, 38);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(217, 20);
            this.txtId.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Location = new System.Drawing.Point(6, 486);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 83);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İşlemler";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.CadetBlue;
            this.btnClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClear.BackgroundImage")));
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.Transparent;
            this.btnClear.Location = new System.Drawing.Point(7, 31);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(93, 40);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Temizle";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.BackgroundImage")));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(108, 31);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 40);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CadetBlue;
            this.btnAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdd.BackgroundImage")));
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnAdd.Location = new System.Drawing.Point(206, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(93, 40);
            this.btnAdd.TabIndex = 22;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.CadetBlue;
            this.btnUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpdate.BackgroundImage")));
            this.btnUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnUpdate.Location = new System.Drawing.Point(307, 31);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 40);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Uzmanlık";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Telefon Numarası";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(30, 119);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 17);
            this.label.TabIndex = 8;
            this.label.Text = "Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "İsim";
            // 
            // cmbBoxSpeciality
            // 
            this.cmbBoxSpeciality.FormattingEnabled = true;
            this.cmbBoxSpeciality.Items.AddRange(new object[] {
            "Algoloji",
            "Beyin ve Sinir Cerrahisi",
            "Çocuk Cerrahisi",
            "Çocuk Diş Hekimliği",
            "Çocuk Endokrinolojisi",
            "Çocuk Enfeksiyon Hastalıkları",
            "Çocuk Gastroenterolojisi",
            "Çocuk Genetik Hastalıkları",
            "Çocuk Göğüs Hastalıkları",
            "Çocuk Hematolojisi ve Onkolojisi",
            "Çocuk İmmünolojisi ve Alerji Hastalıkları",
            "Çocuk Kardiyolojisi",
            "Çocuk Metabolizma Hastalıkları",
            "Çocuk Nörolojisi",
            "Çocuk Romatolojisi",
            "Çocuk Sağlığı ve Hastalıkları",
            "Çocuk Ürolojisi",
            "Çocuk ve Ergen Ruh Sağlığı ve Hastalıkları",
            "Deri ve Zührevi Hastalıkları (Cildiye)",
            "Diş Hekimliği (Genel Diş)",
            "El Cerrahisi",
            "Endodonti",
            "Endokrinoloji ve Metabolizma Hastalıkları",
            "Enfeksiyon Hastalıkları ve Klinik Mikrobiyoloji",
            "Fiziksel Tıp ve Rehabilitasyon",
            "Gastroenteroloji",
            "Gelişimsel Pediatri",
            "Genel Cerrahi",
            "Göğüs Cerrahisi",
            "Göğüs Hastalıkları",
            "Göz Hastalıkları",
            "Hematoloji",
            "İç Hastalıkları (Dahiliye)",
            "İmmünoloji ve Alerji Hastalıkları",
            "Jinekolojik Onkoloji Cerrahisi",
            "Kadın Hastalıkları ve Doğum",
            "Kalp ve Damar Cerrahisi",
            "Kardiyoloji",
            "Kulak Burun Boğaz Hastalıkları",
            "Nefroloji",
            "Nöroloji",
            "Ortodonti",
            "Ortopedi ve Travmatoloji",
            "Perinatoloji",
            "Periodontoloji",
            "Plastik, Rekonstrüktif ve Estetik Cerrahi",
            "Romatoloji",
            "Ruh Sağlığı ve Hastalıkları (Psikiyatri)",
            "Sağlık Kurulu Erişkin",
            "Tıbbi Onkoloji",
            "Üroloji",
            "Ağız, Diş ve Çene Cerrahisi",
            "Ağız, Diş ve Çene Radyolojisi"});
            this.cmbBoxSpeciality.Location = new System.Drawing.Point(166, 449);
            this.cmbBoxSpeciality.Name = "cmbBoxSpeciality";
            this.cmbBoxSpeciality.Size = new System.Drawing.Size(217, 24);
            this.cmbBoxSpeciality.TabIndex = 6;
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(251, 406);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(65, 21);
            this.radioButtonMan.TabIndex = 5;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Erkek";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            // 
            // radioButtonWoman
            // 
            this.radioButtonWoman.AutoSize = true;
            this.radioButtonWoman.Checked = true;
            this.radioButtonWoman.Location = new System.Drawing.Point(166, 406);
            this.radioButtonWoman.Name = "radioButtonWoman";
            this.radioButtonWoman.Size = new System.Drawing.Size(65, 21);
            this.radioButtonWoman.TabIndex = 4;
            this.radioButtonWoman.TabStop = true;
            this.radioButtonWoman.Text = "Kadın";
            this.radioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(166, 80);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(217, 22);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.listViewDoctor);
            this.groupBox3.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox3.Location = new System.Drawing.Point(448, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1059, 575);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mevcut Doktor Listesi";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearFilter);
            this.groupBox4.Controls.Add(this.btnGenderSearch);
            this.groupBox4.Controls.Add(this.btnSpecialitySearch);
            this.groupBox4.Controls.Add(this.comboBoxGender);
            this.groupBox4.Controls.Add(this.comboBoxSpeciality);
            this.groupBox4.Controls.Add(this.txtName);
            this.groupBox4.Controls.Add(this.btnNameSearch);
            this.groupBox4.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox4.Location = new System.Drawing.Point(7, 22);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1046, 80);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Doktor Arama İşlemleri";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.Silver;
            this.btnClearFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.BackgroundImage")));
            this.btnClearFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.ForeColor = System.Drawing.Color.Transparent;
            this.btnClearFilter.Location = new System.Drawing.Point(7, 24);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(42, 49);
            this.btnClearFilter.TabIndex = 21;
            this.btnClearFilter.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnClearFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // btnGenderSearch
            // 
            this.btnGenderSearch.BackColor = System.Drawing.Color.Silver;
            this.btnGenderSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenderSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnGenderSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnGenderSearch.Image")));
            this.btnGenderSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenderSearch.Location = new System.Drawing.Point(382, 33);
            this.btnGenderSearch.Name = "btnGenderSearch";
            this.btnGenderSearch.Size = new System.Drawing.Size(156, 30);
            this.btnGenderSearch.TabIndex = 8;
            this.btnGenderSearch.Text = "Cinsiyete Göre Ara";
            this.btnGenderSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenderSearch.UseVisualStyleBackColor = false;
            this.btnGenderSearch.Click += new System.EventHandler(this.btnGenderSearch_Click);
            // 
            // btnSpecialitySearch
            // 
            this.btnSpecialitySearch.BackColor = System.Drawing.Color.Silver;
            this.btnSpecialitySearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSpecialitySearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnSpecialitySearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSpecialitySearch.Image")));
            this.btnSpecialitySearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSpecialitySearch.Location = new System.Drawing.Point(640, 33);
            this.btnSpecialitySearch.Name = "btnSpecialitySearch";
            this.btnSpecialitySearch.Size = new System.Drawing.Size(162, 30);
            this.btnSpecialitySearch.TabIndex = 7;
            this.btnSpecialitySearch.Text = "Uzmanlığa Göre Ara";
            this.btnSpecialitySearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSpecialitySearch.UseVisualStyleBackColor = false;
            this.btnSpecialitySearch.Click += new System.EventHandler(this.btnSpecialitySearch_Click);
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.IntegralHeight = false;
            this.comboBoxGender.Items.AddRange(new object[] {
            "K",
            "E"});
            this.comboBoxGender.Location = new System.Drawing.Point(544, 37);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(69, 24);
            this.comboBoxGender.TabIndex = 6;
            // 
            // comboBoxSpeciality
            // 
            this.comboBoxSpeciality.FormattingEnabled = true;
            this.comboBoxSpeciality.Items.AddRange(new object[] {
            "Algoloji",
            "Beyin ve Sinir Cerrahisi",
            "Çocuk Cerrahisi",
            "Çocuk Diş Hekimliği",
            "Çocuk Endokrinolojisi",
            "Çocuk Enfeksiyon Hastalıkları",
            "Çocuk Gastroenterolojisi",
            "Çocuk Genetik Hastalıkları",
            "Çocuk Göğüs Hastalıkları",
            "Çocuk Hematolojisi ve Onkolojisi",
            "Çocuk İmmünolojisi ve Alerji Hastalıkları",
            "Çocuk Kardiyolojisi",
            "Çocuk Metabolizma Hastalıkları",
            "Çocuk Nörolojisi",
            "Çocuk Romatolojisi",
            "Çocuk Sağlığı ve Hastalıkları",
            "Çocuk Ürolojisi",
            "Çocuk ve Ergen Ruh Sağlığı ve Hastalıkları",
            "Deri ve Zührevi Hastalıkları (Cildiye)",
            "Diş Hekimliği (Genel Diş)",
            "El Cerrahisi",
            "Endodonti",
            "Endokrinoloji ve Metabolizma Hastalıkları",
            "Enfeksiyon Hastalıkları ve Klinik Mikrobiyoloji",
            "Fiziksel Tıp ve Rehabilitasyon",
            "Gastroenteroloji",
            "Gelişimsel Pediatri",
            "Genel Cerrahi",
            "Göğüs Cerrahisi",
            "Göğüs Hastalıkları",
            "Göz Hastalıkları",
            "Hematoloji",
            "İç Hastalıkları (Dahiliye)",
            "İmmünoloji ve Alerji Hastalıkları",
            "Jinekolojik Onkoloji Cerrahisi",
            "Kadın Hastalıkları ve Doğum",
            "Kalp ve Damar Cerrahisi",
            "Kardiyoloji",
            "Kulak Burun Boğaz Hastalıkları",
            "Nefroloji",
            "Nöroloji",
            "Ortodonti",
            "Ortopedi ve Travmatoloji",
            "Perinatoloji",
            "Periodontoloji",
            "Plastik, Rekonstrüktif ve Estetik Cerrahi",
            "Romatoloji",
            "Ruh Sağlığı ve Hastalıkları (Psikiyatri)",
            "Sağlık Kurulu Erişkin",
            "Tıbbi Onkoloji",
            "Üroloji",
            "Ağız, Diş ve Çene Cerrahisi",
            "Ağız, Diş ve Çene Radyolojisi"});
            this.comboBoxSpeciality.Location = new System.Drawing.Point(808, 37);
            this.comboBoxSpeciality.Name = "comboBoxSpeciality";
            this.comboBoxSpeciality.Size = new System.Drawing.Size(188, 24);
            this.comboBoxSpeciality.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(192, 33);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(156, 30);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // btnNameSearch
            // 
            this.btnNameSearch.BackColor = System.Drawing.Color.Silver;
            this.btnNameSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNameSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnNameSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnNameSearch.Image")));
            this.btnNameSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNameSearch.Location = new System.Drawing.Point(56, 33);
            this.btnNameSearch.Name = "btnNameSearch";
            this.btnNameSearch.Size = new System.Drawing.Size(130, 30);
            this.btnNameSearch.TabIndex = 0;
            this.btnNameSearch.Text = "İsme Göre Ara";
            this.btnNameSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNameSearch.UseVisualStyleBackColor = false;
            this.btnNameSearch.Click += new System.EventHandler(this.btnNameSearch_Click);
            // 
            // DoctorOperationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1518, 601);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DoctorOperationsPage";
            this.Text = "Doktor İşlemleri";
            this.Load += new System.EventHandler(this.DoctorOperationsPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewDoctor;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ColumnHeader columnHeaderPhone;
        private System.Windows.Forms.ColumnHeader columnHeaderAdress;
        private System.Windows.Forms.ColumnHeader columnHeaderGender;
        private System.Windows.Forms.ColumnHeader columnHeaderSpeciality;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxSpeciality;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.RadioButton radioButtonWoman;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.ComboBox comboBoxSpeciality;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnNameSearch;
        private System.Windows.Forms.Button btnGenderSearch;
        private System.Windows.Forms.Button btnSpecialitySearch;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClearFilter;
    }
}