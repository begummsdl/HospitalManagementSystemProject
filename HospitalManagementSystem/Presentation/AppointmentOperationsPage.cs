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
    public partial class AppointmentOperationsPage : Form
    {
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;
        private readonly IAppointmentService _appointmentService;
        public AppointmentOperationsPage()
        {
            InitializeComponent();
            _patientService = InstanceFactory.GetInstance<IPatientService>();
            _doctorService = InstanceFactory.GetInstance<IDoctorService>();
            _appointmentService = InstanceFactory.GetInstance<IAppointmentService>();

            //dtpAppointmentDate.MinDate = DateTime.Now.Date;
            txtPatientTC.MaxLength = 11; //tc alanının max uzunluk 
        }

        //sayfa yüklendiğinde doktor, hasta ve randevu bilgilerinin listelendiği fonksiyon çağırımı yapılmaktadır
        private void AppointmentOperationsPage_Load(object sender, EventArgs e)
        {
            loadAppointment();
            loadPatient();
            loadDoctor();
        }

        //işlemlerin yapıldığı groupBox bölümündeki alanların içeriğinin temizlenmesi için çağırımı yapılan fonksiyon
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        //randevu silme işlemi gerçekleşiyor
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtDoctorId.Text != "" && txtPatientId.Text != "" && cmbAppointmentTime.Text != "")
            {
                var appointment = new Appointment
                {
                    Id = Convert.ToInt32(txtId.Text),
                    DoctorId = Convert.ToInt32(txtDoctorId.Text),
                    PatientId = Convert.ToInt32(txtPatientId.Text),
                    Date = dtpAppointmentDate.Value,
                    Time = Convert.ToDateTime(cmbAppointmentTime.Text).TimeOfDay
                };
                if (_appointmentService.Delete(appointment).Success)
                {
                    MessageBox.Show("Randevu silme işlemi başarılı");
                }
                else
                {
                    MessageBox.Show("Randevu silme işlemi başarısız");
                }
                loadAppointment();
                clear();
            }
            else
            {
                MessageBox.Show("Alanlar boş bırakılamaz gerekli alanlar için listelerden seçin işlemlerini gerçekleştiriniz!");
            }
        }

        //yeni randevu oluşturma 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtDoctorId.Text != "" && txtPatientId.Text != "" && cmbAppointmentTime.Text != "")
            {
                var appointment = new Appointment
                {
                    DoctorId = Convert.ToInt32(txtDoctorId.Text),
                    PatientId = Convert.ToInt32(txtPatientId.Text),
                    Date = dtpAppointmentDate.Value.Date,
                    Time = Convert.ToDateTime(cmbAppointmentTime.Text).TimeOfDay
                };
                if (_appointmentService.Add(appointment).Success)
                {
                    MessageBox.Show("Randevu ekleme işlemi başarılı");
                }
                else
                {
                    MessageBox.Show("Randevu ekleme işlemi başarısız");
                }
                loadAppointment();
                clear();
            }
            else
            {
                MessageBox.Show("Alanlar boş bırakılamaz gerekli alanlar için listelerden seçin işlemlerini gerçekleştiriniz!");
            }
        }

        //randevu güncelleme işlemi
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtDoctorId.Text != "" && txtPatientId.Text != "" && cmbAppointmentTime.Text != "")
            {
                var appointment = new Appointment
                {
                    Id = Convert.ToInt32(txtId.Text),
                    DoctorId = Convert.ToInt32(txtDoctorId.Text),
                    PatientId = Convert.ToInt32(txtPatientId.Text),
                    Date = dtpAppointmentDate.Value,
                    Time = Convert.ToDateTime(cmbAppointmentTime.Text).TimeOfDay
                };
                if (_appointmentService.Update(appointment).Success)
                {
                    MessageBox.Show("Randevu güncelleme işlemi başarılı");
                }
                else
                {
                    MessageBox.Show("Randevu güncelleme işlemi başarısız");
                }
                loadAppointment();
                clear();
            }
            else
            {
                MessageBox.Show("Alanlar boş bırakılamaz gerekli alanlar için listelerden seçin işlemlerini gerçekleştiriniz!");
            }
        }

        //doktor uzmanlık alanına göre doktorları listeleme
        private void btnDoctorSpecialitySearch_Click(object sender, EventArgs e)
        {
            var doctorDetails = _doctorService.GetAllDetails().Data;
            listViewDoctor.Items.Clear();
            foreach (var doctor in doctorDetails)
            {
                if (doctor.Speciality == cmbDoctorSpeciality.Text)
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

        //doktor cinsiyetine göre doktor listeleme
        private void btnDoctorGenderSearch_Click(object sender, EventArgs e)
        {
            var doctorDetails = _doctorService.GetAllDetails().Data;
            listViewDoctor.Items.Clear();
            foreach (var doctor in doctorDetails)
            {
                if (doctor.Gender.ToString() == cmbDoctorGender.Text)
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

        //doktor ismine göre doktor listeleme
        private void btnDoctorFirstNameSearch_Click(object sender, EventArgs e)
        {
            var doctorDetails = _doctorService.GetAllDetails().Data;
            listViewDoctor.Items.Clear();
            foreach (var doctor in doctorDetails)
            {
                if (doctor.FirstName.ToLower() == txtDoctorFirstName.Text.ToLower())
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

        //doktor listeleme filtrelerinin temizlenip tüm doktorların listelenme işleminin tetiklendiği buton
        private void btnClearDoctorFilter_Click(object sender, EventArgs e)
        {
            txtDoctorFirstName.Clear();
            cmbDoctorGender.Text = "";
            cmbDoctorSpeciality.Text = "";
            loadDoctor();
        }

        //hasta tc'sine göre hastanın listelendiği buton işlemleri
        private void btnPatientTcSearch_Click(object sender, EventArgs e)
        {
            var patients = _patientService.GetAll().Data;
            listViewPatient.Items.Clear();
            foreach (var patient in patients)
            {
                if (txtPatientTC.Text == patient.IdentityNumber)
                {
                    ListViewItem item = new ListViewItem(patient.Id.ToString());
                    item.SubItems.Add(patient.FirstName);
                    item.SubItems.Add(patient.LastName);
                    item.SubItems.Add(patient.Gender.ToString());
                    item.SubItems.Add(patient.IdentityNumber);
                    item.SubItems.Add(patient.Birthday.ToString().Substring(0, 10));//saat:dakika:saniye kısmını almaması için
                    item.SubItems.Add(patient.Phone);
                    item.SubItems.Add(patient.Address);
                    listViewPatient.Items.Add(item);
                }
            }
        }

        //hasta adına göre hastaların listelendiği buton kodları
        private void btnPatientFirstNameSearch_Click(object sender, EventArgs e)
        {
            var patients = _patientService.GetAll().Data;
            listViewPatient.Items.Clear();
            foreach (var patient in patients)
            {
                if (txtPatientFirstName.Text.ToLower() == patient.FirstName.ToLower())
                {
                    ListViewItem item = new ListViewItem(patient.Id.ToString());
                    item.SubItems.Add(patient.FirstName);
                    item.SubItems.Add(patient.LastName);
                    item.SubItems.Add(patient.Gender.ToString());
                    item.SubItems.Add(patient.IdentityNumber);
                    item.SubItems.Add(patient.Birthday.ToString().Substring(0, 10));//saat:dakika:saniye kısmını almaması için
                    item.SubItems.Add(patient.Phone);
                    item.SubItems.Add(patient.Address);
                    listViewPatient.Items.Add(item);
                }
            }
        }

        //hasta filtrelerinin temizlenip tüm hastaların listelendiği kısım
        private void btnClearPatientFilter_Click(object sender, EventArgs e)
        {
            txtPatientTC.Clear();
            txtPatientFirstName.Clear();
            loadPatient();
        }

        //Hasta listesinden herhangi bir hastaya tıkladığımızda randevu işlemleri bölümündeki hasta id alanına bilginin yazılması sağlanıyor
        private void listViewPatient_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPatient.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewPatient.SelectedItems[0];
                txtPatientId.Text = item.SubItems[0].Text;
            }
        }

        //doktor listesinden doktor seçildiğinde randevu işlemleri bölümündeki doktor id alanına bilginin yazılması sağlanıyor
        private void listViewDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewDoctor.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewDoctor.SelectedItems[0];
                txtDoctorId.Text = item.SubItems[0].Text;
            }
        }

        //randevu listesinden randevu seçildiğinde randevu işlemleri bölümündeki ilgili alanlara bilginin yazılması sağlanıyor
        private void listViewAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAppointment.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewAppointment.SelectedItems[0];
                txtId.Text = item.SubItems[0].Text;
                Appointment appointment = _appointmentService.GetById(Convert.ToInt32(txtId.Text)).Data;
                txtDoctorId.Text = appointment.DoctorId.ToString();
                txtPatientId.Text = appointment.PatientId.ToString();
                dtpAppointmentDate.Value = Convert.ToDateTime(appointment.Date);
                cmbAppointmentTime.Text = appointment.Time.ToString().Substring(0, 5);//saniye kısmını almaması için
            }
        }




        //doktor listesine doktorların listelenmesi sağlanıyor
        private void loadDoctor()
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

        //hasta listesine hastaların listelenmesi sağlanıyor
        private void loadPatient()
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
                item.SubItems.Add(patient.Birthday.ToString().Substring(0, 10)); //saat:dakika:saniye kısmını almaması için
                item.SubItems.Add(patient.Phone);
                item.SubItems.Add(patient.Address);
                listViewPatient.Items.Add(item);
            }
        }

        //randevu listesine randevuların listelenmesi sağlanıyor
        private void loadAppointment()
        {
            var appointmentDetails = _appointmentService.GetAllDetails().Data;
            listViewAppointment.Items.Clear();
            foreach (var appointment in appointmentDetails)
            {
                ListViewItem item = new ListViewItem(appointment.Id.ToString());
                item.SubItems.Add(appointment.PatientFirstName);
                item.SubItems.Add(appointment.PatientLastName);
                item.SubItems.Add(appointment.IdentityNumber);
                item.SubItems.Add(appointment.DoctorFirstName);
                item.SubItems.Add(appointment.DoctorLastName);
                item.SubItems.Add(appointment.DoctorSpeciality);
                item.SubItems.Add(appointment.AppointmentDate.ToString().Substring(0, 10));//saat:dakika:saniye kısmını almaması için
                item.SubItems.Add(appointment.AppointmentTime.ToString().Substring(0, 5));//saniye kısmını almaması için
                listViewAppointment.Items.Add(item);
            }
        }

        //randevu işlemlerindeki alanların temizlenmesine yarıyor
        private void clear()
        {
            txtId.Clear();
            txtDoctorId.Clear();
            txtPatientId.Clear();
            cmbAppointmentTime.Text = "";
            dtpAppointmentDate.Value = DateTime.Now.Date;
        }



        //yalnızca harf girilmesi için
        private void txtPatientFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        //yazlnızca sayı girilmesi için
        private void txtPatientTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //yalnızca harf girilmesi için
        private void txtDoctorFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
