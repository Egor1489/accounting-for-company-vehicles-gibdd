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
using My_kursovaya_wpf.Pages;
using System.Diagnostics;

namespace My_kursovaya_wpf.Pages
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            
           
        }

        private void BtnTransport_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageTransport());

        }

        private void btnNewTransport_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new AddTransport());
        }

        private void btnEmploy_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new PageSotrudniki());
        }

        private void btnNewEmploy_Click(object sender, RoutedEventArgs e)
        {
            FrameObj.MainFrame.Navigate(new AddSotrudniki());
        }
        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {

            Process.Start(@"C:\Users\User\source\repos\My-kursovaya-wpf\My-kursovaya-wpf\Resources\PageAbout.html");
        }
    }
}
