using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DCT_TestAssignment
{
    public partial class CoinConverterWindow : Window
    {
        string firstCoin = null;
        string secondCoin = null;
        List<Coin> coins = new List<Coin>();
        public CoinConverterWindow(Model model, bool theme)
        {
            InitializeComponent();
            new Controller().ShowCoins(comboBoxCoin1);
            new Controller().ShowCoins(comboBoxCoin2);
            coins = model.data;
            if (!theme)
            {
                this.Background = Brushes.Black;
                labelCoin1.Foreground = Brushes.White;
                labelCoin2.Foreground = Brushes.White;
                labelResult.Foreground = Brushes.White;
                textBoxCoin1.Foreground = Brushes.White;
                textBoxCoin1.Background = Brushes.Gray;
                textBoxResult.Foreground = Brushes.White;
                textBoxResult.Background = Brushes.Gray;
            }
        }
        private void comboBoxCoin1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            firstCoin = comboBoxCoin1.SelectedValue.ToString();
        }
        private void comboBoxCoin2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            secondCoin = comboBoxCoin2.SelectedValue.ToString();
        }
        private void convertButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (firstCoin != null && secondCoin != null && Convert.ToDouble(textBoxCoin1.Text) != 0)
                {
                    string priceCoin1 = null;
                    string priceCoin2 = null;
                    foreach (Coin coin in coins)
                    {
                        if (coin.name == firstCoin)
                            priceCoin1 = coin.priceUsd.Replace('.', ',');
                        if (coin.name == secondCoin)
                            priceCoin2 = coin.priceUsd.Replace('.', ',');
                    }
                    if (priceCoin1 != null && priceCoin2 != null)
                    {
                        decimal result = Convert.ToDecimal(priceCoin1) * Convert.ToDecimal(textBoxCoin1.Text) / Convert.ToDecimal(priceCoin2);
                        textBoxResult.Text = result.ToString();
                    }
                }
                else
                {
                    textBoxResult.Text = "You must select both coins to convert.";
                }
            }
            catch (Exception ex)
            {
                textBoxResult.Text = ex.Message;
            }
        }
    }
}
