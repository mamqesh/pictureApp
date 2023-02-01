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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Point startPoint;
        public Rectangle rect;
        Shape LastShape;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            startPoint = e.GetPosition(canvas);

            rect = new Rectangle
            {
                Stroke = Brushes.LightBlue,
                StrokeThickness = 2

            };
            Canvas.SetLeft(rect, startPoint.X);
            Canvas.SetTop(rect, startPoint.Y);
            canvas.Children.Add(rect);
        }
        
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cbFill_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color SelectedColorFill = (Color)cbFill.SelectedItem;
        }

        private void cbContr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Color SelectedColorContr = (Color)cbContr.SelectedItem;
        }
    }
}
