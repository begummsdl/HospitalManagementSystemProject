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
    public partial class StatisticsPage : Form
    {
        private readonly IUserService _userService;
        private readonly IDoctorService _doctorService;
        private readonly IAppointmentService _appointmentService;
        public StatisticsPage()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _doctorService = InstanceFactory.GetInstance<IDoctorService>();
            _appointmentService = InstanceFactory.GetInstance<IAppointmentService>();
        }

        private void StatisticsPage_Load(object sender, EventArgs e)
        {
            int size = _doctorService.GetAll().Data.Count; //toplam doktor sayısı
            List<Doctor> doctorsData = _doctorService.GetAll().Data; //doktor bilgileri
            string[] doctors = new string[size]; //doktor ad soyadını tutacağız
            int[] appointments = new int[size]; //doktora ait randevu sayısını tutacağız

            int j = 0;
            foreach (var doctor in doctorsData) //bu döngüde verileri tanımladığımız dizilere atama işlemini gerçekleştiriyoruz
            {
                User user = _userService.GetById(doctor.UserId).Data;
                doctors[j] = user.FirstName + " " + user.LastName;
                if (_appointmentService.GetByDoctorId(doctor.Id).Data.Count > 0)
                {
                    appointments[j] = _appointmentService.GetByDoctorId(doctor.Id).Data.Count;
                }
                else
                {
                    appointments[j] = 0;
                }
                j++;
            }

            //grafiğin içini temizliyoruz
            foreach (var series in chartDoctors.Series)
            {
                series.Points.Clear();
            }

            Random random = new Random(); //pasta grafiğindeki RGB renkleri ayarlamak için
            //bu döngüde pasta grafiğini oluşturma işlemi gerçekleşiyor
            for (int i = 0; i < size; i++)
            {
                chartDoctors.Series["DOCTORS"].Points.Add(appointments[i]);
                chartDoctors.Series["DOCTORS"].Points[i].AxisLabel = doctors[i];
                chartDoctors.Series["DOCTORS"].Points[i].Color = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
            } 
        }
    }
}
