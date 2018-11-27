using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Input;

using System.Windows.Media.Animation;

namespace thousand_switches
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Data.getData();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void Button_Click_Register(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Back_btn_Click(object sender, RoutedEventArgs e)
        {
            back_btn.Visibility = Visibility.Hidden;
            login_grid1.Visibility = Visibility.Visible;
            login_grid1.IsEnabled = true;
            ServicesAnimation.up_and_show(login_grid1, 69, 39,Canvas.LeftProperty,500);
            ServicesAnimation.up_and_show(register_grid1, 39, 9, Canvas.LeftProperty,500);
            ServicesAnimation.opacity(register_grid1, 0.5, 0.0,500);
            ServicesAnimation.opacity(login_grid1, 0.0, 1,500);
            register_grid1.Visibility = Visibility.Collapsed;

        }



        private void sign_in_Click(object sender, RoutedEventArgs e)
        {
            
            if (Data.log_in(username_or_email.Text, password_box.Password))
            {

                Main_Window new_window = new Main_Window();
                this.Close();
                new_window.Show();
            }
        }
        

        private void New_register_btn_Click(object sender, RoutedEventArgs e)
        {
            back_btn.Visibility = Visibility.Visible;
            register_grid1.Visibility = Visibility.Visible;
            register_grid1.IsEnabled = true;
            ServicesAnimation.up_and_show(register_grid1, 9, 39,Canvas.LeftProperty,500);
            ServicesAnimation.up_and_show(login_grid1, 9, 39,Canvas.LeftProperty,500);
            ServicesAnimation.opacity(login_grid1, 0.5,0.0,500);
            ServicesAnimation.opacity(register_grid1, 0.0, 1,500);
            
            login_grid1.Visibility = Visibility.Collapsed;




        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Admin admin = new Admin(reg_name.Text, reg_username.Text, reg_email.Text, reg_password.Password);
            Data.addNewAdmin(admin);

            string str = "";
            foreach(Admin ttt in Data.adminList)
            {
                str += ttt.toShow();
            }
        }
    }
}
