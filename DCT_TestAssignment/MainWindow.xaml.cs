using System;
using System.Windows;
using System.Windows.Data;

namespace DCT_TestAssignment
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
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
    }
}
