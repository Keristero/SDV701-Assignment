using System;

namespace SDV701AdminApplication {
    [Serializable]
    public class ClsNotice : ClsDBClass{

        private DateTime _date;
        private string _text;

        //Properties visable on Data grid view
        public DateTime Date { get => _date; set => _date = value; }
        public string Text { get => _text; set => _text = value; }

        public ClsNotice(string pText) {
            Text = pText;
            Date = DateTime.Now;
        }
    }
}
