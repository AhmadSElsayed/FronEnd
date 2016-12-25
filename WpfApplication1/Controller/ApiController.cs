using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1.Controller
{

    static public class ApiController
    {
        public static string ApiPath = "http://SamehIsAwesome.azurewebsites.net/api/";

        public static async Task<List<T>> Get<T>(string Controller, params KeyValuePair<string, object>[] Paramaters)
        {   
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            var response = await client.GetStringAsync(Path(Controller, Paramaters));
            return JsonConvert.DeserializeObject<List<T>>(response);           
        }
        public static async Task<string> Post<T>(string Controller, T obj, params KeyValuePair<string, object>[] Paramaters)
        {

            var content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            var response = await client.PostAsync(Path(Controller,Paramaters), content);
            if (response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                return message;
            }
            else
                throw new Exception("Request Failure");

        }
        public static async Task<string> Put<T>(string Controller, T obj, params KeyValuePair<string, object>[] Paramaters)
        {

            var content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            var response = await client.PutAsync(Path(Controller, Paramaters), content);
            if (response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                return message;
            }
            else
                throw new Exception("Request Failure");

        }
        public static async Task<string> Delete<T>(string Controller, params KeyValuePair<string, object>[] Paramaters)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            var response = await client.DeleteAsync(Path(Controller, Paramaters));
            if (response.IsSuccessStatusCode)
            {
                var message = await response.Content.ReadAsStringAsync();
                return message;
            }
            else
                throw new Exception("Request Failure");

        }
        private static string Path(string Controller, params KeyValuePair<string, object>[] Paramaters)
        {
            string s = Controller;
            if (Paramaters.Length != 0)
            {
                s += "?";
                foreach (var item in Paramaters)
                {
                    s += item.Key + "=" + item.Value.ToString() + "&";
                }
                s = s.Remove(s.Length - 1);
            }
            return ApiPath + s;
        }
    }
}
