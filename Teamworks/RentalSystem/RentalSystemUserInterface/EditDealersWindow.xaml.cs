namespace RentalSystemUserInterface
{
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for EditDealersWindow.xaml
    /// </summary>
    public partial class EditDealersWindow : Window
    {
        public int currentDealer = -1;
        public BindingList<string> bl;

        public EditDealersWindow()
        {
            InitializeComponent();
        }

        private void NameCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentDealer = NameCombo.SelectedIndex;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            currentDealer = bl.Count;
            this.Close();
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            currentDealer = -1;
            this.Close();
        }
    }
}