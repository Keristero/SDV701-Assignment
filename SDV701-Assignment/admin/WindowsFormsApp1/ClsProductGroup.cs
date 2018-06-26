using System;
using System.Collections.Generic;

namespace SDV701AdminApplication {
    [Serializable]
    public class ClsProductGroup : ClsDBClass{

        private string name;

        public List<string> ProductUIDs = new List<string>();

        //Properties visable on Data grid view
        public string Name { get => name; set => name = value; }
        public ClsProductGroup(string pName) {
            name = pName;
        }
    }
}
