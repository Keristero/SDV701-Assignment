
namespace SDV701AdminApplication {
    public class ClsSold : ClsDBClass {
        public string ProductUID;
        private string _type;
        private double _price;
        private double _quantity;

        //Properties visable on Data grid view
        public string Product {
            get {
                string productName = "deleted";
                if (ClsDataManager.Products.ContainsKey(this.ProductUID)) {
                    productName = ClsDataManager.Products[this.ProductUID].Name;
                }
                return productName;
            }
        }
        public string Type { get => _type; set => _type = value; }
        public double Price { get => _price; set => _price = value; }
        public double Quantity { get => _quantity; set => _quantity = value; }
    }
}
