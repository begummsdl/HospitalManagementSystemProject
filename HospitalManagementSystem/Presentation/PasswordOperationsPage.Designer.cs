
namespace HospitalManagementSystem.Presentation
{
    partial class PasswordOperationsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordOperationsPage));
            this.txtOldPasswort = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtNewPasswordRepeat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlOldPass = new System.Windows.Forms.Panel();
            this.pnlNewPass = new System.Windows.Forms.Panel();
            this.pnlNewPassRepeat = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // txtOldPasswort
            // 
            this.txtOldPasswort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOldPasswort.Location = new System.Drawing.Point(139, 168);
            this.txtOldPasswort.Multiline = true;
            this.txtOldPasswort.Name = "txtOldPasswort";
            this.txtOldPasswort.Size = new System.Drawing.Size(209, 30);
            this.txtOldPasswort.TabIndex = 0;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPassword.Location = new System.Drawing.Point(139, 243);
            this.txtNewPassword.Multiline = true;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(209, 30);
            this.txtNewPassword.TabIndex = 1;
            // 
            // txtNewPasswordRepeat
            // 
            this.txtNewPasswordRepeat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNewPasswordRepeat.Location = new System.Drawing.Point(139, 285);
            this.txtNewPasswordRepeat.Multiline = true;
            this.txtNewPasswordRepeat.Name = "txtNewPasswordRepeat";
            this.txtNewPasswordRepeat.Size = new System.Drawing.Size(209, 30);
            this.txtNewPasswordRepeat.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(136, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(118, 112);
            this.panel1.TabIndex = 3;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.BackColor = System.Drawing.Color.OrangeRed;
            this.btnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangePassword.Font = new System.Drawing.Font("Sitka Heading", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnChangePassword.ForeColor = System.Drawing.Color.Moccasin;
            this.btnChangePassword.Location = new System.Drawing.Point(136, 368);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(158, 42);
            this.btnChangePassword.TabIndex = 4;
            this.btnChangePassword.Text = "Şifreyi Güncelle";
            this.btnChangePassword.UseVisualStyleBackColor = false;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(13, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eski Şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Yeni Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(12, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Yeni Şifre Tekrarı";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(139, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 2);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.Location = new System.Drawing.Point(139, 270);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(209, 2);
            this.panel3.TabIndex = 9;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkOrange;
            this.panel4.Location = new System.Drawing.Point(139, 312);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(209, 2);
            this.panel4.TabIndex = 9;
            // 
            // pnlOldPass
            // 
            this.pnlOldPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlOldPass.BackgroundImage")));
            this.pnlOldPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlOldPass.Location = new System.Drawing.Point(354, 173);
            this.pnlOldPass.Name = "pnlOldPass";
            this.pnlOldPass.Size = new System.Drawing.Size(34, 25);
            this.pnlOldPass.TabIndex = 10;
            this.pnlOldPass.MouseLeave += new System.EventHandler(this.pnlOldPass_MouseLeave);
            this.pnlOldPass.MouseHover += new System.EventHandler(this.pnlOldPass_MouseHover);
            // 
            // pnlNewPass
            // 
            this.pnlNewPass.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlNewPass.BackgroundImage")));
            this.pnlNewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlNewPass.Location = new System.Drawing.Point(354, 248);
            this.pnlNewPass.Name = "pnlNewPass";
            this.pnlNewPass.Size = new System.Drawing.Size(34, 25);
            this.pnlNewPass.TabIndex = 11;
            this.pnlNewPass.MouseLeave += new System.EventHandler(this.pnlNewPass_MouseLeave);
            this.pnlNewPass.MouseHover += new System.EventHandler(this.pnlNewPass_MouseHover);
            // 
            // pnlNewPassRepeat
            // 
            this.pnlNewPassRepeat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlNewPassRepeat.BackgroundImage")));
            this.pnlNewPassRepeat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnlNewPassRepeat.Location = new System.Drawing.Point(354, 290);
            this.pnlNewPassRepeat.Name = "pnlNewPassRepeat";
            this.pnlNewPassRepeat.Size = new System.Drawing.Size(34, 25);
            this.pnlNewPassRepeat.TabIndex = 12;
            this.pnlNewPassRepeat.MouseLeave += new System.EventHandler(this.pnlNewPassRepeat_MouseLeave);
            this.pnlNewPassRepeat.MouseHover += new System.EventHandler(this.pnlNewPassRepeat_MouseHover);
            // 
            // PasswordOperationsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 441);
            this.Controls.Add(this.pnlNewPassRepeat);
            this.Controls.Add(this.pnlNewPass);
            this.Controls.Add(this.pnlOldPass);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChangePassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtNewPasswordRepeat);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtOldPasswort);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordOperationsPage";
            this.Text = "Şifre İşlemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOldPasswort;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtNewPasswordRepeat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlOldPass;
        private System.Windows.Forms.Panel pnlNewPass;
        private System.Windows.Forms.Panel pnlNewPassRepeat;
    }
}