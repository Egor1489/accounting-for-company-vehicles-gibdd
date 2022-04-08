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
    /// Логика взаимодействия для PageEditSotrodniki.xaml
    /// </summary>
    public partial class PageEditSotrodniki : Page
    {
        public PageEditSotrodniki(sotrudniki sotrudniki)
        {
            InitializeComponent();

            SotrudnikiObj.id_sotrudnik = sotrudniki.id_sotrudnik;

            txtFIO.Text = sotrudniki.name;
            txtDolzh.Text = sotrudniki.dolzhnost;
            txtZvanie.Text = sotrudniki.zvanie;
            txtAge.Text = Convert.ToString(sotrudniki.age);
            txtAdres.Text = sotrudniki.adres;
            txtContact.Text = sotrudniki.contact;
            txtOtdel.Text = sotrudniki.otdel;

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                 IEnumerable<sotrudniki> sotrudnikis = gibddEntities1.GetContext().sotrudniki.Where(x => x.id_sotrudnik == SotrudnikiObj.id_sotrudnik).AsEnumerable().Select(X =>
                            {
                            X.name = txtFIO.Text;
                            X.dolzhnost = txtDolzh.Text;
                            X.zvanie = txtZvanie.Text;
                            X.age = Convert.ToInt32(txtAge.Text);
                            X.adres = txtAdres.Text;
                            X.contact = txtContact.Text;
                            X.otdel = txtOtdel.Text;
                            return X;
                        });
                        foreach(sotrudniki sotr in sotrudnikis)
                        {
                            gibddEntities1.GetContext().Entry(sotr).State = System.Data.Entity.EntityState.Modified; 
                        }
                        gibddEntities1.GetContext().SaveChanges();
                        MessageBox.Show("Данные успешно обновлены!","Уведомление!", MessageBoxButton.OK, MessageBoxImage.Information);
            } catch (Exception er)
            {
                MessageBox.Show("Ошибка!","Уведомление",MessageBoxButton.OK, MessageBoxImage.Error);
            }
           

        }
    }
}
