using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace DCT_TestAssignment
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Controller().Run(coinsList);

            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(coinsList.ItemsSource);
            view.Filter = UserFilter;
        }
        private bool UserFilter(object item)
        {
            if (String.IsNullOrEmpty(searchFilter.Text))
                return true;
            else
                return ((item as Coin).name.IndexOf(searchFilter.Text, StringComparison.OrdinalIgnoreCase) >= 0);
        }

        private void searchFilter_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(coinsList.ItemsSource).Refresh();
        }

        private void coinsList_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Coin selectedCoin = coinsList.SelectedItem as Coin;
            if (selectedCoin != null)
            {
                CoinDetailsWindow coinDetailsWindow = new CoinDetailsWindow(selectedCoin);
                coinDetailsWindow.ShowDialog();
            }
        }
    }
}
