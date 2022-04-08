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
    /// Логика взаимодействия для PageEditTransport.xaml
    /// </summary>
    public partial class PageEditTransport : Page
    {
        public PageEditTransport(transport transport)
        {
            InitializeComponent();
            txtSotr.SelectedIndex = (int)transport.id_sotrudnik - 1;
            txtSotr.SelectedValuePath = "id_sotrudnik";
            txtSotr.DisplayMemberPath = "name";
            txtSotr.ItemsSource = gibddEntities1.GetContext().sotrudniki.ToList();

            txtStatus.SelectedIndex = (int)transport.id_sotrudnik - 1;
            txtStatus.SelectedValuePath = "id_status";
            txtStatus.DisplayMemberPath = "status1";
            txtStatus.ItemsSource = gibddEntities1.GetContext().status.ToList();    

            txtType.SelectedIndex = (int)transport.id_sotrudnik - 1;
            txtType.SelectedValuePath = "id_type";
            txtType.DisplayMemberPath = "type";
            txtType.ItemsSource = gibddEntities1.GetContext().type_of_transport.ToList();

            TransportObj.id_auto = transport.id_auto;

           txtMarka.Text = transport.marka;
           txtModel.Text = transport.model;
           txtNomer.Text = transport.gosNomer;
            txtRashod.Text = Convert.ToString(transport.rashod);

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                IEnumerable<transport> transports = gibddEntities1.GetContext().transport.Where(x => x.id_auto == TransportObj.id_auto).AsEnumerable().Select(x => {
                                x.marka = txtMarka.Text;
                                x.model = txtModel.Text;
                                x.gosNomer = txtNomer.Text;
                                x.id_type = (int)txtType.SelectedValue;
                                x.id_status = (int)txtStatus.SelectedValue;
                                x.id_sotrudnik = (int)txtSotr.SelectedValue;
                                x.rashod = Convert.ToInt32(txtRashod.Text);
                                return x;
                                });
                            foreach(transport trnsprt in transports)
                            {
                                gibddEntities1.GetContext().Entry(trnsprt).State = System.Data.Entity.EntityState.Modified;
                            }
                            gibddEntities1.GetContext().SaveChanges();
                            MessageBox.Show("Данные упешно обновлены!","Уведомление!",MessageBoxButton.OK, MessageBoxImage.Information);
            } catch (Exception er)
            {
                MessageBox.Show("Ошибка!","Уведомление!",MessageBoxButton.OK, MessageBoxImage.Error);
            }

            
               

        }
    }
}
