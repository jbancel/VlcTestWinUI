using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using LibVLCSharp.Platforms.Windows;

namespace VlcTest
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Ui_MainGrid.Loaded += (s, e) =>
            {
                VideoView videoView = new();
                ((Grid)s).Children.Add(videoView);
            };
        }
    }
}

