using Sablona.Entity;
using Sablona.Framy;
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
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static List<User> user = new List<User>();
        public MainWindow()
        {
            InitializeComponent();
            user.Add(new User() { ID = 1, Name = "Martin", Login = "user", Password = "user" });
            user.Add(new User() { ID = 2, Name = "Martin2", Login = "user2", Password = "user2" });
            BackEnd.frame = frame;
            //BackEnd.frame.Navigate();
        }
    }
}
