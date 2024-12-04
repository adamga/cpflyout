using System;
using System.Configuration;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace cpflyout
{
    public partial class MainWindow : Window
    {
        private bool isMouseNearEdge = false;

        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
            this.MouseMove += MainWindow_MouseMove;
            this.SizeChanged += MainWindow_SizeChanged;
            this.DpiChanged += MainWindow_DpiChanged;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            string url = ConfigurationManager.AppSettings["BrowserUrl"];
            webBrowser.Source = new Uri(url);
        }

        private void MainWindow_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = e.GetPosition(this);
            if (mousePosition.X <= 10)
            {
                if (!isMouseNearEdge)
                {
                    isMouseNearEdge = true;
                    StartFlyoutAnimation();
                }
            }
            else
            {
                if (isMouseNearEdge)
                {
                    isMouseNearEdge = false;
                    StartFlyoutAnimation();
                }
            }
        }

        private void StartFlyoutAnimation()
        {
            Storyboard storyboard = (Storyboard)this.Resources["FlyoutStoryboard"];
            storyboard.Begin();
        }

        private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            // Handle window size changes if needed
        }

        private void MainWindow_DpiChanged(object sender, DpiChangedEventArgs e)
        {
            // Handle DPI changes if needed
        }
    }
}
