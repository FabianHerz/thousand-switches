using System;

using System.Windows;
using System.Windows.Controls;

using System.Windows.Input;

using System.Windows.Media.Animation;
using System.Windows.Shapes;

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
        public static void transponent(FrameworkElement element, int fromx,int fromy,int tox,int toy,Canvas canvas) 
        {
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = fromx;
            myDoubleAnimation.To = tox;
            myDoubleAnimation.Duration =
                new Duration(TimeSpan.FromMilliseconds(800));
            myDoubleAnimation.AutoReverse = false;
            Storyboard.SetTargetProperty(myDoubleAnimation,
                new PropertyPath(Canvas.LeftProperty));
            Storyboard myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);

            DoubleAnimation myDoubleAnimation1 = new DoubleAnimation();
            myDoubleAnimation1.From = fromy;
            myDoubleAnimation1.To = toy;
            myDoubleAnimation1.Duration =
                new Duration(TimeSpan.FromMilliseconds(800));
            myDoubleAnimation1.AutoReverse = false;
            Storyboard.SetTargetProperty(myDoubleAnimation1,
                new PropertyPath(Canvas.TopProperty));
            myStoryboard.Children.Add(myDoubleAnimation1);
            myStoryboard.Begin(element);
  
           // opacity(element, 0.5, 1.0);
        }
        public static void animate_lines(int fromx, int fromy, int tox, int toy,Line line)
        {
            //canvas.FindName();
            //animate_lines(fromx, fromy, tox, toy,);
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
                myDoubleAnimation.From = fromx;
                myDoubleAnimation.To = tox;
                myDoubleAnimation.Duration =
                    new Duration(TimeSpan.FromMilliseconds(800));
                myDoubleAnimation.AutoReverse = false;
                Storyboard.SetTargetProperty(myDoubleAnimation,
                    new PropertyPath(Line.X2Property));
                Storyboard myStoryboard = new Storyboard();
                myStoryboard.Children.Add(myDoubleAnimation);

                DoubleAnimation myDoubleAnimation1 = new DoubleAnimation();
                myDoubleAnimation1.From = fromy;
                myDoubleAnimation1.To = toy;
                myDoubleAnimation1.Duration =
                    new Duration(TimeSpan.FromMilliseconds(800));
                myDoubleAnimation1.AutoReverse = false;
                Storyboard.SetTargetProperty(myDoubleAnimation1,
                    new PropertyPath(Line.Y2Property));
                myStoryboard.Children.Add(myDoubleAnimation1);
                myStoryboard.Begin(line);
            
        }
        public static void opacity(FrameworkElement element, double from, double to)
        {
            DoubleAnimation myDoubleAnimation = new DoubleAnimation();
            myDoubleAnimation.From = from;
            myDoubleAnimation.To = to;
            myDoubleAnimation.Duration =
                new Duration(TimeSpan.FromMilliseconds(800));
            myDoubleAnimation.AutoReverse = false;
            Storyboard.SetTargetProperty(myDoubleAnimation,
                new PropertyPath(Control.OpacityProperty));
            Storyboard myStoryboard = new Storyboard();
            myStoryboard.Children.Add(myDoubleAnimation);
            myStoryboard.Begin(element);

        }
    }
}
