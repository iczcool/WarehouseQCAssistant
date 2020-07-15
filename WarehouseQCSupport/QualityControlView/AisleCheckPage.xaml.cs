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
    public partial class AisleCheckPage : ContentPage
    {
        public AisleCheckPage()
        {
            InitializeComponent();
        }

        private void readAisleData_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AisleDataPage());
        }
    }
}