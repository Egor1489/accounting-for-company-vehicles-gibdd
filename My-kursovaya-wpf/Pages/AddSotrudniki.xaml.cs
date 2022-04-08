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
using My_kursovaya_wpf.AppDataFiles;

namespace My_kursovaya_wpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddSotrudniki.xaml
    /// </summary>
    public partial class AddSotrudniki : Page
    {
        public AddSotrudniki()
        {
            InitializeComponent();
            
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                sotrudniki sotrudniki = new sotrudniki()
                {
                    name = txtFIO.Text,
                    dolzhnost = txtDolzh.Text,
                    zvanie = txtZvanie.Text,
                    age = Convert.ToInt32(txtAge.Text),
                    adres = txtAdres.Text,
                    contact = txtContact.Text,
                    otdel = txtOtdel.Text,
                  


                };
                gibddEntities1.GetContext().sotrudniki.Add(sotrudniki);
                gibddEntities1.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно добавлены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          

        }
    }
}
