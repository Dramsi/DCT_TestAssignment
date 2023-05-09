using System;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Controls;
using System.Windows;
using System.Collections.Generic;

namespace DCT_TestAssignment
{
    public class Controller
    {
        private async void SetAPICoinsToJSON()
        {
            HttpClient client = new HttpClient();
            HttpRequestMessage request = new HttpRequestMessage();
            request.RequestUri = new Uri("https://api.coincap.io/v2/assets");
            request.Method = HttpMethod.Get;
            request.Headers.Add("Accept", "application/json");
            HttpResponseMessage response = await client.SendAsync(request);
            HttpContent responseContent = response.Content;
            string data = await responseContent.ReadAsStringAsync();
            using (StreamWriter sw = new StreamWriter("coins.json", false))
                sw.WriteLine(data);
        }
        private Model GetAllCoinsFromJSON()
        {
            Model model = JsonConvert.DeserializeObject<Model>(File.ReadAllText("coins.json"));
            return model;
        }
        private void ShowCoinsInTable(Model model, ListView coinsList)
        {
            List<Coin> coins = model.data;
            coinsList.ItemsSource = coins;
        }
        public void Run(ListView coinsList)
        {
            SetAPICoinsToJSON();
            ShowCoinsInTable(GetAllCoinsFromJSON(), coinsList);
        }
    }
}
