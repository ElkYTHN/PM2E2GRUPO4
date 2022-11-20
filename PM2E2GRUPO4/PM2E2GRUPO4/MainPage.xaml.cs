using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PM2E2GRUPO4
{

    public partial class MainPage : ContentPage
    {
        byte[] Image;
        private AudioRecorderService audioRecorderService = new AudioRecorderService()
        {
            StopRecordingOnSilence = false,
            StopRecordingAfterTimeout = false
        };

        private AudioPlayer audioPlayer = new AudioPlayer();

        private bool reproducir = false;
        MediaFile FileFoto = null;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
