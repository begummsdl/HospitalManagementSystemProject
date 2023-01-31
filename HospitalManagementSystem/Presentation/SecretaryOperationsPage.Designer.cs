
namespace HospitalManagementSystem.Presentation
{
    partial class SecretaryOperationsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecretaryOperationsPage));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listViewSecretary = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnClearFilter = new System.Windows.Forms.Button();
            this.txtLastNameSearch = new System.Windows.Forms.TextBox();
            this.txtFirstNameSearch = new System.Windows.Forms.TextBox();
            this.btnLastNameSearch = new System.Windows.Forms.Button();
            this.btnFirstNameSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listViewSecretary);
            this.groupBox3.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox3.Location = new System.Drawing.Point(448, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(664, 412);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mevcut Sekreter Listesi";
            // 
            // listViewSecretary
            // 
            this.listViewSecretary.BackColor = System.Drawing.Color.White;
            this.listViewSecretary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderFirstName,
            this.columnHeaderLastName,
            this.columnHeaderEmail});
            this.listViewSecretary.FullRowSelect = true;
            this.listViewSecretary.GridLines = true;
            this.listViewSecretary.HideSelection = false;
            this.listViewSecretary.Location = new System.Drawing.Point(6, 21);
            this.listViewSecretary.Name = "listViewSecretary";
            this.listViewSecretary.Size = new System.Drawing.Size(647, 381);
            this.listViewSecretary.TabIndex = 0;
            this.listViewSecretary.UseCompatibleStateImageBehavior = false;
            this.listViewSecretary.View = System.Windows.Forms.View.Details;
            this.listViewSecretary.SelectedIndexChanged += new System.EventHandler(this.listViewSecretary_SelectedIndexChanged);
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnClearFilter);
            this.groupBox4.Controls.Add(this.txtLastNameSearch);
            this.groupBox4.Controls.Add(this.txtFirstNameSearch);
            this.groupBox4.Controls.Add(this.btnLastNameSearch);
            this.groupBox4.Controls.Add(this.btnFirstNameSearch);
            this.groupBox4.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox4.Location = new System.Drawing.Point(12, 315);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 109);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sekreter Arama İşlemleri";
            // 
            // btnClearFilter
            // 
            this.btnClearFilter.BackColor = System.Drawing.Color.Silver;
            this.btnClearFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClearFilter.BackgroundImage")));
            this.btnClearFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnClearFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFilter.ForeColor = System.Drawing.Color.Transparent;
            this.btnClearFilter.Location = new System.Drawing.Point(7, 33);
            this.btnClearFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearFilter.Name = "btnClearFilter";
            this.btnClearFilter.Size = new System.Drawing.Size(42, 66);
            this.btnClearFilter.TabIndex = 21;
            this.btnClearFilter.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnClearFilter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClearFilter.UseVisualStyleBackColor = false;
            this.btnClearFilter.Click += new System.EventHandler(this.btnClearFilter_Click);
            // 
            // txtLastNameSearch
            // 
            this.txtLastNameSearch.Location = new System.Drawing.Point(231, 69);
            this.txtLastNameSearch.Multiline = true;
            this.txtLastNameSearch.Name = "txtLastNameSearch";
            this.txtLastNameSearch.Size = new System.Drawing.Size(183, 30);
            this.txtLastNameSearch.TabIndex = 3;
            this.txtLastNameSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastNameSearch_KeyPress);
            // 
            // txtFirstNameSearch
            // 
            this.txtFirstNameSearch.Location = new System.Drawing.Point(231, 33);
            this.txtFirstNameSearch.Multiline = true;
            this.txtFirstNameSearch.Name = "txtFirstNameSearch";
            this.txtFirstNameSearch.Size = new System.Drawing.Size(183, 30);
            this.txtFirstNameSearch.TabIndex = 3;
            this.txtFirstNameSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstNameSearch_KeyPress);
            // 
            // btnLastNameSearch
            // 
            this.btnLastNameSearch.BackColor = System.Drawing.Color.Silver;
            this.btnLastNameSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLastNameSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnLastNameSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnLastNameSearch.Image")));
            this.btnLastNameSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLastNameSearch.Location = new System.Drawing.Point(76, 69);
            this.btnLastNameSearch.Name = "btnLastNameSearch";
            this.btnLastNameSearch.Size = new System.Drawing.Size(149, 30);
            this.btnLastNameSearch.TabIndex = 0;
            this.btnLastNameSearch.Text = "Soyisme Göre Ara";
            this.btnLastNameSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLastNameSearch.UseVisualStyleBackColor = false;
            this.btnLastNameSearch.Click += new System.EventHandler(this.btnLastNameSearch_Click);
            // 
            // btnFirstNameSearch
            // 
            this.btnFirstNameSearch.BackColor = System.Drawing.Color.Silver;
            this.btnFirstNameSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFirstNameSearch.ForeColor = System.Drawing.Color.Transparent;
            this.btnFirstNameSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnFirstNameSearch.Image")));
            this.btnFirstNameSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFirstNameSearch.Location = new System.Drawing.Point(76, 33);
            this.btnFirstNameSearch.Name = "btnFirstNameSearch";
            this.btnFirstNameSearch.Size = new System.Drawing.Size(149, 30);
            this.btnFirstNameSearch.TabIndex = 0;
            this.btnFirstNameSearch.Text = "İsme Göre Ara";
            this.btnFirstNameSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFirstNameSearch.UseVisualStyleBackColor = false;
            this.btnFirstNameSearch.Click += new System.EventHandler(this.btnFirstNameSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.ForeColor = System.Drawing.Color.CadetBlue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 280);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yeni Sekreter İşlemleri";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(147, 152);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 22);
            this.txtEmail.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Email";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(147, 119);
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
            this.txtId.Location = new System.Drawing.Point(147, 38);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(217, 20);
            this.txtId.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 41);
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
            this.groupBox2.Location = new System.Drawing.Point(7, 194);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(417, 83);
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
            this.btnClear.Size = new System.Drawing.Size(95, 40);
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
            this.btnDelete.Location = new System.Drawing.Point(110, 31);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 40);
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
            this.btnAdd.Location = new System.Drawing.Point(213, 31);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 40);
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
            this.btnUpdate.Location = new System.Drawing.Point(316, 31);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 40);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(44, 119);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(56, 17);
            this.label.TabIndex = 8;
            this.label.Text = "Soyisim";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "İsim";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(147, 80);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(217, 22);
            this.txtFirstName.TabIndex = 0;
            this.txtFirstName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstName_KeyPress);
            // 
            // SecretaryOperationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1121, 439);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecretaryOperationsPage";
            this.Text = "Sekreter İşlemleri";
            this.Load += new System.EventHandler(this.SecretaryOperationsPage_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnClearFilter;
        private System.Windows.Forms.TextBox txtFirstNameSearch;
        private System.Windows.Forms.Button btnFirstNameSearch;
        private System.Windows.Forms.ListView listViewSecretary;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderFirstName;
        private System.Windows.Forms.ColumnHeader columnHeaderLastName;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastNameSearch;
        private System.Windows.Forms.Button btnLastNameSearch;
    }
}