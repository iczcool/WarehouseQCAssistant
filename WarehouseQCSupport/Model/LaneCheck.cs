using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseQCSupport.Model
{
    public class LaneCheck
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int StoreNo { get; set; }
        public string CorrectLane { get; set; }
        public string CorrectLabels { get; set; }
        public string PickedFlow { get; set; }
        public string Height { get; set; }
        public string Wrap { get; set; }
        public string Stability { get; set; }
        public string StockQuality { get; set; }
        public string CorrectPallet { get; set; }

    }
}
