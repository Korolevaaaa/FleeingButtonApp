using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace RunawayButtonApp
{
    public partial class MainWindow : Window
    {
        private Random random = new Random();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RunawayButton_MouseEnter(object sender, MouseEventArgs e)
        {
            // Получаем текущие координаты кнопки
            var button = sender as Button;
            double buttonWidth = button.ActualWidth;
            double buttonHeight = button.ActualHeight;

            // Получаем размеры окна
            double windowWidth = this.ActualWidth;
            double windowHeight = this.ActualHeight;

            // Генерируем новые координаты для кнопки
            double newLeft = random.Next(0, (int)(windowWidth - buttonWidth));
            double newTop = random.Next(0, (int)(windowHeight - buttonHeight));

            // Смещаем кнопку
            Canvas.SetLeft(button, newLeft);
            Canvas.SetTop(button, newTop);
        }
    }
}
