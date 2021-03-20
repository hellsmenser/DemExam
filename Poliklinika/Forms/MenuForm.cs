using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poliklinika.Forms
{
    public partial class MenuForm : Form
    {
        DialogResult result;
        public MenuForm()
        {
            InitializeComponent();
        }

        //кнопка выхода
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //кнопка нового пациента
        private void NewPacient_Click(object sender, EventArgs e)
        {
            PacientForm pacientForm = new PacientForm();
            result = pacientForm.ShowDialog(this);
            if(result == DialogResult.Cancel)
                return;
        }
        //кнопка записи на прием
        private void NewAppointment_Click(object sender, EventArgs e)
        {
            AppointmentFormSpecialist newAppointment = new AppointmentFormSpecialist();
            newAppointment.Show();
            this.Visible = false;            
        }
        //кнопка просмотра записей
        private void ViewAppointment_Click(object sender, EventArgs e)
        {
            AppointmentForm appointments = new AppointmentForm();
            appointments.Show();
            this.Visible = false;
        }
    }
}
