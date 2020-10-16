using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.Geolocator;

namespace TPFinal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void GetPosition (object sender, EventArgs e)
        {
            var local = CrossGeolocator.Current;

            local.DesiredAccuracy = 40;

            var posicao = await local.GetPositionAsync(TimeSpan.FromSeconds(10));

            LogintudeLabel.Text = string.Format("{0:0.0000000}", posicao.Longitude);
            LatitudeLabel.Text = String.Format(" {0 : 0.0000000}", posicao.Latitude);
        
        }

    }
}
