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
using System.Windows.Shapes;

namespace thousand_switches
{
    /// <summary>
    /// Логика взаимодействия для Main_Window.xaml
    /// </summary>
    public partial class Main_Window : Window
    {
        public Main_Window()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            draw_line(Router_1, grid_switch_1);
            draw_line(Router_1, grid_switch_2);
            draw_line(Router_1, grid_switch_3);

            //this.Visibility = Visibility.Hidden;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void New_register_btn_Click(object sender, RoutedEventArgs e)
        {

            this.elipse.Fill = new SolidColorBrush((Color)this.FindResource("Red"));
            this.elipse.Stroke = new SolidColorBrush((Color)this.FindResource("LightBlue"));

            router_1.Template = ((ControlTemplate)this.FindResource("buttonon"));
            ServicesAnimation.transponent(grid_switch_1, 88, 55, 393, 55,canvas);
            ServicesAnimation.transponent(grid_switch_2, 88, 55, 393, 125,canvas);
            ServicesAnimation.transponent(grid_switch_3, 88, 55, 393, 195,canvas);


        }
        public void draw_line(Grid from,Grid to)
        {
            Line myLine = new Line();
            myLine.Stroke = new SolidColorBrush((Color)this.FindResource("LightGray"));
            myLine.X1 = Canvas.GetLeft(from)+from.Width;
            myLine.X2 = Canvas.GetLeft(to);
            myLine.Y1 = Canvas.GetTop(from)+20;
            myLine.Y2 = Canvas.GetTop(to)+20;
            myLine.Name = "from_" + from.Name + "_to_" + to.Name;
            myLine.HorizontalAlignment = HorizontalAlignment.Left;
            myLine.VerticalAlignment = VerticalAlignment.Center;
            myLine.StrokeThickness = 1;
            canvas.Children.Add(myLine);

        }
    }
}
