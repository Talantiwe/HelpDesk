using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для Yslygi.xaml
    /// </summary>
    public partial class Yslygi : Window
    {
        public Yslygi()
        {
            InitializeComponent();
            Vivod_Naimenovanie_yslyg(null, null);
        }

        private void Vivod_Naimenovanie_yslyg(object sender, RoutedEventArgs e)
        {
            using (HelpDeskEntities context = new HelpDeskEntities())
            {
                var услуги = context.Услуги.ToList();

                foreach (var услуга in услуги)
                {
                    Naimenovanie_yslygi.Text += $" {услуга.Наименование}{Environment.NewLine}{Environment.NewLine}";
                    Stoimost_yslygi.Text += $" {услуга.Стоимость} ₽{Environment.NewLine}{Environment.NewLine}";

                }
                var opisanie1 = from Услуги in context.Услуги
                                where Услуги.Id_Услуги == 1
                                select Услуги;

                foreach (var услуга in opisanie1)
                {
                    Opisanie1.Content += $" {услуга.Описание}";
                }
                var opisanie2 = from Услуги in context.Услуги
                                where Услуги.Id_Услуги == 2
                                select Услуги;

                foreach (var услуга in opisanie2)
                {
                    Opisanie2.Content += $" {услуга.Описание}";
                }
                var opisanie3 = from Услуги in context.Услуги
                                where Услуги.Id_Услуги == 3
                                select Услуги;

                foreach (var услуга in opisanie3)
                {
                    Opisanie3.Content += $" {услуга.Описание}";
                }
                var opisanie4 = from Услуги in context.Услуги
                                where Услуги.Id_Услуги == 4
                                select Услуги;

                foreach (var услуга in opisanie4)
                {
                    Opisanie4.Content += $" {услуга.Описание}";
                }
                var opisanie5 = from Услуги in context.Услуги
                                where Услуги.Id_Услуги == 5
                                select Услуги;

                foreach (var услуга in opisanie5)
                {
                    Opisanie5.Content += $" {услуга.Описание}";
                }
                var opisanie6 = from Услуги in context.Услуги
                                where Услуги.Id_Услуги == 6
                                select Услуги;

                foreach (var услуга in opisanie6)
                {
                    Opisanie6.Content += $" {услуга.Описание}";
                }
                var opisanie7 = from Услуги in context.Услуги
                                where Услуги.Id_Услуги == 7
                                select Услуги;

                foreach (var услуга in opisanie7)
                {
                    Opisanie7.Content += $" {услуга.Описание}";
                }
                var opisanie8 = from Услуги in context.Услуги
                                where Услуги.Id_Услуги == 8
                                select Услуги;

                foreach (var услуга in opisanie8)
                {
                    Opisanie8.Content += $" {услуга.Описание}";
                }
            }
        }

        private void Back_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }
    }
}
