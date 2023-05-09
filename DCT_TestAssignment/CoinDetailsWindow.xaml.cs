using System.Windows;

namespace DCT_TestAssignment
{
    /// <summary>
    /// Interaction logic for CoinDetailsWindow.xaml
    /// </summary>
    public partial class CoinDetailsWindow : Window
    {
        public CoinDetailsWindow(Coin coin)
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
        }
    }
}
