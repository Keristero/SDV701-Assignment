using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SDV701AdminApplication {
    public class ClsDataManager {
        public static readonly ClsDataManager Instance = new ClsDataManager();

        private static Dictionary<string, ClsProduct> _products;
        private static Dictionary<string, ClsProductGroup> _productGroups;
        private static Dictionary<string, ClsSale> _sales;
        private static Dictionary<string, ClsNotice> _notices;

        public static Dictionary<string, ClsProduct> Products { get => _products; }
        public static Dictionary<string, ClsProductGroup> ProductGroups { get => _productGroups; }
        public static Dictionary<string, ClsSale> Sales { get => _sales; }
        public static Dictionary<string, ClsNotice> Notices { get => _notices; }

        private ClsDataManager() {}

        public static async Task GetAllData() {
            Task task1 = GetProducts();
            Task task2 = GetProductGroups();
            Task task3 = GetSales();
            Task task4 = GetNotices();
            await Task.WhenAll(task1, task2, task3, task4);
            Console.WriteLine("allll done");
        }

        //Get data
        public static async Task GetProducts() {
            ClsDBResponse dbres = await ClsDBConnector.GetDataAsync("/products");
            _products = JsonConvert.DeserializeObject<Dictionary<string, ClsProduct>>(dbres.jsonData);
        }
        public static async Task GetProductGroups() {
            ClsDBResponse dbres = await ClsDBConnector.GetDataAsync("/productGroups");
            _productGroups = JsonConvert.DeserializeObject<Dictionary<string, ClsProductGroup>>(dbres.jsonData);
        }
        public static async Task GetNotices() {
            ClsDBResponse dbres = await ClsDBConnector.GetDataAsync("/notices");
            _notices = JsonConvert.DeserializeObject<Dictionary<string, ClsNotice>>(dbres.jsonData);
        }
        public static async Task GetSales() {
            ClsDBResponse dbres = await ClsDBConnector.GetDataAsync("/sales");
            _sales = JsonConvert.DeserializeObject<Dictionary<string, ClsSale>>(dbres.jsonData);
        }

        //Set data
        public static async void SetProduct(ClsProduct pProduct) {
            if (_products.ContainsKey(pProduct.UID)) {
                _products[pProduct.UID] = pProduct;
            } else {
                _products.Add(pProduct.UID, pProduct);
            }
            ClsDBResponse dbres = await ClsDBConnector.PutDataAsync("/products", pProduct.UID, pProduct);
        }
        public static async void SetProductGroup(ClsProductGroup pProductGroup) {
            if (_productGroups.ContainsKey(pProductGroup.UID)) {
                _productGroups[pProductGroup.UID] = pProductGroup;
            } else {
                _productGroups.Add(pProductGroup.UID, pProductGroup);
            }
            ClsDBResponse dbres = await ClsDBConnector.PutDataAsync("/productGroups", pProductGroup.UID, pProductGroup);
        }
        public static async void SetNotice(ClsNotice pNotice) {
            if (_notices.ContainsKey(pNotice.UID)) {
                _notices[pNotice.UID] = pNotice;
            } else {
                _notices.Add(pNotice.UID, pNotice);
            }
            ClsDBResponse dbres = await ClsDBConnector.PutDataAsync("/notices", pNotice.UID, pNotice);
        }

        //Delete data
        public static async void DeleteProduct(ClsProduct pProduct) {
            _products.Remove(pProduct.UID);
            ClsDBResponse dbres = await ClsDBConnector.DeleteDataAsync("/products", pProduct.UID, pProduct);
        }
        public static async void DeleteProductGroup(ClsProductGroup pProductGroup) {
            _productGroups.Remove(pProductGroup.UID);
            ClsDBResponse dbres = await ClsDBConnector.DeleteDataAsync("/productGroups", pProductGroup.UID, pProductGroup);
        }
        public static async void DeleteNotice(ClsNotice pNotice) {
            _notices.Remove(pNotice.UID);
            ClsDBResponse dbres = await ClsDBConnector.DeleteDataAsync("/notices", pNotice.UID, pNotice);
        }
        public static async void DeleteSale(ClsSale pSale) {
            _sales.Remove(pSale.UID);
            ClsDBResponse dbres = await ClsDBConnector.DeleteDataAsync("/sales", pSale.UID, pSale);
        }
    }
}
