using ChineseCheckersClient.UserControls;
using ChineseCheckersClient;
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

namespace ChineseCheckersClient.Pages
{
    /// <summary>
    /// Lógica de interacción para Loggin.xaml
    /// </summary>
    public partial class Loggin : Page
    {
        public Loggin()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window mainWindow = App.Current.MainWindow;
            var a = new Lobby();
            MainWindow mainasd = new MainWindow();
            mainasd.initPage(a);

        }
    }
}
