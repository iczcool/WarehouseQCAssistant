using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseQCSupport.Model;
using WarehouseQCSupport.TransportView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseQCSupport
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransportPage : ContentPage
    {
        public TransportPage()
        {
            InitializeComponent();
            BindingContext = new Transport();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            SQLiteConnection conn = new SQLiteConnection(App.DbLocation);
            conn.CreateTable<Transport>();
            var transport = conn.Table<Transport>().ToList();
            conn.Close();

            transportListView.ItemsSource = transport;
        }

        private void NewTransportBtn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewTransportInfo());
        }

        private void detail_Clicked(object sender, EventArgs e)
        {
            int myId;
            var buttonClickedHandler = (Button)sender;
            Grid parentGrid = (Grid)buttonClickedHandler.Parent;
            Label idLabel = (Label)parentGrid.Children[0];
            myId = int.Parse(idLabel.Text);
            Navigation.PushAsync(new TransportDetail(myId));
        }

        private void DeleteMe_Clicked(object sender, EventArgs e)
        {
            int myId;
            var buttonClickedHandler = (Button)sender;
            Grid parentGrid = (Grid)buttonClickedHandler.Parent;
            Label idLabel = (Label)parentGrid.Children[0];
            myId = int.Parse(idLabel.Text);

            SQLiteConnection conn = new SQLiteConnection(App.DbLocation);
            conn.CreateTable<Transport>();
            conn.Table<Transport>().Delete(trp => trp.Id == 0);
        }
    }
}