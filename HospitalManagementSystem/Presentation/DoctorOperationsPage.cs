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
    public partial class DoctorOperationsPage : Form
    {
        private readonly IDoctorService _doctorService;
        private readonly IUserService _userService;
        public DoctorOperationsPage()
        {
            InitializeComponent();
            _doctorService = InstanceFactory.GetInstance<IDoctorService>();
            _userService = InstanceFactory.GetInstance<IUserService>();

            txtPhone.MaxLength = 11;
        }

        //doktor bilgileri güncelleme işlemi yapar
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "" && txtAdress.Text != "" && txtPhone.Text != "" && cmbBoxSpeciality.Text != "")
            {
                Doctor doctor1 = _doctorService.GetById(Convert.ToInt32(txtId.Text)).Data;
                var user = new User
                {
                    Id = doctor1.UserId,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Status = "Doktor",
                    PasswordHash = _userService.GetPassHashById(doctor1.UserId),
                    PasswordSalt = _userService.GetPassSaltById(doctor1.UserId)
                };

                var doctor = new Doctor
                {
                    Id = Convert.ToInt32(txtId.Text),
                    UserId = user.Id,
                    Address = txtAdress.Text,
                    Phone = txtPhone.Text,
                    Gender = radioButtonWoman.Checked == true ? 'K' : 'E',
                    Speciality = cmbBoxSpeciality.Text
                };
                if (_userService.Update(user).Success && _doctorService.Update(doctor).Success)
                {
                    MessageBox.Show("Güncelleme işlemi başarılı");
                }
                else
                {
                    MessageBox.Show("Güncelleme işlemi gerçekleştirilemedi");
                }
                load();
                clear();
            }
            else
            {
                MessageBox.Show("Alanlar boş geçilemez! \n Güncellenecek doktor seçtiğinize emin olun.");
            }
        }

        //yeni doktor ekleme işlemi yapar
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "" && txtLastName.Text != "" && txtAdress.Text != "" && txtPhone.Text != "" && cmbBoxSpeciality.Text != "")
            {
                var doctorForRegisterDto = new DoctorForRegisterDto
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Email = txtEmail.Text,
                    Status = "Doktor",
                    Address = txtAdress.Text,
                    Phone = txtPhone.Text,
                    Gender = radioButtonWoman.Checked == true ? 'K' : 'E',
                    Speciality = cmbBoxSpeciality.Text
                };
                if (_doctorService.Register(doctorForRegisterDto, "123456").Success)
                {
                    MessageBox.Show("Kayıt işlemi başarılı \n"
                                        + "Güvenlik için şifrenizi hesabınıza giriş yaptığınızda değiştirin"
                                        + "Şifreniz:123456 \n");
                }
                else
                {
                    MessageBox.Show("Kayıt işlemi gerçekleştirilemedi");
                }
                load();
                clear();
            }
            else
            {
                MessageBox.Show("Alanlar boş geçilemez!");
            }
        }

        //doktor silme işlemi yapar
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtFirstName.Text != "" && txtLastName.Text != "" && txtAdress.Text != "" && txtPhone.Text != "" && cmbBoxSpeciality.Text != "")
            {
                Doctor doctor = _doctorService.GetById(Convert.ToInt32(txtId.Text)).Data;
                if (_userService.Delete(doctor.UserId).Success && _doctorService.Delete(Convert.ToInt32(txtId.Text)).Success)
                {
                    MessageBox.Show("Seçilen doktor silindi");
                    load();
                    clear();
                }
                else
                {
                    MessageBox.Show("Silme işlemi başarısız!");
                }
            }
            else
            {
                MessageBox.Show("Silinecek doktor seçtiğinize emin olun!");
            }
        }

        //yeni doktor işlemlerindeki alanların temizlenmesi için
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        //sayfa yüklendiği anda var olan doktorların listelenmesi işlemi gerçekleşir
        private void DoctorOperationsPage_Load(object sender, EventArgs e)
        {
            load();
        }

        //listelenen doktorlardan herhangi bir doktor seçildiğinde yeni doktor işlemlerindeki ilgili alanlara yerleşmesi sağlanır
        private void listViewDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDoctor.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewDoctor.SelectedItems[0];
                txtId.Text = item.SubItems[0].Text;
                txtFirstName.Text = item.SubItems[1].Text;
                txtLastName.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
                txtPhone.Text = item.SubItems[4].Text;
                txtAdress.Text = item.SubItems[5].Text;
                radioButtonWoman.Checked = item.SubItems[6].Text == "K" ? true : false;
                radioButtonMan.Checked = item.SubItems[6].Text == "E" ? true : false;
                cmbBoxSpeciality.Text = item.SubItems[7].Text;
            }
        }

        //doktor ismine göre doktorların listelenmesi sağlanır
        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            loadByName(txtName.Text);
        }

        //doktor cinsiyetine göre doktorların listelenmesi sağlanır
        private void btnGenderSearch_Click(object sender, EventArgs e)
        {
            loadByGender(comboBoxGender.Text);
        }

        //doktorun uzmanlık alanına göre doktorların listelenmesi sağlanır
        private void btnSpecialitySearch_Click(object sender, EventArgs e)
        {
            loadBySpeciality(comboBoxSpeciality.Text);
        }

        //filtreleme işlemlerinin gerçekleştiği alanların silinip tüm var olan doktorların listelenmesi sağlanır
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            clearFilter();
            load();
        }

        //yeni doktor işlemlerindeki alanların silinmesi için oluşturulan fonksiyon
        private void clear()
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtEmail.Clear();
            txtAdress.Clear();
            txtPhone.Clear();
            cmbBoxSpeciality.Text = "";
        }

        //doktor listeleme için filtre alanlarının silinmesi için fonksiyon
        private void clearFilter()
        {
            txtName.Clear();
            comboBoxGender.Text = "";
            comboBoxSpeciality.Text = "";
        }

        //tüm doktorların listview'da listelenmesi için oluşturulan fonksiyon
        private void load()
        {
            var doctorDetails = _doctorService.GetAllDetails().Data;
            listViewDoctor.Items.Clear();
            foreach (var doctor in doctorDetails)
            {
                ListViewItem item = new ListViewItem(doctor.Id.ToString());
                item.SubItems.Add(doctor.FirstName);
                item.SubItems.Add(doctor.LastName);
                item.SubItems.Add(doctor.Email);
                item.SubItems.Add(doctor.Phone);
                item.SubItems.Add(doctor.Address);
                item.SubItems.Add(doctor.Gender.ToString());
                item.SubItems.Add(doctor.Speciality);
                listViewDoctor.Items.Add(item);
            }
        }

        //doktor ismine göre doktorların listelenmesi için oluşturulan fonksiyon
        private void loadByName(string name)
        {
            var doctorDetails = _doctorService.GetAllDetails().Data;
            listViewDoctor.Items.Clear();
            foreach (var doctor in doctorDetails)
            {
                if (doctor.FirstName.ToLower() == name.ToLower())
                {
                    ListViewItem item = new ListViewItem(doctor.Id.ToString());
                    item.SubItems.Add(doctor.FirstName);
                    item.SubItems.Add(doctor.LastName);
                    item.SubItems.Add(doctor.Email);
                    item.SubItems.Add(doctor.Phone);
                    item.SubItems.Add(doctor.Address);
                    item.SubItems.Add(doctor.Gender.ToString());
                    item.SubItems.Add(doctor.Speciality);
                    listViewDoctor.Items.Add(item);
                }
            }
        }

        //doktor cinsiyetine göre doktorların listelenmesi için oluşturulan fonksiyon
        private void loadByGender(string gender)
        {
            var doctorDetails = _doctorService.GetAllDetails().Data;
            listViewDoctor.Items.Clear();
            foreach (var doctor in doctorDetails)
            {
                if (doctor.Gender.ToString() == gender)
                {
                    ListViewItem item = new ListViewItem(doctor.Id.ToString());
                    item.SubItems.Add(doctor.FirstName);
                    item.SubItems.Add(doctor.LastName);
                    item.SubItems.Add(doctor.Email);
                    item.SubItems.Add(doctor.Phone);
                    item.SubItems.Add(doctor.Address);
                    item.SubItems.Add(doctor.Gender.ToString());
                    item.SubItems.Add(doctor.Speciality);
                    listViewDoctor.Items.Add(item);
                }
            }
        }

        //doktor uzmanlığına göre doktorların listelenmesi için oluşturulan fonksiyon
        private void loadBySpeciality(string speciality)
        {
            var doctorDetails = _doctorService.GetAllDetails().Data;
            listViewDoctor.Items.Clear();
            foreach (var doctor in doctorDetails)
            {
                if (doctor.Speciality == speciality)
                {
                    ListViewItem item = new ListViewItem(doctor.Id.ToString());
                    item.SubItems.Add(doctor.FirstName);
                    item.SubItems.Add(doctor.LastName);
                    item.SubItems.Add(doctor.Email);
                    item.SubItems.Add(doctor.Phone);
                    item.SubItems.Add(doctor.Address);
                    item.SubItems.Add(doctor.Gender.ToString());
                    item.SubItems.Add(doctor.Speciality);
                    listViewDoctor.Items.Add(item);
                }
            }
        }


        //Yalnıca harf girişi yapılması için
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        //Yalnıca harf girişi yapılması için
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        //Yalnıca sayı girişi yapılması için
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //Yalnıca harf girişi yapılması için
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
