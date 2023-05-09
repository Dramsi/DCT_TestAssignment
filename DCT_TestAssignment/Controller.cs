using System;
using System.Net.Http;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Controls;

namespace DCT_TestAssignment
{
    public class Controller
    {
        private async void SetCoinsJSON()
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
        private Model GetCoins()
        {
            Model model = JsonConvert.DeserializeObject<Model>(File.ReadAllText("coins.json"));
            return model;
        }
        private void ShowData(Model model, ListBox coinsList)
        {
            foreach (var coin in model.data)
            {
                if (Convert.ToInt32(coin.rank) <= 10)
                    coinsList.Items.Add(coin.name);
            }
            /*for (int i = 1; i <= 10; i++)
            {
                coinsList.Items.Add(model.data[i].name);
            }*/
        }
        public void Run(ListBox coinsList)
        {
            SetCoinsJSON();
            ShowData(GetCoins(), coinsList);
        }
    }
}
