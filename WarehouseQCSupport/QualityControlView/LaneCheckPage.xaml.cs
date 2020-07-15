using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseQCSupport.QualityControlView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LaneCheckPage : ContentPage
    {
        public LaneCheckPage()
        {
            InitializeComponent();
        }

        
        private void aisle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new QualityCheckTabPage());
        }
    }
}