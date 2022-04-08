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
using System.Windows.Threading;
using My_kursovaya_wpf.AppDataFiles;
using My_kursovaya_wpf.Pages;

namespace My_kursovaya_wpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageTransport.xaml
    /// </summary>
    public partial class PageTransport : Page
    {
        public PageTransport()
        {
            InitializeComponent();
            grdTransport.ItemsSource = gibddEntities1.GetContext().transport.ToList();
            grdSortTransport.ItemsSource = gibddEntities1.GetContext().transport.ToList();
           // DispatcherTimer timer = new DispatcherTimer();
            //timer.Interval = TimeSpan.FromSeconds(1);
            //timer.Tick += UpdateData;
            //timer.Start();
        }
        public void UpdateData(object sender, object e)
        {
            var HistoryAuto = gibddEntities1.GetContext().transport.ToList();
            grdTransport.ItemsSource = HistoryAuto;
            grdTransport.ItemsSource = gibddEntities1.GetContext().transport.Where(x => x.marka.StartsWith(SearchLine.Text) || x.gosNomer.StartsWith(SearchLine.Text)).ToList();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var remove = grdTransport.SelectedItems.Cast<transport>().ToList();
            if(MessageBox.Show("Вы уверены?", "Уведомление",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                try
                {
                    gibddEntities1.GetContext().transport.RemoveRange(remove);
                    gibddEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                } catch(Exception ex) {
                    MessageBox.Show("Данные не удалены!", "Уведомление", MessageBoxButton.OK,MessageBoxImage.Error);
                
                    }
            }
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageEditTransport((sender as Button).DataContext as transport));
        }

        private void rbSort_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            grdSortTransport.ItemsSource = gibddEntities1.GetContext().transport.OrderBy(x => x.marka).ToList();

        }

       

        private void rbRSort_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            grdSortTransport.ItemsSource = gibddEntities1.GetContext().transport.OrderBy(x => x.id_status).ToList();
        }

        private void rbStatusSort_IsMouseCapturedChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            grdSortTransport.ItemsSource = gibddEntities1.GetContext().transport.OrderBy(x => x.id_type).ToList();
        }
    }
}
