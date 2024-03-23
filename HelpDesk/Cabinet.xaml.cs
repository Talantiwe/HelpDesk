using System;
using System.Collections.Generic;
using System.Data.Entity;
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
using System.Windows.Shapes;

namespace HelpDesk
{
    /// <summary>
    /// Логика взаимодействия для Cabinet.xaml
    /// </summary>
    public partial class Cabinet : Window
    {
        private readonly Пользователь user;
        public Cabinet(Пользователь user)
        {
            InitializeComponent();
            this.user = user;
            Login.Text = user.Логин;
            Email.Text = user.Email;
            UpdateEmail();
        }

        private void Back_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }


        private void Red_Click(object sender, MouseButtonEventArgs e)
        {
            string newEmail = Email.Text;

            // Обновляем email в базе данных
            using (var context = new HelpDeskEntities())
            {
                // Получаем пользователя из базы данных
                var user = context.Пользователь.FirstOrDefault(u => u.Логин == Login.Text);

                if (user != null)
                {
                    // Обновляем email пользователя
                    user.Email = newEmail;

                    // Сохраняем изменения в базе данных
                    context.SaveChanges();

                    // Очищаем TextBox перед установкой нового email
                    Email.Text = "";

                    // Обновляем TextBlock с новым email
                    Email.Text = newEmail;
                }
                Galka.Visibility = Visibility.Visible;
            }
        }
        private void UpdateEmail()
        {
            // Обновляем email пользователя из базы данных
            using (var context = new HelpDeskEntities())
            {
                // Получаем пользователя из базы данных
                var currentUser = context.Пользователь.FirstOrDefault(u => u.Логин == user.Логин);

                if (currentUser != null)
                {
                    // Устанавливаем новый email в TextBox
                    Email.Text = currentUser.Email;
                }
            }
        }











    }
}
