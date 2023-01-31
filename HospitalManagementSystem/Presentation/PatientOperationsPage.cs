using HospitalManagementSystem.Business.Abstract;
using HospitalManagementSystem.Core.DependencyResolvers.Ninject;
using HospitalManagementSystem.Entities.Concrete;
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
    public partial class PatientOperationsPage : Form
    {
        private readonly IPatientService _patientService;
        public PatientOperationsPage()
        {
            InitializeComponent();
            _patientService = InstanceFactory.GetInstance<IPatientService>();

            //dtpBirthday.MaxDate = DateTime.Now.Date;
            txtIdentityNumber.MaxLength = 11;
            txtPhone.MaxLength = 11;
        }

        //Hasta listesinden seçilen hastanın yeni hasta işlemleri kısmındaki ilgili alanlara yerleşme işlemi
        private void listViewPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPatient.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewPatient.SelectedItems[0];
                txtId.Text = item.SubItems[0].Text;
                txtFirstName.Text = item.SubItems[1].Text;
                txtLastName.Text = item.SubItems[2].Text;
                radioButtonWoman.Checked = item.SubItems[3].Text == "K" ? true : false;
                radioButtonMan.Checked = item.SubItems[3].Text == "E" ? true : false;
                txtIdentityNumber.Text = item.SubItems[4].Text;
                dtpBirthday.Value = Convert.ToDateTime(item.SubItems[5].Text);
                txtPhone.Text = item.SubItems[6].Text;
                txtAdress.Text = item.SubItems[7].Text;
            }
        }

        //hasta güncelleme işlemi yapılmaktadır
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient
            {
                Id = Convert.ToInt32(txtId.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = radioButtonWoman.Checked == true ? 'K' : 'E',
                IdentityNumber = txtIdentityNumber.Text,
                Birthday = dtpBirthday.Value,
                Phone = txtPhone.Text,
                Address = txtAdress.Text,
                Description = null
            };
            if (_patientService.Update(patient).Success)
            {
                MessageBox.Show("Güncelleme işlemi başarılı.");
            }
            else
            {
                MessageBox.Show("Güncelleme işlemi başarısız!");
            }
            load();
            clear();
        }

        //hasta ekleme işlemi yapılmaktadır
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = radioButtonWoman.Checked == true ? 'K' : 'E',
                IdentityNumber = txtIdentityNumber.Text,
                Birthday = dtpBirthday.Value,
                Phone = txtPhone.Text,
                Address = txtAdress.Text,
                Description = null
            };
            if (_patientService.Add(patient).Success)
            {
                MessageBox.Show("Hasta ekleme işlemi başarılı.");
            }
            else
            {
                MessageBox.Show("Hasta ekleme işlemi başarısız!");
            }
            load();
            clear();
        }

        //hasta silme işlemi gerçekleştirilir
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient
            {
                Id = Convert.ToInt32(txtId.Text),
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Gender = radioButtonWoman.Checked == true ? 'K' : 'E',
                IdentityNumber = txtIdentityNumber.Text,
                Birthday = dtpBirthday.Value,
                Phone = txtPhone.Text,
                Address = txtAdress.Text,
                Description = null
            };
            if (_patientService.Delete(patient).Success)
            {
                MessageBox.Show("Hasta silme işlemi başarılı.");
            }
            else
            {
                MessageBox.Show("Hasta silme işlemi başarısız!");
            }
            load();
            clear();
        }

        //yeni hasta eklem kısmındaki alanların temizlenmesini sağlayan fonksiyon çağrımı yapılmaktadır
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        //Hasta cinsiyetine göre listeleme işlemi yapılır
        private void btnGenderSearch_Click(object sender, EventArgs e)
        {
            var patients = _patientService.GetAll().Data;
            listViewPatient.Items.Clear();
            foreach (var patient in patients)
            {
                if (comboBoxGender.Text == patient.Gender.ToString())
                {
                    ListViewItem item = new ListViewItem(patient.Id.ToString());
                    item.SubItems.Add(patient.FirstName);
                    item.SubItems.Add(patient.LastName);
                    item.SubItems.Add(patient.Gender.ToString());
                    item.SubItems.Add(patient.IdentityNumber);
                    item.SubItems.Add(patient.Birthday.ToString().Substring(0, 10));//saat:dakike:saniye kısmını almamak için
                    item.SubItems.Add(patient.Phone);
                    item.SubItems.Add(patient.Address);
                    listViewPatient.Items.Add(item);
                }
            }
        }

        //Hasta ismine göre listeleme işlemi yapılır
        private void btnNameSearch_Click(object sender, EventArgs e)
        {
            var patients = _patientService.GetAll().Data;
            listViewPatient.Items.Clear();
            foreach (var patient in patients)
            {
                if (txtName.Text.ToLower() == patient.FirstName.ToLower())
                {
                    ListViewItem item = new ListViewItem(patient.Id.ToString());
                    item.SubItems.Add(patient.FirstName);
                    item.SubItems.Add(patient.LastName);
                    item.SubItems.Add(patient.Gender.ToString());
                    item.SubItems.Add(patient.IdentityNumber);
                    item.SubItems.Add(patient.Birthday.ToString().Substring(0, 10));//saat:dakike:saniye kısmını almamak için
                    item.SubItems.Add(patient.Phone);
                    item.SubItems.Add(patient.Address);
                    listViewPatient.Items.Add(item);
                }
            }
        }

        //isme göre ve cinsiyete göre listeleme işlemlerini yaptırdığımız filtreleme 
        //alanlarını temizleyip tüm hastaların listelenmesini sağlar
        private void btnClearFilter_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            comboBoxGender.Text = "";
            load();
        }

        //sayfa yüklenirken mevcut hasta listesinin listelenmesini sağlayan fonksiyonun çağırımı yapılmaktadır
        private void PatientOperationsPage_Load(object sender, EventArgs e)
        {
            load();
        }

        //Mevcut hasta listesinin listelenmesini sağlayan fonksiyon
        private void load()
        {
            var patients = _patientService.GetAll().Data;
            listViewPatient.Items.Clear();
            foreach (var patient in patients)
            {
                ListViewItem item = new ListViewItem(patient.Id.ToString());
                item.SubItems.Add(patient.FirstName);
                item.SubItems.Add(patient.LastName);
                item.SubItems.Add(patient.Gender.ToString());
                item.SubItems.Add(patient.IdentityNumber);
                item.SubItems.Add(patient.Birthday.ToString().Substring(0, 10));//saat:dakike:saniye kısmını almamak için
                item.SubItems.Add(patient.Phone);
                item.SubItems.Add(patient.Address);
                listViewPatient.Items.Add(item);
            }
        }

        //yeni hasta eklem kısmındaki alanların temizlenmesini sağlayan fonksiyon
        private void clear()
        {
            txtId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtIdentityNumber.Clear();
            dtpBirthday.Value = DateTime.Now.Date;
            txtPhone.Clear();
            txtAdress.Clear();
        }


        //sadece sayı girişi
        private void txtIdentityNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //sadece sayı girişi
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //yalnızca harf girişi yapabilmesi için
        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        //yalnızca harf girişi yapabilmesi için
        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        //yalnızca harf girişi yapabilmesi için
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
