﻿using Windows.UI.Xaml.Controls;
using FTDISample.Serial;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FTDISample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            //var serialDeviceManager = new SerialDeviceManager();
            var serialDeviceManager = new FtdiSerialDeviceManager();
            DataContext = new FtdiSampleViewModel(serialDeviceManager);
        }
    }
}
