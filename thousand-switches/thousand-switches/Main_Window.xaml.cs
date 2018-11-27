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
        private const int Duration = 400;
        public static string added_type;
        object selected_object;

        List<History> history_list = new List<History>();

        public Main_Window()
        {
            InitializeComponent();
            init();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            canvas_history.Visibility = Visibility.Collapsed;
        }
        void init()
        {
            Styles.templ = ((ControlTemplate)this.FindResource("buttonsimle"));
            Styles.gray = new SolidColorBrush((Color)FindResource("Gray"));
            Styles.darkgray = new SolidColorBrush((Color)FindResource("DarkGray"));
            Styles.green = new SolidColorBrush((Color)FindResource("Green"));
            Styles.lightgray = new SolidColorBrush((Color)FindResource("LightGray"));
            Styles.lightBlue= new SolidColorBrush((Color)FindResource("LightBlue"));
            Styles.red = new SolidColorBrush((Color)FindResource("Red"));
            Styles.darkblue = new SolidColorBrush((Color)FindResource("DarkGreen"));

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }



        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void New_connect_Click(object sender, RoutedEventArgs e)
        {
            if (new_connect_symbol.Content.ToString() == "plus")
            {
                new_connect_symbol.Content = "minus";

                show_btn_connect();
            }
            else
            {
                new_connect_symbol.Content = "plus";
                hide_btn_connect();
            }

        }

        public void show_btn_connect()
        {
            if (selected_object == null)
            {
                connect_Router.Visibility = Visibility.Visible;
                ServicesAnimation.up_and_show(grid_connect_Router, 10, 60, Canvas.BottomProperty, Duration);
                ServicesAnimation.opacity(grid_connect_Router, 0.5, 1.0, Duration);

            }
            else
            {
                if (selected_object is Router)
                {
                    connect_Router.Visibility = Visibility.Visible;
                    connect_Switch.Visibility = Visibility.Visible;
                    ServicesAnimation.up_and_show(grid_connect_Switch, 10, 110, Canvas.BottomProperty, Duration);
                    ServicesAnimation.up_and_show(grid_connect_Router, 10, 60, Canvas.BottomProperty, Duration);
                    ServicesAnimation.opacity(grid_connect_Switch, 0.5, 1.0, Duration);
                    ServicesAnimation.opacity(grid_connect_Router, 0.5, 1.0, Duration);
                }
                if (selected_object is Switch)
                {
                    connect_PC.Visibility = Visibility.Visible;
                    connect_Router.Visibility = Visibility.Visible;
                    connect_Switch.Visibility = Visibility.Visible;
                    ServicesAnimation.up_and_show(grid_connect_PC, 10, 160, Canvas.BottomProperty, Duration);
                    ServicesAnimation.up_and_show(grid_connect_Switch, 10, 110, Canvas.BottomProperty, Duration);
                    ServicesAnimation.up_and_show(grid_connect_Router, 10, 60, Canvas.BottomProperty, Duration);
                    ServicesAnimation.opacity(grid_connect_PC, 0.5, 1.0, Duration);
                    ServicesAnimation.opacity(grid_connect_Switch, 0.5, 1.0, Duration);
                    ServicesAnimation.opacity(grid_connect_Router, 0.5, 1.0, Duration);
                }
            }


        } 

        public void hide_btn_connect()
        {
            if (add_grid.ActualHeight > 0)
            {
                ServicesAnimation.hide_add_grid(add_grid);

                if (selected_object == null)
                {
                    connect_Router.Visibility = Visibility.Visible;
                    ServicesAnimation.up_and_show(grid_connect_Router, Convert.ToInt32(Canvas.GetBottom(grid_connect_Router)), 10, Canvas.BottomProperty, Duration, 400);
                    ServicesAnimation.opacity(grid_connect_Router, 1.0, 0.0, Duration, 400);

                }
                else
                {
                    if (selected_object is Router)
                    {
                        connect_Router.Visibility = Visibility.Visible;
                        connect_Switch.Visibility = Visibility.Visible;
                        ServicesAnimation.up_and_show(grid_connect_Switch, Convert.ToInt32(Canvas.GetBottom(grid_connect_Switch)), 10, Canvas.BottomProperty, Duration, 400);
                        ServicesAnimation.up_and_show(grid_connect_Router, Convert.ToInt32(Canvas.GetBottom(grid_connect_Router)), 10, Canvas.BottomProperty, Duration, 400);
                        ServicesAnimation.opacity(grid_connect_Switch, 1.0, 0.0, Duration, 400);
                        ServicesAnimation.opacity(grid_connect_Router, 1.0, 0.0, Duration, 400);
                    }
                    if (selected_object is Switch)
                    {
                        connect_PC.Visibility = Visibility.Visible;
                        connect_Router.Visibility = Visibility.Visible;
                        connect_Switch.Visibility = Visibility.Visible;
                        ServicesAnimation.up_and_show(grid_connect_PC, Convert.ToInt32(Canvas.GetBottom(grid_connect_PC)), 10, Canvas.BottomProperty, Duration,400);
                        ServicesAnimation.up_and_show(grid_connect_Switch, Convert.ToInt32(Canvas.GetBottom(grid_connect_Switch)), 10, Canvas.BottomProperty, Duration,400);
                        ServicesAnimation.up_and_show(grid_connect_Router, Convert.ToInt32(Canvas.GetBottom(grid_connect_Router)), 10, Canvas.BottomProperty, Duration,400);
                        ServicesAnimation.opacity(grid_connect_PC, 1.0, 0.0, Duration,400);
                        ServicesAnimation.opacity(grid_connect_Switch, 1.0, 0.0, Duration,400);
                        ServicesAnimation.opacity(grid_connect_Router, 1.0, 0.0, Duration,400);
                    }
                }
            }
            else
            {
                ServicesAnimation.up_and_show(grid_connect_PC, Convert.ToInt32(Canvas.GetBottom(grid_connect_PC)), 10, Canvas.BottomProperty, Duration);
                ServicesAnimation.up_and_show(grid_connect_Switch, Convert.ToInt32(Canvas.GetBottom(grid_connect_Switch)), 10, Canvas.BottomProperty, Duration);
                ServicesAnimation.up_and_show(grid_connect_Router, Convert.ToInt32(Canvas.GetBottom(grid_connect_Router)), 10, Canvas.BottomProperty, Duration);
                ServicesAnimation.opacity(grid_connect_PC, 1.0, 0.0, Duration);
                ServicesAnimation.opacity(grid_connect_Switch, 1.0, 0.0, Duration);
                ServicesAnimation.opacity(grid_connect_Router, 1.0, 0.0, Duration);
            }

        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            Application.Current.Shutdown();
        }

        private void Connect_Switch_Click(object sender, RoutedEventArgs e)
        {
            int num = Equipment.switchs.Count + 1;
            txt_name.Text = "Switch" + num;
            txt_ip.Text = "192.168.0." + ip_num;
            added_type = "Switch";
            if (add_grid.ActualHeight == 0)
            {
                ServicesAnimation.up_and_show(grid_connect_Switch, Convert.ToInt32(Canvas.GetBottom(grid_connect_Switch)), 160, Canvas.BottomProperty, Duration);

                if (selected_object is Switch)
                {
                    ServicesAnimation.up_and_show(grid_connect_PC, 160, 10, Canvas.BottomProperty, Duration);
                    ServicesAnimation.opacity(grid_connect_PC, 1.0, 0.0, Duration);
                }

                ServicesAnimation.up_and_show(grid_connect_Router, 60, 10, Canvas.BottomProperty, Duration);
                ServicesAnimation.opacity(grid_connect_Router, 1.0, 0.0, Duration);

                ServicesAnimation.show_add_grid(add_grid);
            }
            else
            {
                ServicesAnimation.hide_add_grid(add_grid);
                if (selected_object is Router)
                {
                    connect_Router.Visibility = Visibility.Visible;
                    connect_Switch.Visibility = Visibility.Visible;
                    ServicesAnimation.up_and_show(grid_connect_Switch, Convert.ToInt32(Canvas.GetBottom(grid_connect_Switch)), 110, Canvas.BottomProperty, Duration, 300);
                    ServicesAnimation.up_and_show(grid_connect_Router, 10, 60, Canvas.BottomProperty, Duration, 300);
                    ServicesAnimation.opacity(grid_connect_Router, 0.5, 1.0, Duration, 300);
                }
                else
                {
                    ServicesAnimation.up_and_show(grid_connect_PC, 10, 160, Canvas.BottomProperty, Duration,300);
                    ServicesAnimation.up_and_show(grid_connect_Switch, Convert.ToInt32(Canvas.GetBottom(grid_connect_Switch)), 110, Canvas.BottomProperty, Duration, 300);
                    ServicesAnimation.up_and_show(grid_connect_Router, 10, 60, Canvas.BottomProperty, Duration,300);
                    ServicesAnimation.opacity(grid_connect_PC, 0.5, 1.0, Duration,300);
                    ServicesAnimation.opacity(grid_connect_Router, 0.5, 1.0, Duration,300);
                }

            }
        }

        private void Connect_Router_Click(object sender, RoutedEventArgs e)
        {
            int num = Equipment.routers.Count + 1;
            txt_name.Text = "Router" + num;
            txt_ip.Text = "192.168.0." + ip_num;
            added_type = "Router";

            if (add_grid.ActualHeight == 0)
            {
                ServicesAnimation.up_and_show(grid_connect_Router, Convert.ToInt32(Canvas.GetBottom(grid_connect_Router)), 160, Canvas.BottomProperty, Duration);
                if (selected_object != null)
                {
                    if (selected_object is Switch)
                    {
                        ServicesAnimation.up_and_show(grid_connect_PC, 160, 10, Canvas.BottomProperty, Duration);
                        ServicesAnimation.opacity(grid_connect_PC, 1.0, 0.0, Duration);
                    }

                    ServicesAnimation.up_and_show(grid_connect_Switch, 110, 10, Canvas.BottomProperty, Duration);
                    ServicesAnimation.opacity(grid_connect_Switch, 1.0, 0.0, Duration);
                }
                ServicesAnimation.show_add_grid(add_grid);
            }
            else
            {
                ServicesAnimation.hide_add_grid(add_grid);
                if (selected_object == null)
                {
                    connect_Router.Visibility = Visibility.Visible;
                    ServicesAnimation.up_and_show(grid_connect_Router, Convert.ToInt32(Canvas.GetBottom(grid_connect_Router)), 60, Canvas.BottomProperty, Duration, 300);

                }
                else
                {
                    if (selected_object is Router)
                    {
                        connect_Router.Visibility = Visibility.Visible;
                        connect_Switch.Visibility = Visibility.Visible;
                        ServicesAnimation.up_and_show(grid_connect_Switch, 10, 110, Canvas.BottomProperty, Duration, 300);
                        ServicesAnimation.up_and_show(grid_connect_Router, Convert.ToInt32(Canvas.GetBottom(grid_connect_Router)), 60, Canvas.BottomProperty, Duration, 300);
                        ServicesAnimation.opacity(grid_connect_Switch, 0.5, 1.0, Duration, 300);
                    }
                    if (selected_object is Switch)
                    {
                        connect_PC.Visibility = Visibility.Visible;
                        connect_Router.Visibility = Visibility.Visible;
                        connect_Switch.Visibility = Visibility.Visible;
                        ServicesAnimation.up_and_show(grid_connect_PC, 10, 160, Canvas.BottomProperty, Duration, 300);
                        ServicesAnimation.up_and_show(grid_connect_Switch, 10, 110, Canvas.BottomProperty, Duration, 300);
                        ServicesAnimation.up_and_show(grid_connect_Router, Convert.ToInt32(Canvas.GetBottom(grid_connect_Router)), 60, Canvas.BottomProperty, Duration, 300);
                        ServicesAnimation.opacity(grid_connect_PC, 0.5, 1.0, Duration, 300);
                        ServicesAnimation.opacity(grid_connect_Switch, 0.5, 1.0, Duration, 300);
                        ServicesAnimation.opacity(grid_connect_Router, 0.5, 1.0, Duration, 300);
                    }
                }

            }
        }
        public static int ip_num = 1;
        private void Connect_PC_Click(object sender, RoutedEventArgs e)
        {
            int num = Equipment.pcs.Count + 1;
            txt_name.Text = "PC" + num;
            txt_ip.Text = "192.168.0." + ip_num;
            added_type = "PC";

            if (add_grid.ActualHeight == 0)
            {
                ServicesAnimation.up_and_show(grid_connect_Switch, 110, 10, Canvas.BottomProperty, Duration);
                ServicesAnimation.up_and_show(grid_connect_Router, 60, 10, Canvas.BottomProperty, Duration);
                ServicesAnimation.opacity(grid_connect_Switch, 1.0, 0.0, Duration);
                ServicesAnimation.opacity(grid_connect_Router, 1.0, 0.0, Duration);
                ServicesAnimation.show_add_grid(add_grid);
            }
            else
            {
                ServicesAnimation.hide_add_grid(add_grid);


                ServicesAnimation.up_and_show(grid_connect_Switch, 10, 110, Canvas.BottomProperty, Duration,300);
                ServicesAnimation.up_and_show(grid_connect_Router, 10, 60, Canvas.BottomProperty, Duration, 300);
                ServicesAnimation.opacity(grid_connect_Switch, 0.5, 1.0, Duration, 300);
                ServicesAnimation.opacity(grid_connect_Router, 0.5, 1.0, Duration, 300);
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            new_connect_symbol.Content = "plus";

            hide_btn_connect();
            if (selected_object == null)
            {
                Router router = new Router(txt_name.Text, txt_ip.Text);
                ip_num++;
                ref Router ref_router = ref router;
                Equipment.routers.Add(router);
                Data.this_network = new Network(ref_router);
                canvas_net.Children.Add(ServicesCreateObject.new_object(Data.this_network.main_router));
                ((canvas_net.Children[canvas_net.Children.Count - 1] as Grid).Children[0] as Button).Click += new RoutedEventHandler(element_Click);
              // lll.Content= (canvas_net.FindName("grid" + router.ToString()) as Grid).Name;
            }
            else
            {
                if(selected_object is Router)
                {
                    switch (added_type)
                    {
                        case "Router":
                            {
                                Router router = new Router(txt_name.Text, txt_ip.Text);
                                ip_num++;
                                ref Router ref_router = ref router;
                                Equipment.routers.Add(router);
                                ref_router.column = (selected_object as Router).column + 1;
                                ref_router.row = (selected_object as Router).list_connect.Count + 1;
                                (selected_object as Router).list_connect.Add(ref_router);
                                canvas_net.Children.Add(ServicesCreateObject.new_object(ref_router));
                                ((canvas_net.Children[canvas_net.Children.Count - 1] as Grid).Children[0] as Button).Click += new RoutedEventHandler(element_Click);
                            }
                            break;
                        case "Switch":
                            {
                                Switch switch_ = new Switch(txt_name.Text, txt_ip.Text);
                                ip_num++;
                                ref Switch ref_switch = ref switch_;
                                Equipment.switchs.Add(switch_);
                                ref_switch.column = (selected_object as Router).column + 1;
                                ref_switch.row = (selected_object as Router).list_connect.Count + 1;
                                (selected_object as Router).list_connect.Add(ref_switch);
                                canvas_net.Children.Add(ServicesCreateObject.new_object(ref_switch));
                                ((canvas_net.Children[canvas_net.Children.Count - 1] as Grid).Children[0] as Button).Click += new RoutedEventHandler(element_Click);
                            }
                            break;
                    }

                }
                if(selected_object is Switch)
                {
                    switch (added_type)
                    {
                        case "Router":
                            {
                                Router router = new Router(txt_name.Text, txt_ip.Text);
                                ip_num++;
                                ref Router ref_router = ref router;
                                Equipment.routers.Add(router);
                                ref_router.column = (selected_object as Switch).column + 1;
                                ref_router.row = (selected_object as Switch).list_connect.Count + 1;
                                (selected_object as Switch).list_connect.Add(ref_router);
                                canvas_net.Children.Add(ServicesCreateObject.new_object(ref_router));
                                ((canvas_net.Children[canvas_net.Children.Count - 1] as Grid).Children[0] as Button).Click += new RoutedEventHandler(element_Click);
                            }
                            break;
                        case "Switch":
                            {
                                Switch switch_ = new Switch(txt_name.Text, txt_ip.Text);
                                ip_num++;
                                ref Switch ref_switch = ref switch_;
                                Equipment.switchs.Add(switch_);
                                ref_switch.column = (selected_object as Switch).column + 1;
                                ref_switch.row = (selected_object as Switch).list_connect.Count + 1;
                                (selected_object as Switch).list_connect.Add(ref_switch);
                                canvas_net.Children.Add(ServicesCreateObject.new_object(ref_switch));
                                ((canvas_net.Children[canvas_net.Children.Count - 1] as Grid).Children[0] as Button).Click += new RoutedEventHandler(element_Click);
                            }
                            break;
                        case "PC":
                            {
                                PC pc = new PC(txt_name.Text, txt_ip.Text);
                                ip_num++;
                                ref PC ref_pc = ref pc;
                                Equipment.pcs.Add(pc);
                                ref_pc.column = (selected_object as Switch).column + 1;
                                ref_pc.row = (selected_object as Switch).list_connect.Count + 1;
                                (selected_object as Switch).list_connect.Add(ref_pc);
                                canvas_net.Children.Add(ServicesCreateObject.new_object(ref_pc));
                                ((canvas_net.Children[canvas_net.Children.Count - 1] as Grid).Children[0] as Button).Click += new RoutedEventHandler(element_Click);
                            }
                            break;
                    }
                }
                

            }
        }

        private void element_Click(object sender, RoutedEventArgs e)
        {
            selected_object = (sender as Button).GetBindingExpression(Control.OpacityProperty).DataItem;
            (sender as Button).Template = ((ControlTemplate)this.FindResource("buttonon"));

        }

      
        private void Network_click(object sender, RoutedEventArgs e)
        {
            canvas_history.Visibility = Visibility.Collapsed;
            canvas_net.Visibility = Visibility.Visible;
        }

        private void buttonHistory_Click(object sender, RoutedEventArgs e)
        {
            canvas_history.Visibility = Visibility.Visible;
            canvas_net.Visibility = Visibility.Collapsed;


            History h1 = new History("add", "switch1", "router1");
            History h2 = new History("delete", "Pc", "switch1");

            history_list.Add(h1);
            history_list.Add(h2);

            for (int index = 0; index < history_list.Count; index++)
            { 
                canvas_history.Children.Add(ServicesCreateObject.create_history_grid(history_list[index], 90, 90 + index * 62 ));
            }

        


        }

    }
}
