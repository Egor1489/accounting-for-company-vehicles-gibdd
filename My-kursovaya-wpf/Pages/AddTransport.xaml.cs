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
    /// Логика взаимодействия для AddTransport.xaml
    /// </summary>
    public partial class AddTransport : Page
    {
        public AddTransport()
        {
            InitializeComponent();
            txtSotr.SelectedValuePath = "id_sotrudnik";
            txtSotr.DisplayMemberPath = "name";
            txtSotr.ItemsSource = gibddEntities1.GetContext().sotrudniki.ToList();

            txtStatus.SelectedValuePath = "id_status";
            txtStatus.DisplayMemberPath = "status1";
            txtStatus.ItemsSource = gibddEntities1.GetContext().status.ToList();

            txtType.SelectedValuePath = "id_type";
            txtType.DisplayMemberPath = "type";
            txtType.ItemsSource = gibddEntities1.GetContext().type_of_transport.ToList();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                transport transport = new transport()
                {
                    marka = txtMarka.Text,
                    model = txtModel.Text,
                    gosNomer = txtNomer.Text,
                    id_type = (int)txtType.SelectedValue,
                    id_status = (int)txtStatus.SelectedValue,
                    id_sotrudnik = (int)txtSotr.SelectedValue,
                    rashod = Convert.ToInt32(txtRashod.Text)

                };
                gibddEntities1.GetContext().transport.Add(transport);
                gibddEntities1.GetContext().SaveChanges();
                MessageBox.Show("Данные успешно добавлены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());   
            }
               
            
        }
    }
}
