using HospitalManagementSystem.Business.Abstract;
using HospitalManagementSystem.Core.DependencyResolvers.Ninject;
using HospitalManagementSystem.Entities.Concrete;
using HospitalManagementSystem.Entities.DTOs;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace HospitalManagementSystem.Presentation
{
    public partial class PatientExaminationPage : Form
    {
        private readonly IAppointmentService _appointmentService;
        private readonly IPatientService _patientService;
        private readonly IDoctorService _doctorService;
        public int id;
        public PatientExaminationPage()
        {
            InitializeComponent();
            _appointmentService = InstanceFactory.GetInstance<IAppointmentService>();
            _patientService = InstanceFactory.GetInstance<IPatientService>();
            _doctorService = InstanceFactory.GetInstance<IDoctorService>();
        }

        //sayfa yüklendiğinde sisteme giriş yapan o doktora ait randevuların listelenmesini sağlayan fonksiyon çağrımı yapılmaktadır
        private void PatientExaminationPage_Load(object sender, EventArgs e)
        {
            loadAppointment(id);
        }

        //Randevu listesinden seçilen hastanın bilgileri ilgili alana yerleştirilmektedir
        private void listViewAppointment_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAppointment.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewAppointment.SelectedItems[0];
                string appointmentId = item.SubItems[0].Text;
                Appointment appointment = _appointmentService.GetById(Convert.ToInt32(appointmentId)).Data;
                Patient patient = _patientService.GetById(appointment.PatientId).Data;
                txtId.Text = Convert.ToString(patient.Id);
                txtFirstName.Text = patient.FirstName;
                txtLastName.Text = patient.LastName;
                txtGender.Text = Convert.ToString(patient.Gender);
                txtIdentityNo.Text = patient.IdentityNumber;
                txtBirthday.Text = Convert.ToString(patient.Birthday).Substring(0, 10);
                txtPhone.Text = patient.Phone;
                txtAddress.Text = patient.Address;
                txtDescription.Text = item.SubItems[9].Text;
            }
        }

        //hastanın muayene sonucu ilgili hastanın bilgilerine eklenmektedir yani güncelleme işlemi yapılmaktadır
        private void btnExamination_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtAddress.Text != "" && txtBirthday.Text != "" && txtDescription.Text != "" &&
                txtFirstName.Text != "" && txtGender.Text != "" && txtIdentityNo.Text != "" && txtLastName.Text != "" && txtPhone.Text != "")
            {
                Patient patient = new Patient
                {
                    Id = Convert.ToInt32(txtId.Text),
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    Birthday = Convert.ToDateTime(txtBirthday.Text).Date,
                    Gender = Convert.ToChar(txtGender.Text),
                    IdentityNumber = txtIdentityNo.Text,
                    Phone = txtPhone.Text,
                    Description = txtDescription.Text
                };
                if (_patientService.Update(patient).Success)
                {
                    MessageBox.Show("Muayene sonucu oluşturuldu");
                }
                else
                {
                    MessageBox.Show("Muayene sonucu güncelleme işlemi başarısız!");
                }
                loadAppointment(id);
            }
            else
            {
                MessageBox.Show("Lütfen randevu listesinden hasta seçtiğinize emin olun ve açıklamayı boş bırakmadığınıza emin olun!");
            }
        }

        //hastaya ait muayene sonuçları ve hasta bilgileri pdf olarak oluşturulmaktadır
        private void btnPDF_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtAddress.Text != "" && txtBirthday.Text != "" && txtDescription.Text != "" &&
                txtFirstName.Text != "" && txtGender.Text != "" && txtIdentityNo.Text != "" && txtLastName.Text != "" && txtPhone.Text != "")
            {
                if (listViewAppointment.SelectedItems.Count > 0)
                {
                    ListViewItem item = listViewAppointment.SelectedItems[0];
                    SaveFileDialog file = new SaveFileDialog();
                    file.Filter = "PDF DOSYALARI(*.pdf)|*.pdf";
                    file.Title = "Hasta Muayene Sonucu";
                    PdfPTable table = new PdfPTable(7);
                    table.SpacingBefore = 10f;
                    table.WidthPercentage = 100f;
                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        FileStream fileStream = File.Open(file.FileName, FileMode.Create);
                        Document pdf = new Document();
                        PdfWriter.GetInstance(pdf, fileStream);
                        pdf.Open();
                        
                        table.AddCell(new Phrase(listViewAppointment.Columns[1].Text));
                        table.AddCell(new Phrase(listViewAppointment.Columns[2].Text));
                        table.AddCell(new Phrase(listViewAppointment.Columns[3].Text));
                        table.AddCell(new Phrase(listViewAppointment.Columns[4].Text));
                        table.AddCell(new Phrase(listViewAppointment.Columns[5].Text));
                        table.AddCell(new Phrase(listViewAppointment.Columns[6].Text));
                        table.AddCell(new Phrase(listViewAppointment.Columns[9].Text));

                        table.AddCell(new Phrase(item.SubItems[1].Text));
                        table.AddCell(new Phrase(item.SubItems[2].Text));
                        table.AddCell(new Phrase(item.SubItems[3].Text));
                        table.AddCell(new Phrase(item.SubItems[4].Text));
                        table.AddCell(new Phrase(item.SubItems[5].Text));
                        table.AddCell(new Phrase(item.SubItems[6].Text));
                        table.AddCell(new Phrase(item.SubItems[9].Text));

                        pdf.Add(table);
                        pdf.Close();

                        MessageBox.Show("Pdf oluşturuldu");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen randevu listesinden hasta seçtiğinize emin olun ve açıklamayı boş bırakmadığınıza emin olun!");
            }
        }

        //hastanın belirttiği maile muayene sonucunun metni gönderilmektedir
        private void btnGmail_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "" && txtAddress.Text != "" && txtBirthday.Text != "" && txtDescription.Text != "" && txtPatientMail.Text != "" &&
                txtFirstName.Text != "" && txtGender.Text != "" && txtIdentityNo.Text != "" && txtLastName.Text != "" && txtPhone.Text != "")
            {
                string command = "mailto:" + txtPatientMail.Text + "?subject=Muayene Sonuç&body=" + txtDescription.Text;
                Process.Start(command);
            }
            else
            {
                MessageBox.Show("Lütfen randevu listesinden hasta seçtiğinize emin olun ve açıklamayı boş bırakmadığınıza emin olun!");
            }
        }

        //sisteme giriş yapan o doktora ait randevuların listelenmesini sağlayan fonksiyon
        private void loadAppointment(int doctorId)
        {
            Doctor doctor = _doctorService.GetByUserId(doctorId).Data;
            List<AppointmentDetailsForExaminationDto> appointmentDetails = _appointmentService.GetAppointmentDetailsByDoctorId(doctor.Id).Data;
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
                item.SubItems.Add(appointment.AppointmentDate.ToString().Substring(0, 10)); //saat:dakika:saniye kısmını almaması için
                item.SubItems.Add(appointment.AppointmentTime.ToString().Substring(0, 5)); //saniye değerini almaması için
                item.SubItems.Add(appointment.patientDescription);
                listViewAppointment.Items.Add(item);
            }
        }
    }
}
