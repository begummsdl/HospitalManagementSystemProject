using HospitalManagementSystem.Business.Abstract;
using HospitalManagementSystem.Core.DependencyResolvers.Ninject;
using HospitalManagementSystem.Entities.Concrete;
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
    public partial class SecretaryOperationsPage : Form
    {
        private readonly ISecretaryServive _secretaryService;
        private readonly IUserService _userService;
        public SecretaryOperationsPage()
        {
            InitializeComponent();
            _secretaryService = InstanceFactory.GetInstance<ISecretaryServive>();
            _userService = InstanceFactory.GetInstance<IUserService>();
        }

        //sekreter bilgilerinin güncellendiği işlemler gerçekleştirilmektedir
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Secretary secretary1 = _secretaryService.GetById(Convert.ToInt32(txtId.Text)).Data;
            var user = new User
            {
                Id = _userService.GetIdByEmail(txtEmail.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Email = txtEmail.Text,
                Status = "Sekreter",
                PasswordHash = _userService.GetPassHashById(secretary1.UserId),
                PasswordSalt = _userService.GetPassSaltById(secretary1.UserId)
            };

            var secretary = new Secretary
            {
                Id = Convert.ToInt32(txtId.Text),
                UserId = user.Id
            };

            if (_userService.Update(user).Success && _secretaryService.Update(secretary).Success)
            {
                MessageBox.Show("Güncelleme işlemi başarıyla gerçekleşti");
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi başarısız");
            }

            load();
            clear();
        }

        //sekreter ekleme işlemleri gerçekleştirilmektedir
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "")
            {
                var secretaryForRegisterDto = new SecretaryForRegisterDto
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Status = "Sekreter"
                };

                if (_secretaryService.Register(secretaryForRegisterDto, "123456").Success)
                {
                    MessageBox.Show("Kayıt işlemi başarılı \n"
                    + "Güvenlik için şifrenizi hesabınıza giriş yaptığınızda değiştirin \n"
                    + "Şifreniz:123456 \n");
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi başarısız!");
                }
                load();
                clear();
            }
            else
            {
                MessageBox.Show("Alanlar boş geçilemez!");
            }
        }

        //sekreter silme işlemi gerçekleştirilmektedir
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_secretaryService.Delete(Convert.ToInt32(txtId.Text)).Success && _userService.Delete(Convert.ToInt32(_userService.GetIdByEmail(txtEmail.Text))).Success)
            {
                load();
                clear();
                MessageBox.Show("Seçilen sekreter silindi.");
            }
            else
            {
                MessageBox.Show("Silme işlemi başarısız. \n"
                    + "Silinecek sekreter seçtiğinize emin olun!");
            }
        }

        //yeni sekreter işlemlerindeki alanların temizlenmesini sağlıyor
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        //mevcut sekreter listesindeki sekreterleri isme göre listelenmesini sağlıyor
        private void btnFirstNameSearch_Click(object sender, EventArgs e)
        {
            var secretaryDetails = _secretaryService.GetAllDetails().Data;
            listViewSecretary.Items.Clear();
            foreach (var secretary in secretaryDetails)
            {
                if (secretary.FirstName.ToLower() == txtFirstNameSearch.Text.ToLower())
                {
                    ListViewItem item = new ListViewItem(secretary.Id.ToString());
                    item.SubItems.Add(secretary.FirstName);
                    item.SubItems.Add(secretary.LastName);
                    item.SubItems.Add(secretary.Email);
                    listViewSecretary.Items.Add(item);
                }
            }
        }

        //mevcut sekreter listesindeki sekreterleri soyismine göre listelenmesini sağlıyor
        private void btnLastNameSearch_Click(object sender, EventArgs e)
        {
            var secretaryDetails = _secretaryService.GetAllDetails().Data;
            listViewSecretary.Items.Clear();
            foreach (var secretary in secretaryDetails)
            {
                if (secretary.LastName.ToLower() == txtLastNameSearch.Text.ToLower())
                {
                    ListViewItem item = new ListViewItem(secretary.Id.ToString());
                    item.SubItems.Add(secretary.FirstName);
                    item.SubItems.Add(secretary.LastName);
                    item.SubItems.Add(secretary.Email);
                    listViewSecretary.Items.Add(item);
                }
            }
        }

        //mevcut sekreter listesindeki filtreleme işlemlerini temizleyip tüm sekreterlerin listelenmesini sağlıyor
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtFirstNameSearch.Clear();
            txtLastNameSearch.Clear();
            load();
        }

        //sekreter sayfası yüklendiğinde mevcut sekreterlerin listelenmesini sağlar
        private void SecretaryOperationsPage_Load(object sender, EventArgs e)
        {
            load();
        }

        //mevcut sekreterlerin listelenmesini sağlayan fonksiyon
        private void load()
        {
            var secretaryDetails = _secretaryService.GetAllDetails().Data;
            listViewSecretary.Items.Clear();
            foreach (var secretary in secretaryDetails)
            {
                ListViewItem item = new ListViewItem(secretary.Id.ToString());
                item.SubItems.Add(secretary.FirstName);
                item.SubItems.Add(secretary.LastName);
                item.SubItems.Add(secretary.Email);
                listViewSecretary.Items.Add(item);
            }
        }

        //yeni sekreter işlemlerindeki alanların temizlenmesini sağlar
        private void clear()
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
        }

        //listelenen sekreterlerden seçilen sekreterlerin ilgili alanlara yerleşmesi sağlanır
        private void listViewSecretary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewSecretary.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewSecretary.SelectedItems[0];
                txtId.Text = item.SubItems[0].Text;
                txtFirstName.Text = item.SubItems[1].Text;
                txtLastName.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
            }
        }


        //yalnızca harf girişi yapılabilmesi için
        private void txtFirstNameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtLastNameSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
