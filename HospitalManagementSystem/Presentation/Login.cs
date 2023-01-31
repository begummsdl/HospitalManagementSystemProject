using HospitalManagementSystem.Business.Abstract;
using HospitalManagementSystem.Core.DependencyResolvers.Ninject;
using HospitalManagementSystem.Entities.DTOs;
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
    public partial class Login : Form
    {
        private readonly IUserService _userService;
        public Login()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();

            
            txtPassword.PasswordChar = '*';//şifreyi görünmez yapmak için
        }

        //giriş bilgilerinin kontrolü sağlanarak giriş yapma işlemi gerçekleşir
        //giriş kısmında yetki ve giriş yapanın id si anasayfadaki değişkenlere atanır diğer sayfalarda kullanılmak üzere
        private void btnLogin_Click(object sender, EventArgs e)
        {
            UserForLoginDto userForLoginDto = new UserForLoginDto
            {
                Email = txtEmail.Text,
                Password = txtPassword.Text
            };
            if (_userService.Login(userForLoginDto).Success)
            {
                string status = _userService.GetSatustByEmail(txtEmail.Text);
                if (status.Equals("Sekreter"))
                {
                    HomePage page = new HomePage();
                    page.status = "Sekreter";
                    page.id = _userService.GetIdByEmail(txtEmail.Text);
                    page.Show();
                    this.Hide();
                }
                else if (status.Equals("Doktor") )
                {
                    HomePage page = new HomePage();
                    page.status = "Doktor";
                    page.id = _userService.GetIdByEmail(txtEmail.Text);
                    page.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Hatalı şifre veya kullanıcı adı!");
            }
        }

        //giriş ekranının bulunduğu form kapatıldığında uygulama kapanmaktadır
        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //mause ile göz ikonuna gidildiğinde şifre görününür olmaktadır
        private void pnlPassword_MouseHover(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
        }

        //mause ile göz ikonundan çıkıldığında şifre görünmez olmaktadır
        private void pnlPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Mail Adresinizi Giriniz")
            {
                txtEmail.Text = "";
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Mail Adresinizi Giriniz";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "********")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "********";
            }
        }

    }
}
