using System;
using System.Collections.Generic;

namespace SDV701AdminApplication {
    public class ClsSale : ClsDBClass{
        private float total;
        private DateTime date;
        public Dictionary<string, ClsSold> Sold = new Dictionary<string, ClsSold>();

        //Properties visable on Data grid view
        public float Total { get => total; set => total = value; }
        public DateTime Date { get => date; set => date = value; }
    }
}
