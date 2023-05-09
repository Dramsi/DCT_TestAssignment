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
        }
    }
}
