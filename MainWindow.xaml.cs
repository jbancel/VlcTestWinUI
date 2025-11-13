using System;
using Microsoft.UI.Xaml;
using LibVLCSharp.Shared;
using LibVLCSharp.Platforms.Windows;

namespace VlcTest
{
    public sealed partial class MainWindow : Window
    {
        LibVLC libvlc;
        MediaPlayer mp;

        public MainWindow()
        {
            InitializeComponent();
            VideoView.Initialized += VideoView_Initialized;
        }

        private void VideoView_Initialized(object sender, InitializedEventArgs e)
        {
            libvlc = new LibVLC(enableDebugLogs: true, e.SwapChainOptions);
            mp = new MediaPlayer(libvlc);
            using var media = new Media(libvlc, new Uri("http://commondatastorage.googleapis.com/gtv-videos-bucket/sample/BigBuckBunny.mp4"));
            mp.Play(media);
        }
    }
}

