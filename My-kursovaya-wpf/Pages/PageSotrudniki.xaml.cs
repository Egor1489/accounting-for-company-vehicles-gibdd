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

namespace My_kursovaya_wpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageSotrudniki.xaml
    /// </summary>
    public partial class PageSotrudniki : Page
    {
        public PageSotrudniki()
        {
            InitializeComponent();
            grdSotr.ItemsSource = gibddEntities1.GetContext().sotrudniki.ToList();
            ListSotrudniki.ItemsSource = gibddEntities1.GetContext().sotrudniki.ToList();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += UpdateData;
            timer.Start();

        }

        public void UpdateData(object sender, object e)
        {
            var historySotr = gibddEntities1.GetContext().sotrudniki.ToList();
            ListSotrudniki.ItemsSource = historySotr;
            ListSotrudniki.ItemsSource = gibddEntities1.GetContext().sotrudniki.Where(x => x.name.StartsWith(txtSearchSotr.Text) || x.dolzhnost.StartsWith(txtSearchSotr.Text)).ToList();

        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
              var remove = grdSotr.SelectedItems.Cast<sotrudniki>().ToList();
            if(MessageBox.Show("Вы уверены?", "Уведомление",MessageBoxButton.YesNo,MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                try
                {
                  // gibddEntities1.GetContext().sotrudniki.RemoveRange(remove);
                    gibddEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные успешно удалены!","Уведомление",MessageBoxButton.OK,MessageBoxImage.Information);
                } catch(Exception ex) {
                       MessageBox.Show("Данные не удалены!","Уведомление",MessageBoxButton.OK, MessageBoxImage.Error);               
                
                } 
            }

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageEditSotrodniki((sender as Button).DataContext as sotrudniki));
        }

        private void sortDolzhnost_Click(object sender, RoutedEventArgs e)
        {
            grdSotr.ItemsSource = gibddEntities1.GetContext().sotrudniki.OrderBy(x => x.dolzhnost).ToList();
        }

        private void sotrZvanie_Click(object sender, RoutedEventArgs e)
        {
            grdSotr.ItemsSource = gibddEntities1.GetContext().sotrudniki.OrderBy(x => x.zvanie).ToList();
        }

        private void sotrOtdel_Click(object sender, RoutedEventArgs e)
        {
            grdSotr.ItemsSource = gibddEntities1.GetContext().sotrudniki.OrderBy(x => x.otdel).ToList();
        }

        private void btnDelSotr_Click(object sender, RoutedEventArgs e)
        {
            var removeSotr = grdSotr.SelectedItems.Cast<sotrudniki>().ToList();
            
        }
    }
}
