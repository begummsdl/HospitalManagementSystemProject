using HospitalManagementSystem.Business.Abstract;
using HospitalManagementSystem.Core.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagementSystem.Presentation
{
    public partial class PasswordOperationsPage : Form
    {
        private readonly IUserService _userService;
        public int id;
        public PasswordOperationsPage()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();

            txtOldPasswort.Text = "";
            txtNewPassword.Text = "";
            txtNewPasswordRepeat.Text = "";

            txtOldPasswort.PasswordChar = '*';
            txtNewPassword.PasswordChar = '*';
            txtNewPasswordRepeat.PasswordChar = '*';
        }

        //mouseHover ile şifre görünür mauseLeave ile şifre görünmez hale gelmektedir
        private void pnlOldPass_MouseHover(object sender, EventArgs e)
        {
            txtOldPasswort.PasswordChar = '\0';
        }

        private void pnlOldPass_MouseLeave(object sender, EventArgs e)
        {
            txtOldPasswort.PasswordChar = '*';
        }

        private void pnlNewPass_MouseHover(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '\0';
        }

        private void pnlNewPassRepeat_MouseHover(object sender, EventArgs e)
        {
            txtNewPasswordRepeat.PasswordChar = '\0';
        }

        private void pnlNewPass_MouseLeave(object sender, EventArgs e)
        {
            txtNewPassword.PasswordChar = '*';
        }

        private void pnlNewPassRepeat_MouseLeave(object sender, EventArgs e)
        {
            txtNewPasswordRepeat.PasswordChar = '*';
        }

        //burada kullanıcı bilgileri güncelleme işlemi ile yeni şifre güncellenmektedir
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Equals(txtNewPasswordRepeat.Text))
            {
                if (_userService.UpdatePassword(id, txtOldPasswort.Text, txtNewPassword.Text).Success)
                {
                    MessageBox.Show("Şifre Değiştirme işleminiz başarılı");
                }
                else
                {
                    MessageBox.Show("Eski şifrenizi yanlış girdiniz");
                }
            }
            else
            {
                MessageBox.Show("Şifre tekrarı girilen şifreyle aynı değil!");
            }
        }    
    }
}
