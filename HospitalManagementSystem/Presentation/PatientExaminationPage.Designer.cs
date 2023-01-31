
namespace HospitalManagementSystem.Presentation
{
    partial class PatientExaminationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientExaminationPage));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPatientMail = new System.Windows.Forms.TextBox();
            this.btnGmail = new System.Windows.Forms.Button();
            this.btnPDF = new System.Windows.Forms.Button();
            this.btnExamination = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtBirthday = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtIdentityNo = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listViewAppointment = new System.Windows.Forms.ListView();
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientTC = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDoctorFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDoctorLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDoctorSpeciality = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAppointmentDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAppointmentTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chPatientDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.btnPDF);
            this.groupBox1.Controls.Add(this.btnExamination);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtGender);
            this.groupBox1.Controls.Add(this.txtBirthday);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtIdentityNo);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1242, 274);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Muayene Sonuç";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPatientMail);
            this.groupBox3.Controls.Add(this.btnGmail);
            this.groupBox3.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox3.Location = new System.Drawing.Point(441, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(386, 67);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hastaya Mail Yolla";
            // 
            // txtPatientMail
            // 
            this.txtPatientMail.Location = new System.Drawing.Point(23, 31);
            this.txtPatientMail.Name = "txtPatientMail";
            this.txtPatientMail.Size = new System.Drawing.Size(301, 22);
            this.txtPatientMail.TabIndex = 39;
            // 
            // btnGmail
            // 
            this.btnGmail.BackColor = System.Drawing.Color.White;
            this.btnGmail.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGmail.BackgroundImage")));
            this.btnGmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGmail.ForeColor = System.Drawing.Color.White;
            this.btnGmail.Location = new System.Drawing.Point(330, 14);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(50, 42);
            this.btnGmail.TabIndex = 38;
            this.btnGmail.UseVisualStyleBackColor = false;
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.BackColor = System.Drawing.Color.White;
            this.btnPDF.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPDF.BackgroundImage")));
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPDF.ForeColor = System.Drawing.Color.White;
            this.btnPDF.Location = new System.Drawing.Point(922, 211);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(56, 51);
            this.btnPDF.TabIndex = 38;
            this.btnPDF.UseVisualStyleBackColor = false;
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // btnExamination
            // 
            this.btnExamination.BackColor = System.Drawing.Color.Teal;
            this.btnExamination.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExamination.ForeColor = System.Drawing.Color.White;
            this.btnExamination.Location = new System.Drawing.Point(1070, 217);
            this.btnExamination.Name = "btnExamination";
            this.btnExamination.Size = new System.Drawing.Size(156, 47);
            this.btnExamination.TabIndex = 38;
            this.btnExamination.Text = "Muayene Sonucunu Güncelle";
            this.btnExamination.UseVisualStyleBackColor = false;
            this.btnExamination.Click += new System.EventHandler(this.btnExamination_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(441, 43);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(795, 152);
            this.txtDescription.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "TC no";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(152, 237);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(217, 20);
            this.txtAddress.TabIndex = 32;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Enabled = false;
            this.txtPhone.Location = new System.Drawing.Point(152, 207);
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(217, 20);
            this.txtPhone.TabIndex = 32;
            // 
            // txtGender
            // 
            this.txtGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGender.Enabled = false;
            this.txtGender.Location = new System.Drawing.Point(152, 114);
            this.txtGender.Multiline = true;
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(217, 20);
            this.txtGender.TabIndex = 32;
            // 
            // txtBirthday
            // 
            this.txtBirthday.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtBirthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBirthday.Enabled = false;
            this.txtBirthday.Location = new System.Drawing.Point(152, 177);
            this.txtBirthday.Multiline = true;
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(217, 20);
            this.txtBirthday.TabIndex = 32;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Enabled = false;
            this.txtLastName.Location = new System.Drawing.Point(152, 84);
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(217, 20);
            this.txtLastName.TabIndex = 32;
            // 
            // txtIdentityNo
            // 
            this.txtIdentityNo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdentityNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentityNo.Enabled = false;
            this.txtIdentityNo.Location = new System.Drawing.Point(152, 147);
            this.txtIdentityNo.Multiline = true;
            this.txtIdentityNo.Name = "txtIdentityNo";
            this.txtIdentityNo.Size = new System.Drawing.Size(217, 20);
            this.txtIdentityNo.TabIndex = 32;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Enabled = false;
            this.txtFirstName.Location = new System.Drawing.Point(152, 54);
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(217, 20);
            this.txtFirstName.TabIndex = 32;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(152, 24);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(217, 20);
            this.txtId.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Cinsiyet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(438, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(219, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Muayene Sonuç Açıklaması:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Adres";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 17);
            this.label8.TabIndex = 28;
            this.label8.Text = "Telefon Numarası";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Doğum Tarihi";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(16, 82);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 17);
            this.label.TabIndex = 26;
            this.label.Text = "Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "İsim";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listViewAppointment);
            this.groupBox2.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1242, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randevu Listesi";
            // 
            // listViewAppointment
            // 
            this.listViewAppointment.BackColor = System.Drawing.Color.White;
            this.listViewAppointment.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chId,
            this.chPatientFirstName,
            this.chPatientLastName,
            this.chPatientTC,
            this.chDoctorFirstName,
            this.chDoctorLastName,
            this.chDoctorSpeciality,
            this.chAppointmentDate,
            this.chAppointmentTime,
            this.chPatientDescription});
            this.listViewAppointment.FullRowSelect = true;
            this.listViewAppointment.GridLines = true;
            this.listViewAppointment.HideSelection = false;
            this.listViewAppointment.Location = new System.Drawing.Point(6, 21);
            this.listViewAppointment.Name = "listViewAppointment";
            this.listViewAppointment.Size = new System.Drawing.Size(1230, 206);
            this.listViewAppointment.TabIndex = 3;
            this.listViewAppointment.UseCompatibleStateImageBehavior = false;
            this.listViewAppointment.View = System.Windows.Forms.View.Details;
            this.listViewAppointment.SelectedIndexChanged += new System.EventHandler(this.listViewAppointment_SelectedIndexChanged);
            // 
            // chId
            // 
            this.chId.Text = "Id";
            this.chId.Width = 30;
            // 
            // chPatientFirstName
            // 
            this.chPatientFirstName.Text = "Hasta İsim";
            this.chPatientFirstName.Width = 100;
            // 
            // chPatientLastName
            // 
            this.chPatientLastName.Text = "Hasta Soyisimi";
            this.chPatientLastName.Width = 105;
            // 
            // chPatientTC
            // 
            this.chPatientTC.Text = "TC No";
            this.chPatientTC.Width = 100;
            // 
            // chDoctorFirstName
            // 
            this.chDoctorFirstName.Text = "Doktor İsmi";
            this.chDoctorFirstName.Width = 100;
            // 
            // chDoctorLastName
            // 
            this.chDoctorLastName.Text = "Doktor Soyismi";
            this.chDoctorLastName.Width = 110;
            // 
            // chDoctorSpeciality
            // 
            this.chDoctorSpeciality.Text = "Doktor Uzmanlık";
            this.chDoctorSpeciality.Width = 120;
            // 
            // chAppointmentDate
            // 
            this.chAppointmentDate.Text = "Randevu Tarih";
            this.chAppointmentDate.Width = 70;
            // 
            // chAppointmentTime
            // 
            this.chAppointmentTime.Text = "Randevu Saat";
            this.chAppointmentTime.Width = 50;
            // 
            // chPatientDescription
            // 
            this.chPatientDescription.Text = "Muayene Açıklaması";
            this.chPatientDescription.Width = 150;
            // 
            // PatientExaminationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1260, 535);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PatientExaminationPage";
            this.Text = "Hasta Muayenesi";
            this.Load += new System.EventHandler(this.PatientExaminationPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtBirthday;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtIdentityNo;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGmail;
        private System.Windows.Forms.Button btnPDF;
        private System.Windows.Forms.Button btnExamination;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView listViewAppointment;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chPatientFirstName;
        private System.Windows.Forms.ColumnHeader chPatientLastName;
        private System.Windows.Forms.ColumnHeader chPatientTC;
        private System.Windows.Forms.ColumnHeader chDoctorFirstName;
        private System.Windows.Forms.ColumnHeader chDoctorLastName;
        private System.Windows.Forms.ColumnHeader chDoctorSpeciality;
        private System.Windows.Forms.ColumnHeader chAppointmentDate;
        private System.Windows.Forms.ColumnHeader chAppointmentTime;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPatientMail;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ColumnHeader chPatientDescription;
    }
}