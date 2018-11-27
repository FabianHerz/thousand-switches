using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Effects;
using System.Windows.Shapes;


namespace thousand_switches
{
    class ServicesCreateObject
    {

        public static Grid create_history_grid(History h, int left, int top )
        {
            Grid grid = new Grid();
            // grid.Name = "history_element";
            grid.HorizontalAlignment = HorizontalAlignment.Left;
            grid.VerticalAlignment = VerticalAlignment.Top;
            grid.Height = 42;
            grid.Width = 1134;

            // Create rectangle.
            Rectangle rect = new Rectangle();
            Thickness margin = rect.Margin;
            margin.Left = 0;
            margin.Top = 4;
            margin.Bottom = 10;
            margin.Right = 250;
            rect.Margin = margin;
            rect.Fill = Styles.gray;
            rect.RadiusX = 20;
            rect.RadiusY = 20;
            // Add rectangle in Grid
            grid.Children.Add(rect);
            grid.Children.Add(create_history_lbl(h.ToString()));

            // Add grin in Canvas.
            grid.Visibility = Visibility.Visible;
            Canvas.SetLeft(grid, left);
            Canvas.SetTop(grid, top);
                

            grid.Effect = create_shadow();

            return grid;

        }


        public static Grid new_object(object obj)
        {
            
            if(obj is Router)
            {
                
               return  create_Router((obj as Router), getCoordinats((obj as Router).row, (obj as Router).column));
            }
            else if(obj is Switch)
            {
                return create_Switch((obj as Switch), getCoordinats((obj as Switch).row, (obj as Switch).column));
            }
            else if(obj is PC)
            {
               return  create_PC((obj as PC), getCoordinats((obj as PC).row, (obj as PC).column));
            }
            return null;
        }
        public static Coordinats getCoordinats(int row, int column)
        {
            Coordinats coordinats = new Coordinats();
            coordinats.left = 10 + (column - 1) * 180;
            coordinats.top = 40 + (row - 1) * 50;
            return coordinats;
        }
        public static Grid create_Router(Router router_, Coordinats coordinats)
        {
            Grid grid = new Grid();
            grid.Name = "grid" + router_.Name;
            grid.HorizontalAlignment = HorizontalAlignment.Left;
            grid.VerticalAlignment = VerticalAlignment.Top;
            grid.Height = 30;
            grid.Width = 127;
            Canvas.SetLeft(grid, coordinats.left);
            Canvas.SetTop(grid, coordinats.top);
            grid.Effect = create_shadow();


            grid.Children.Add(create_btn(router_.Name,router_));
            grid.Children.Add(create_lbl(router_.Name, ""));
            grid.Children.Add(create_ellipse(router_.Name));
            return grid;
        }
        public static Grid create_Switch(Switch switch_,Coordinats coordinats)
        {
            Grid grid = new Grid();
            grid.Name = "grid" + switch_.Name;
            grid.HorizontalAlignment = HorizontalAlignment.Left;
            grid.VerticalAlignment = VerticalAlignment.Top;
            grid.Height = 30;
            grid.Width = 127;
            Canvas.SetLeft(grid, coordinats.left);
            Canvas.SetTop(grid, coordinats.top);
            grid.Effect = create_shadow();


            grid.Children.Add(create_btn(switch_.Name,switch_));
            grid.Children.Add(create_lbl(switch_.Name, ""));
            grid.Children.Add(create_ellipse(switch_.Name));
            return grid;
        }
        public static Grid create_PC(PC pc, Coordinats coordinats)
        {
            Grid grid = new Grid();
            grid.Name = "grid" + pc.Name;
            grid.HorizontalAlignment = HorizontalAlignment.Left;
            grid.VerticalAlignment = VerticalAlignment.Top;
            grid.Height = 30;
            grid.Width = 127;
            Canvas.SetLeft(grid, coordinats.left);
            Canvas.SetTop(grid, coordinats.top);
            grid.Effect = create_shadow();


            grid.Children.Add(create_btn(pc.Name,pc));
            grid.Children.Add(create_lbl(pc.Name, ""));
            grid.Children.Add(create_ellipse(pc.Name));
            return grid;
        }

        public static Button create_btn(string Name,object obj)
        {

            Button btn = new Button();
            btn.Name = "btn" + Name;
            btn.Foreground = Styles.lightgray;
            btn.Height = 30;
            btn.Width = 127;

            btn.HorizontalAlignment = HorizontalAlignment.Left;
            btn.VerticalAlignment = VerticalAlignment.Top;
            btn.Content = Name;
            btn.FontSize = 12;
            btn.Template = Styles.templ;
            Binding binding1 = new Binding();
            binding1.Source = obj;
            btn.SetBinding(Control.OpacityProperty, binding1);

            return btn;
        }
        public static DropShadowEffect create_shadow()
        {
            DropShadowEffect dropShadow = new DropShadowEffect();
            dropShadow.Color = Color.FromArgb(100, 48, 47, 47);
            dropShadow.BlurRadius = 2;
            dropShadow.Direction = 270;
            dropShadow.Opacity = 0.15;
            return dropShadow;
        }
        public static Label create_lbl(string Name,string content)
        {

            Label lbl = new Label();
            lbl.Name = "lbl" + Name;
            lbl.Height = 21;
            lbl.Width = 23;
            lbl.HorizontalAlignment = HorizontalAlignment.Left;
            lbl.VerticalAlignment = VerticalAlignment.Top;
            Thickness margin = lbl.Margin;
            margin.Left = 10;
            margin.Top= 4;
            lbl.Margin = margin;
            Thickness pad = lbl.Padding;
            pad.Bottom = 0;
            pad.Left = 0;
            pad.Right = 0;
            pad.Top = 0;
            lbl.Padding = pad;
            lbl.FontFamily = new FontFamily("Font Awesome 5 Pro Regular");
            lbl.Content = content;
            lbl.Foreground = Styles.lightgray;
            lbl.FontSize = 20;
            return lbl;
        }

        public static Label create_date_history_lbl( string content)
        {
            Label lbl = new Label();
            lbl.HorizontalAlignment = HorizontalAlignment.Left;
            lbl.VerticalAlignment = VerticalAlignment.Top;
            Thickness margin = lbl.Margin;
            margin.Left = 10;
            margin.Top = 4;
            lbl.Margin = margin;
            Thickness pad = lbl.Padding;
            pad.Bottom = 0;
            pad.Left = 0;
            pad.Right = 0;
            pad.Top = 0;
            lbl.Padding = pad;
            lbl.FontFamily = new FontFamily("Font Awesome 5 Pro Regular");
            lbl.Content = content;
            lbl.Foreground = Styles.lightgray;
            lbl.FontSize = 16;
            return lbl;
        }

        public static Label create_history_lbl(string content)
        {
            Label lbl = new Label();
            lbl.HorizontalAlignment = HorizontalAlignment.Left;
            lbl.VerticalAlignment = VerticalAlignment.Top;
            Thickness margin = lbl.Margin;
            margin.Left = 20;
            margin.Top = 4;
            lbl.Margin = margin;
            lbl.FontFamily = new FontFamily("Font Awesome 5 Pro Regular");
            lbl.Content = content;
            lbl.Foreground = Styles.lightgray;
            lbl.FontSize = 16;
            return lbl;
        }


        public static Ellipse create_ellipse(string Name)
        {
            Ellipse elipse = new Ellipse();
            elipse.Height = 10;
            elipse.Width = 10;
            elipse.Name = "elps" + Name;
            elipse.Stroke = Styles.darkgray;
            elipse.Fill = Styles.green;
            Thickness elipse_margin = elipse.Margin;
            elipse_margin.Left = 103;
            elipse_margin.Top = 10;
            elipse_margin.Right = 0;
            elipse_margin.Bottom = 10;
            elipse.Margin = elipse_margin;

            return elipse;
        }
    }
    class Coordinats
    {
        public int left;
        public int top;
        public Coordinats()
        {
        }
        public Coordinats(int left,int top)
        {
            this.left = left;
            this.top = top;
        }

      
    }
}
