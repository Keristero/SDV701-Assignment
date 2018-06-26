using Newtonsoft.Json;
using RestSharp;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace SDV701AdminApplication {

    public class ClsDBConnector {

        private static string _databaseUrl = "https://veggiestall-database-keristero.c9users.io";

        public static readonly ClsDBConnector Instance = new ClsDBConnector();

        private ClsDBConnector() {}

        public async static Task<ClsDBResponse> RequestAsync(string pPath, Method pRequestType, string pKey, dynamic pValue) {
            //Use RestSharp to send a request containing body data to api
            var client = new RestClient(_databaseUrl);
            var request = new RestRequest(pPath, pRequestType);
            var cancellationTokenSource = new CancellationTokenSource();
            request.AddParameter("key", JsonConvert.SerializeObject(pKey));
            request.AddParameter("value", JsonConvert.SerializeObject(pValue));

            var restResponse = await client.ExecuteTaskAsync(request, cancellationTokenSource.Token);
            //IRestResponse response = client.Execute(request);
            Console.WriteLine("Got response!");
            //Deserialize the response object
            ClsDBResponse dbResponse = JsonConvert.DeserializeObject<ClsDBResponse>(restResponse.Content);
            //Reseriazlie the data object in order to deserialize it as the correct class later.
            dbResponse.jsonData = JsonConvert.SerializeObject(dbResponse.data);
            Console.WriteLine(dbResponse.message);
            return dbResponse;
        }

        public async static Task<ClsDBResponse> GetDataAsync(string pPath) {
            Console.WriteLine("GET: " + pPath);
            ClsDBResponse dbResponse = await ClsDBConnector.RequestAsync(pPath, Method.GET, "", "");
            return dbResponse;
        }

        public async static Task<ClsDBResponse> PostDataAsync(string pPath, string pKey, dynamic pValue) {
            Console.WriteLine("POST: " + pPath + " key: " + pKey + " value: " + pValue);
            ClsDBResponse dbResponse = await ClsDBConnector.RequestAsync(pPath, Method.POST, pKey, pValue);
            return dbResponse;
        }

        public async static Task<ClsDBResponse> DeleteDataAsync(string pPath, string pKey, dynamic pValue) {
            //I spent a hour or more trying to use the DELETE request to delete on the database, but apparently the DELETE request does not support body variables
            //So for the sake of not redoing the a large part of the API, im using PATCH
            Console.WriteLine("DELETE: " + pPath + " key: " + pKey + " value: " + pValue);
            ClsDBResponse dbResponse = await ClsDBConnector.RequestAsync(pPath, Method.PATCH, pKey, pValue);
            return dbResponse;
        }

        public async static Task<ClsDBResponse> PutDataAsync(string pPath, string pKey, dynamic pValue) {
            Console.WriteLine("PUT: " + pPath + " key: " + pKey + " value: " + pValue);
            ClsDBResponse dbResponse = await ClsDBConnector.RequestAsync(pPath, Method.PUT, pKey, pValue);
            return dbResponse;
        }

    }
}
