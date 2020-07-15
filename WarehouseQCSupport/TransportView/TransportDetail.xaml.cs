using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseQCSupport.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace WarehouseQCSupport.TransportView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TransportDetail : ContentPage
    {
        int _id;
        private Transport mytrp;
        private SQLiteConnection conn;
        public TransportDetail(int id)
        {
            InitializeComponent();
            _id = id;

            conn = new SQLiteConnection(App.DbLocation);
            conn.CreateTable<Transport>();
            var transports = conn.Table<Transport>().ToList();
            conn.Close();

            var trp = (from t in transports
                       where t.Id == _id
                       select t).FirstOrDefault();

            mytrp = new Transport();
            mytrp.Id = trp.Id;
            mytrp.StoreName = trp.StoreName;
            mytrp.StoreNo = trp.StoreNo;
            mytrp.Lanes = trp.Lanes;
            mytrp.VegCount = trp.VegCount;
            mytrp.Total = trp.Total;
            mytrp.WHSize = trp.WHSize;

            storeId.Text = mytrp.Id.ToString();
            name.Text = mytrp.StoreName;
            storeNo.Text = mytrp.StoreNo.ToString();
            lanes.Text = mytrp.Lanes;
            vegCount.Text = mytrp.VegCount.ToString();
            total.Text = mytrp.Total.ToString();
            whSize.Text = mytrp.WHSize.ToString();
        }

        private void edit_Clicked(object sender, EventArgs e)
        {

        }

        private void delete_Clicked(object sender, EventArgs e)
        {
            try
            {
                SQLiteConnection conn = new SQLiteConnection(App.DbLocation);
                conn.CreateTable<Transport>();
                conn.Table<Transport>().Delete(trp => trp.Id == _id);
                conn.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            Navigation.PopAsync();
        }
    }
}