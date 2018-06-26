using System;
using System.Collections.Generic;

namespace SDV701AdminApplication {
    [Serializable]
    public class ClsProduct : ClsDBClass{

        private DateTime _lastModified;

        //Properties visable on Data grid view
        public string Name { get; set; }
        public DateTime LastModified { get => _lastModified; set => _lastModified = value; }
        public bool InStock { get; set; }
        public Dictionary<string, ClsPrice> Prices { get; set; } = new Dictionary<string, ClsPrice>();

        public void UpdateLastModified() {
            _lastModified = DateTime.Now;
        }
    }
}
