using System;

using System.Windows;
using System.Windows.Controls;

using System.Windows.Input;

using System.Windows.Media.Animation;

namespace thousand_switches
{
    class ServicesAnimation
    {
        public static void up_and_show(FrameworkElement element, int from, int to)
        {
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = from;
            myDoubleAnimation.To = to;
            myDoubleAnimation.Duration =
                new Duration(TimeSpan.FromMilliseconds(500));
            myDoubleAnimation.AutoReverse = false;
            Storyboard.SetTargetProperty(myDoubleAnimation,
                new PropertyPath(Canvas.TopProperty));
            Storyboard myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            myStoryboard.Begin(element);

        }
        public static void opacity(FrameworkElement element, double from, double to)
        {
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = from;
            myDoubleAnimation.To = to;
            myDoubleAnimation.Duration =
                new Duration(TimeSpan.FromMilliseconds(500));
            myDoubleAnimation.AutoReverse = false;
            Storyboard.SetTargetProperty(myDoubleAnimation,
                new PropertyPath(Control.OpacityProperty));
            Storyboard myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            myStoryboard.Begin(element);

        }
    }
}
