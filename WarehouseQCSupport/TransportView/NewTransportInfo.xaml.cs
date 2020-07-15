using System;
using SQLite;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using WarehouseQCSupport.Model;

namespace WarehouseQCSupport.TransportView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewTransportInfo : ContentPage
    {
        public NewTransportInfo()
        {
            InitializeComponent();
        }

        private void CancelBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        private void AddBtn_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(storeNo.Text) || string.IsNullOrEmpty(storeName.Text) || string.IsNullOrEmpty(lanes.Text) || string.IsNullOrEmpty(whSize.Text))
                App.Current.MainPage.DisplayAlert("Empty Values", "Please enter all values", "OK");
            else
            {
                SQLiteConnection conn = new SQLiteConnection(App.DbLocation);
                conn.CreateTable<Transport>();

                Transport transport = new Transport();
                transport.StoreNo = int.Parse(storeNo.Text);
                transport.StoreName = storeName.Text;
                transport.Lanes = lanes.Text;
                transport.VegCount = int.Parse(vegCount.Text);
                transport.Total = int.Parse(total.Text);
                transport.WHSize = int.Parse(whSize.Text);

                int rows = 0;
                try
                {
                    rows = conn.Insert(transport);
                    conn.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                if (rows > 0)
                {
                    DisplayAlert("Success", "Transport Info added", "Ok");
                    //App.Current.MainPage.DisplayAlert("Success", "New Expense added", "Ok");
                    App.Current.MainPage.Navigation.PushAsync(new TransportPage());
                }
                else
                {
                    DisplayAlert("OOps!!!", "There was a problem. Please try again", "ERROR");
                }


            }
        }
    }
}