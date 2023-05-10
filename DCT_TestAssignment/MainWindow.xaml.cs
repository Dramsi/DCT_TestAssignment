using System;
using System.Windows;
using System.Windows.Controls;
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
            lightRadioButton.IsChecked = true;

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
                bool theme = lightRadioButton.IsChecked == true ? true : false;
                CoinDetailsWindow coinDetailsWindow = new CoinDetailsWindow(selectedCoin, theme);
                coinDetailsWindow.ShowDialog();
            }
        }
        private void converterButton_Click(object sender, RoutedEventArgs e)
        {

        }
        private void themeRadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if (lightRadioButton.IsChecked == true)
            {
                searchFilter.Background = Brushes.White;
                searchFilter.Foreground = Brushes.Black;
                this.Background = Brushes.White;
                searchLabel.Foreground = Brushes.Black;
                darkRadioButton.Foreground = Brushes.Black;
                lightRadioButton.Foreground = Brushes.Black;
                coinsList.Foreground = Brushes.Black;
                coinsList.Background = Brushes.White;
            }
            else if (darkRadioButton.IsChecked == true)
            {
                searchFilter.Background = Brushes.Gray;
                searchFilter.Foreground = Brushes.White;
                this.Background = Brushes.Black;
                searchLabel.Foreground = Brushes.White;
                lightRadioButton.Foreground = Brushes.White;
                darkRadioButton.Foreground = Brushes.White;
                coinsList.Foreground = Brushes.White;
                coinsList.Background = Brushes.Black;
            }
        }
    }
}
