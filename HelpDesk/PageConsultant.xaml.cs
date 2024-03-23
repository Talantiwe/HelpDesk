using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для PageConsultant.xaml
    /// </summary>
    public partial class PageConsultant : Window
    {
        private ObservableCollection<Обращение> ObrasheieItems = new ObservableCollection<Обращение>();

        public PageConsultant()
        {
            InitializeComponent();
            dataGrid.ItemsSource = ObrasheieItems;
            UpdateDataGrid();
        }

        public void UpdateDataGrid()
        {
            try
            {
                var context = HelpDeskEntities.GetContext();
                {
                    var basketItemsData = from item in context.Обращение
                                          select item;

                    ObrasheieItems.Clear();
                    foreach (var item in basketItemsData)
                    {
                        ObrasheieItems.Add(item);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при обновлении DataGrid: {ex.Message}");
            }
        }

    }
}
