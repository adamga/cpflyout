using System;
using System.Windows;
using System.Windows.Input;

namespace cpflyout
{
    public partial class MainWindow : Window
    {
        private FlyoutWindow flyoutWindow;

        public MainWindow()
        {
            InitializeComponent();
            flyoutWindow = new FlyoutWindow();
        }

        private void MainGrid_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!flyoutWindow.IsVisible)
            {
                flyoutWindow.Show();
                flyoutWindow.Left = this.Left + this.Width;
                flyoutWindow.Top = this.Top;
                flyoutWindow.Height = this.Height;
            }
        }

        private void MainGrid_MouseLeave(object sender, MouseEventArgs e)
        {
            if (flyoutWindow.IsVisible)
            {
                flyoutWindow.Hide();
            }
        }
    }
}
