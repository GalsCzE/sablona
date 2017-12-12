using Sablona.Entity;
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

namespace Sablona
{
    /// <summary>
    /// Interakční logika pro Prihlaseni.xaml
    /// </summary>
    public partial class Prihlaseni : Page
    {
        public List<User> u = new List<User>();
        public Prihlaseni()
        {
            InitializeComponent();
        }

        private void conf_Click(object sender, RoutedEventArgs e)
        {
            string p = pass.ToString();
            string n = log.ToString();

            if (MainWindow.user[1].Login != n || MainWindow.user[1].Password != p)
            {
                MessageBox.Show("Přístup zamítnut!");
            }
            else
            {
                MessageBox.Show("Přístup povolen");
            }
        }
    }
}
