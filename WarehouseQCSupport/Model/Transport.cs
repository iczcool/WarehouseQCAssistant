using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace WarehouseQCSupport.Model
{
    public class Transport:INotifyPropertyChanged
    {
        
        private int id;
        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged("Id");
            }
        }

        private int storeNo;
        public int StoreNo
        {
            get { return storeNo; }
            set
            {
                storeNo = value;
                OnPropertyChanged("StoreNo");
            }
        }

        private string storeName;
        public string StoreName
        {
            get { return storeName; }
            set
            {
                storeName = value;
                OnPropertyChanged("StoreName");
            }
        }


        private string lanes;
        public string Lanes
        {
            get { return lanes; }
            set
            {
                lanes = value;
                OnPropertyChanged("Lanes");
            }
        }

        private int vegCount;
        public int VegCount
        {
            get { return vegCount; }
            set
            {
                vegCount = value;
                OnPropertyChanged("VegCount");
            }
        }

        private int total;
        public int Total
        {
            get { return total; }
            set
            {
                total = value;
                OnPropertyChanged("Total");
            }
        }

        private int whSize;
        public int WHSize
        {
            get { return whSize; }
            set
            {
                whSize = value;
                OnPropertyChanged("WHSize");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(
        [CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,
            new PropertyChangedEventArgs(propertyName));
        }
    }
}
