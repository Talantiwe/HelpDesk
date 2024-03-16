using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HelpDesk
{
    /// <summary>
    /// Логика взаимодействия для Аuthentication.xaml
    /// </summary>
    public partial class Autification : Window
    {
        private readonly Пользователь user;
        public Autification()
        {
            //InitializeComponent();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {

            Registration.Visibility = Visibility.Visible;



            Sign_In.Visibility = Visibility.Hidden;
            Sign_Up.Visibility = Visibility.Hidden;
        }

        private void Back_SignIn_Click(object sender, RoutedEventArgs e)
        {
            Registration.Visibility = Visibility.Hidden;
            Sign_In.Visibility = Visibility.Visible;
            Sign_Up.Visibility = Visibility.Visible;
        }

        private void Input_Click(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (Password.Password == "")
            {
                MessageBox.Show("Введиете пароль");
                return;
            }

            using (var context = new HelpDeskEntities())
            {
                var user = context.Пользователь.FirstOrDefault(u => u.Логин == Login.Text && u.Пароль == Password.Password);

                if (user != null)
                {
                    if (user.Тип_пользователя.Наименование == "Администратор")
                    {
                        MessageBox.Show("Вы вошли как администратор");
                    }
                    else if (user.Тип_пользователя.Наименование == "Клиент")
                    {
                        MessageBox.Show("Вы вошли как Клиент");
                        MainWindow mainWindow = new MainWindow(user);
                        mainWindow.Show();
                        this.Close();
                    }
                    else if (user.Тип_пользователя.Наименование == "Консультант")
                    {
                        MessageBox.Show("Вы вошли как Консультант");
                    }
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
            


        }

        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            if (RegLogin.Text == "")
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (RegEmail.Text == "")
            {
                MessageBox.Show("Введиете Email");
                return;
            }
            if (RegPassword.Password == "")
            {
                MessageBox.Show("Введиете пароль");
                return;
            }

            using (var context = HelpDeskEntities.GetContext())
            {
                var regUser = context.Пользователь.FirstOrDefault(u => u.Логин == RegLogin.Text);
                if (regUser != null)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                // Создаем нового пользователя
                var newUser = new Пользователь
                {
                    Логин = RegLogin.Text,
                    Email = RegEmail.Text,
                    Пароль = RegPassword.Password,
                    Тип = 1,
                    // Добавьте остальные поля пользователя, если необходимо
                };

                // Добавляем пользователя в базу данных
                context.Пользователь.Add(newUser);
                context.SaveChanges();
            }


            MessageBox.Show("Good Luck Reg");
            Registration.Visibility = Visibility.Hidden;
            Sign_In.Visibility = Visibility.Visible;
            Sign_Up.Visibility = Visibility.Visible;
        }
    }
}
