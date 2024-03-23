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
using System.Windows.Shapes;

namespace HelpDesk
{
    /// <summary>
    /// Логика взаимодействия для CreateRequests.xaml
    /// </summary>
    public partial class CreateRequests : Window
    {
        private readonly Пользователь user;
        public CreateRequests(Пользователь user)
        {
            InitializeComponent();
            NomerRandom(null, null);
            this.user = user;
        }

        private void Back_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void NomerRandom(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1000, 10000);

            Nomer.Text = randomNumber.ToString();

        }

        private void CreateObrashenie_Click(object sender, RoutedEventArgs e)
        {
            string nomerText = Nomer.Text;
            string comboBoxSelectedItem = ((ComboBoxItem)Tema.SelectedItem)?.Content?.ToString();
            string textBoxText = Message.Text;

            if (comboBoxSelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите тему.");
                return;
            }

            
            var context = HelpDeskEntities.GetContext();
            try
               {
                   
                var obrashenie = new Обращение
                 {
                      
                        Номер = nomerText,
                        Наименование = comboBoxSelectedItem,
                        Сообщение = textBoxText,
                        Статус = "Зарегестрировано"
                 };

             
                context.Обращение.Add(obrashenie);

                context.SaveChanges();

               
                MessageBox.Show("Обращение созданно и будет передано специалистам.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}");
                }
            
        }


    }
}

