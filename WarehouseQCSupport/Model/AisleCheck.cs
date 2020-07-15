using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseQCSupport.Model
{
    class AisleCheck
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string WAMASArea { get; set; }
        public int StoreNo { get; set; }
        public string Lanes { get; set; }
        public int Errors { get; set; }
        public string Comment { get; set; }
    }
}
