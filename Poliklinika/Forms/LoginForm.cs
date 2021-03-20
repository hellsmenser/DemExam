using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Poliklinika.Forms;

namespace Poliklinika
{
    public partial class Login : Form
    {
        private bool myPasswordIs(TextBox passwordBox)
        { // Функция проверки корректности ввода пароля
            bool flagPassword = true; // априори считаем - пароль введен правильно
                                      // тип определит компилятор C#
            var flagNumber = new Regex(@"(?=.*[0-9])");
            var flagUpChar = new Regex(@"(?=.*[A-Z])");
            var flagLowChar = new Regex(@"(?=.*[a-z])");
            var flagSpecSymbl = new Regex(@"(?=.*[@#$&])");
            var flagIncorectChar = new Regex(@"[^0-9a-zA-Z@#$&]");
            // Обработка пароля
            if (passwordBox.Text == String.Empty)
            {
                MessageBox.Show("Заполните поле Пароль");
                return false;
            }
            else
            {
                if (passwordBox.Text.Length < 6)
                {
                    MessageBox.Show("Размер должен быть от 6 символов");
                    flagPassword = false;
                }
                if (!flagNumber.IsMatch(passwordBox.Text))
                {
                    MessageBox.Show("Нет цифр");
                    flagPassword = false;
                }
                if (!flagUpChar.IsMatch(passwordBox.Text))
                {
                    MessageBox.Show("Нет заглавных букв");
                    flagPassword = false;
                }
                if (!flagLowChar.IsMatch(passwordBox.Text))
                {
                    MessageBox.Show("Нет строчных букв");
                    flagPassword = false;
                }
                if (!flagSpecSymbl.IsMatch(passwordBox.Text))
                {
                    MessageBox.Show("Нет специальных символов");
                    flagPassword = false;
                }
                if (flagIncorectChar.IsMatch(passwordBox.Text))
                {
                    MessageBox.Show("Есть недопустимые символы");
                    flagPassword = false;
                }
                return flagPassword;
            }
        }
        PoliklinikaContext db;
        public Login()
        {
            InitializeComponent();
        }

        //кнопка выхода
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        private void EntrBtn_Click(object sender, EventArgs e)
        {
            //кнопка входа
            //ищем пользователя в базе
            var users = (from a in db.Users
                         where a.Login == LogText.Text &&
                         a.Password == PasText.Text
                         select a).ToList();
            if (users.Count == 1)
            {
                MenuForm menu = new MenuForm();
                menu.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль");
            }

        }

        //кнопка регистрации
        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            Registration regform = new Registration();
            DialogResult result = regform.ShowDialog();
            
            if(result == DialogResult.Cancel)
            {
                return;
            }
            if(result == DialogResult.OK)
            {
                User newUser = new User();
                try
                {
                    if (myPasswordIs(regform.PasswordBox))
                    {
                        newUser.Login = regform.LoginBox.Text;
                        newUser.Password = regform.PasswordBox.Text;
                        newUser.Name = regform.FIO.Text;
                    }
                    if(regform.PasswordBox.Text != regform.PasswordBox1.Text)
                    {
                        MessageBox.Show("Пароли не совпадают!");
                    }
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    MessageBox.Show("Пользователь зарегистрирован");
                }
                catch
                {
                    MessageBox.Show("Ошибка ввода данных");
                }
            }
        }

        //загрузка формы
        private void Login_Load(object sender, EventArgs e)
        {
            db = new PoliklinikaContext(); //подключение к бд
                
        }
    }
}
