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
        private void Show10CoinsInTable(Model model, ListView coinsList)
        {
            List<Coin> tenCoins = new List<Coin>();
            List<Coin> allCoins = model.data;
            for (int i = 0; i < 10; i++)
            {
                tenCoins.Add(allCoins[i]);
            }
            coinsList.ItemsSource = tenCoins;
        }
        public void Run(ListView coinsList)
        {
            SetAPICoinsToJSON();
            Show10CoinsInTable(GetAllCoinsFromJSON(), coinsList);
        }
    }
}
