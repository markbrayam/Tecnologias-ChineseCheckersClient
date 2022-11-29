using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace ChineseCheckersClient
{
    /// <summary>
    /// Lógica de interacción para GameTable.xaml
    /// </summary>
    public partial class Board : Page
    {

        public Board()
        {
            InitializeComponent();
            
        }

        UIElement dragObject = null;
        Point offset;

        private void Ellipse_MouseMove(object sender, MouseEventArgs e)
        {
            Ellipse ellipse = sender as Ellipse;

            if (ellipse != null && e.LeftButton == MouseButtonState.Pressed)
            {
                DragDrop.DoDragDrop(ellipse, ellipse.Fill.ToString(), DragDropEffects.Scroll);
            }
        }


        private void Ellipse_DragEnter(object sender, DragEventArgs e)
        {
            Ellipse ellipse = sender as Ellipse;
            if (ellipse != null)
            {
                Console.WriteLine("Destino");
                BrushConverter bc = new BrushConverter();
                Brush brush = (Brush)bc.ConvertFrom("Yellow");
                ellipse.Fill = brush;

            }
        }

        private void FillUser0()
        {
            var fichasUser0 = ["_16_3", "_14_3", "_11_3"]; 
        }

        private void Ellipse_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {


        }

        private void Ellipse_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

        }
    }
}