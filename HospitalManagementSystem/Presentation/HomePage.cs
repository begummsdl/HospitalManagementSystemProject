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
    public partial class HomePage : Form
    {
        public string status; //giriş yapan kullanıcının yetkisinin tutulacağı değişken
        public int id; //giriş yapan kullanıcının id'sinin tutulacağı değişken

        public HomePage()
        {
            InitializeComponent();
        }

        //çıkış yapıldığında giriş yapılan ekrana yönlendirir
        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Cikis;
            Cikis = MessageBox.Show("Program Kapatılacak Emin siniz?", "Kapatma Uyarısı!", MessageBoxButtons.YesNo);
            if (Cikis == DialogResult.Yes)
            {
                this.Close();
            }
            if (Cikis == DialogResult.No)
            {
                
            }
        }

        //şifre değiştirme işleminin yapıldığı  sayfaya yönlendirilir şifre değişirken güncelleme 
        //işleminde id gerekli olduğundan sayfadaki id değerine giriş yapan kişinin id değerini yollarız
        private void changePasswordOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PasswordOperationsPage page = new PasswordOperationsPage();
            page.id = id;
            page.Show();
        }

        //doktor ekleme, silme, güncelleme işleminin yapıldığı sayfaya yönlendirme işlemi 
        private void doctorOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoctorOperationsPage page = new DoctorOperationsPage();
            page.Show();
        }

        //sekreter ekleme, silme, güncelleme işleminin yapıldığı sayfaya yönlendirme işlemi 
        private void secretaryOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SecretaryOperationsPage page = new SecretaryOperationsPage();
            page.Show();
        }

        //randevu ekleme, silme, güncelleme işleminin yapıldığı sayfaya yönlendirme işlemi 
        private void appointmentOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AppointmentOperationsPage page = new AppointmentOperationsPage();
            page.Show();
        }

        //hasta ekleme, silme, güncelleme işleminin yapıldığı sayfaya yönlendirme işlemi 
        private void patientAddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientOperationsPage page = new PatientOperationsPage();
            page.Show();
        }

        //Sayfa kapatıldığında giriş yapma sayfası açılır
        private void HomePage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Login page = new Login();
            page.Show();
        }

        //hasta muayene işlemlerinin gerçekleştiği sayfa doktor idsine göre randevuların 
        //listelenebilmesi için giriş yapan doktor id si yollanır o sayfaya
        private void patientExaminationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PatientExaminationPage page = new PatientExaminationPage();
            page.id = id;
            page.Show();
        }

        //sayfa yüklendiği anda yetkiye göre anasayfa görünümü oluşur
        private void HomePage_Load(object sender, EventArgs e)
        {
            if (status == "Doktor")
            {
                patientAddToolStripMenuItem.Visible = false;
                appointmentOperationsToolStripMenuItem.Visible = false;
                userOperationsToolStripMenuItem.Visible = false;
            }
            if (status == "Sekreter")
            {
                patientExaminationToolStripMenuItem.Visible = false;
            }
        }

        //doktorların randevu istatistiklerinin göründüğü sayfadır tıklandığında o sayfa açılır
        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatisticsPage page = new StatisticsPage();
            page.Show();
        }
    }
}
