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

namespace Snake
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const int SnakeSquareSize = 20;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            DrawGameArea();
        }
        private void DrawGameArea()
        {
            int NextX = 0, NextY = 0;
            for (int i = 0; i < Game_Area.ActualHeight / SnakeSquareSize; i++)
            {
                for (int j = 0; j < Game_Area.ActualWidth / SnakeSquareSize; j++)
                {
                    Rectangle NewRect = new Rectangle { Width = SnakeSquareSize, Height = SnakeSquareSize, Fill = (i + j) % 2 == 0 ? Brushes.White : Brushes.Black };
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                    Game_Area.Children.Add(NewRect);
                    Canvas.SetTop(NewRect, NextY);
                    Canvas.SetLeft(NewRect, NextX);
                    NextX += SnakeSquareSize;
                }
                NextY += SnakeSquareSize;
                NextX = 0;
            }

        }
    }
}
