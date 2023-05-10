using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace DCT_TestAssignment
{
    public partial class CoinDetailsWindow : Window
    {
        public CoinDetailsWindow(Coin coin, bool theme)
        {
            InitializeComponent();
            nameTextBox.Text = coin.name;
            rankTextBox.Text = coin.rank;
            symbolTextBox.Text = coin.symbol;
            supplyTextBox.Text = coin.supply;
            maxSupplyTextBox.Text = coin.maxSupply;
            marketCapUsdTextBox.Text = coin.marketCapUsd;
            volumeUsd24HrTextBox.Text = coin.volumeUsd24Hr;
            priceUsdTextBox.Text = coin.priceUsd;
            changePercent24HrTextBox.Text = coin.changePercent24Hr;
            vwap24HrTextBox.Text = coin.vwap24Hr;
            explorerTextBox.Text = coin.explorer;
            if (!theme)
            {
                this.Background = Brushes.Black;
                Style styleBlack = new Style();
                styleBlack.Setters.Add(new Setter { Property = Control.BackgroundProperty, Value = new SolidColorBrush(Colors.Black) });
                styleBlack.Setters.Add(new Setter { Property = Control.ForegroundProperty, Value = new SolidColorBrush(Colors.White) });
                Style styleGrey = new Style();
                styleGrey.Setters.Add(new Setter { Property = Control.BackgroundProperty, Value = new SolidColorBrush(Colors.Gray) });
                styleGrey.Setters.Add(new Setter { Property = Control.ForegroundProperty, Value = new SolidColorBrush(Colors.White) });
                foreach (FrameworkElement label in stackPanel.Children)
                {
                    if (label is Label)
                    {
                        Label labelThis = (Label)label;
                        labelThis.Style = styleBlack;
                    }
                }
                foreach (FrameworkElement textBox in stackPanel.Children)
                {
                    if (textBox is TextBox)
                    {
                        TextBox textBoxThis = (TextBox)textBox;
                        textBoxThis.Style = styleGrey;
                    }
                }
            }
        }
    }
}
