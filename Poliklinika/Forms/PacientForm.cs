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
    public partial class PacientForm : Form
    {
        PoliklinikaContext db;
        public PacientForm()
        {
            InitializeComponent();
            db = new PoliklinikaContext();
            //загружаем бд в форму и редактируем заголовки
            var dataslice = (from p in db.Pacients
                             select p).ToList();
            dataGridView1.DataSource = dataslice;

            //переименование колонок
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Фамилия";
            dataGridView1.Columns[2].HeaderText = "Имя";
            dataGridView1.Columns[3].HeaderText = "Отчество";
            dataGridView1.Columns[4].HeaderText = "Дата рождения";
            dataGridView1.Columns[5].HeaderText = "Серия паспорта";
            dataGridView1.Columns[6].HeaderText = "Номер паспорта";
            dataGridView1.Columns[7].HeaderText = "Пол";
            dataGridView1.Columns[8].HeaderText = "Адрес";
        }

        private void Pacient_Load(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //кнопка поиска
            //получаем ФИО из поля ввода
            string[] FIO = FullName.Text.Split(new char[] { ' ' });

            //выполняем запрос поиска по ФИО

            try
            {//пытаемся выполнить запрос
                //разбиваем ФИО на переменные
                if (FIO.Length > 0)
                {
                    string FirstName = FIO[1];
                    string LastName = FIO[0];
                    string SurName = FIO[2];
                    //выполняем запрос
                    var search = (from p in db.Pacients
                                  where p.Name == FirstName &&
                                  p.LastName == LastName &&
                                  p.SurName == SurName
                                  select p).ToList();
                    //выводим найденных пользователей в таблицу
                    dataGridView1.DataSource = search;
                }
                else
                {//пустой запрос поиска, выводим полную базу

                    var dataslice = (from p in db.Pacients
                                     select p).ToList();
                    dataGridView1.DataSource = dataslice;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка поиска");
            }

        }

        private void ChoseBtn_Click(object sender, EventArgs e)
        {//выбор данных из таблицы
            //разрешаем редактировать данные и запрещаем регистрировать
            EditBtn.Enabled = true;
            RegistrationBtn.Enabled = false;
            //сохроняем строку в переменную для дальнейшей работы
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];

            //Выводим значения в поля
            LastNameBox.Text = selectedRow.Cells[1].Value.ToString();
            FirstNameBox.Text = selectedRow.Cells[2].Value.ToString();
            SurNameBox.Text = selectedRow.Cells[3].Value.ToString();
            BirthdayBox.Text = selectedRow.Cells[4].Value.ToString();
            SeriesBox.Text = selectedRow.Cells[5].Value.ToString();
            NumberBox.Text = selectedRow.Cells[6].Value.ToString();
            SexBox.Text = selectedRow.Cells[7].Value.ToString();
            AdressBox.Text = selectedRow.Cells[8].Value.ToString();
            
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {//кнопка редактирования
            //разрешаем регистрировать, запрещаем редактировать
            RegistrationBtn.Enabled = true;
            EditBtn.Enabled = false;

            int id = dataGridView1.SelectedRows[0].Index;
            Pacient editPacient = db.Pacients.Find(id+1);

            //сохранение новых значений
            editPacient.Name = FirstNameBox.Text;
            editPacient.LastName = LastNameBox.Text;
            editPacient.SurName = SurNameBox.Text;
            editPacient.Birthday = Convert.ToDateTime(BirthdayBox.Text);
            editPacient.Sex = SexBox.Text[0].ToString();
            editPacient.Series = SeriesBox.Text;
            editPacient.Number = NumberBox.Text;
            editPacient.Addres = AdressBox.Text;



            db.SaveChanges();
            dataGridView1.Refresh();
            MessageBox.Show("Изменения произведены");
        }
    }
}
