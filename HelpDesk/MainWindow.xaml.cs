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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Пользователь user;

        public MainWindow(Пользователь user)
        {
            InitializeComponent();
            this.user = user;
        }

        private void Yslyga_Click(object sender, MouseButtonEventArgs e)
        {
            Yslygi yslygi = new Yslygi();
            yslygi.Show();
        }

        private void Close_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Cabinet_Click(object sender, MouseButtonEventArgs e)
        {
            Cabinet cabinet = new Cabinet(user);
            cabinet.Show();
        }
<<<<<<< HEAD

        private void CreateObr_Click(object sender, MouseButtonEventArgs e)
        {
            CreateRequests createRequests = new CreateRequests(user);
            createRequests.Show();
        }
=======
>>>>>>> 29a32eda876879c287a4a4cc66c7db697a210e58
    }
}
