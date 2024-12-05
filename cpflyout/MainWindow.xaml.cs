using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System;
using System.Configuration;
using System.Windows.Media.Animation;

namespace cpflyout;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
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
        string url = "file://c:/repos/simple.html";
        WebBrowser webBrowser = new WebBrowser();   
        webBrowser.Source = new Uri(url);
        webBrowser.Visibility = Visibility.Visible;
        
        

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