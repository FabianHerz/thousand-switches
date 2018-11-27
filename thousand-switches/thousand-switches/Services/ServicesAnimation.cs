using System;

using System.Windows;
using System.Windows.Controls;

using System.Windows.Input;

using System.Windows.Media.Animation;

namespace thousand_switches
{
    class ServicesAnimation
    {
        public static void up_and_show(FrameworkElement element, int from, int to,object propery,int duration)
        {
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = from;
            myDoubleAnimation.To = to;
            myDoubleAnimation.Duration =
                new Duration(TimeSpan.FromMilliseconds(duration));//500
            myDoubleAnimation.AutoReverse = false;
            Storyboard.SetTargetProperty(myDoubleAnimation,
                new PropertyPath(propery));
            Storyboard myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            myStoryboard.Begin(element);

        }
        public static void up_and_show(FrameworkElement element, int from, int to, object propery, int duration, int beginTime)
        {
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = from;
            myDoubleAnimation.To = to;
            myDoubleAnimation.BeginTime = TimeSpan.FromMilliseconds(beginTime);

            myDoubleAnimation.Duration =
                new Duration(TimeSpan.FromMilliseconds(duration));//500
            myDoubleAnimation.AutoReverse = false;
            Storyboard.SetTargetProperty(myDoubleAnimation,
                new PropertyPath(propery));
            Storyboard myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            myStoryboard.Begin(element);

        }
        public static void opacity(FrameworkElement element, double from, double to,int duration)
        {
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
           
            myDoubleAnimation.From = from;
            myDoubleAnimation.To = to;

            myDoubleAnimation.Duration =
                new Duration(TimeSpan.FromMilliseconds(duration));
            myDoubleAnimation.AutoReverse = false;
            Storyboard.SetTargetProperty(myDoubleAnimation,
                new PropertyPath(Control.OpacityProperty));
            Storyboard myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            myStoryboard.Begin(element);

        }
        public static void opacity(FrameworkElement element, double from, double to, int duration,int beginTime)
        {
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();

            myDoubleAnimation.From = from;
            myDoubleAnimation.To = to;
            myDoubleAnimation.BeginTime = TimeSpan.FromMilliseconds(beginTime);
            myDoubleAnimation.Duration =
                new Duration(TimeSpan.FromMilliseconds(duration));
            myDoubleAnimation.AutoReverse = false;
            Storyboard.SetTargetProperty(myDoubleAnimation,
                new PropertyPath(Control.OpacityProperty));
            Storyboard myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            myStoryboard.Begin(element);

        }
        public static void show_add_grid(FrameworkElement element)
        {
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 0;
            myDoubleAnimation.To = 130;
            myDoubleAnimation.BeginTime = TimeSpan.FromMilliseconds(400);
            myDoubleAnimation.Duration =
                new Duration(TimeSpan.FromMilliseconds(400));
            myDoubleAnimation.AutoReverse = false;
            Storyboard.SetTargetProperty(myDoubleAnimation,
                new PropertyPath(Control.HeightProperty));
            Storyboard myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            myStoryboard.Begin(element);
        }

        public static void hide_add_grid(FrameworkElement element)
        {
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = 130;
            myDoubleAnimation.To = 0;
            myDoubleAnimation.Duration =
                new Duration(TimeSpan.FromMilliseconds(400));
            myDoubleAnimation.AutoReverse = false;
            Storyboard.SetTargetProperty(myDoubleAnimation,
                new PropertyPath(Control.HeightProperty));
            Storyboard myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            myStoryboard.Begin(element);
        }
    }
}
