using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseQCSupport.QualityControlView;
using Xamarin.Forms;

namespace WarehouseQCSupport
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void transport_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TransportPage());
        }

        private void quality_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QualityCheckTabPage());
        }
    }
}
