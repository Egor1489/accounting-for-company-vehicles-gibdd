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
using My_kursovaya_wpf.Pages;
using My_kursovaya_wpf.AppDataFiles;
using System.Diagnostics;

namespace My_kursovaya_wpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {   
        public MainWindow()
        {
            InitializeComponent();
            FrameObj.MainFrame = frameMain;
            
            frameMain.Navigate(new MainPage());
            
            
           
        }
        
        private void btnBack_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                frameMain.GoBack();
            } catch(Exception ex)
            {
                if( MessageBox.Show("Вы уверены что хотите закрыть приложение?", "Уведомление",MessageBoxButton.OKCancel,MessageBoxImage.Warning) == MessageBoxResult.OK)
                {
                    this.Close();

                }
            }
        }

      
    }
}
