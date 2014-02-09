namespace RentalSystemUserInterface
{
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for NewCustomer.xaml
    /// </summary>
    public partial class NewCustomer : Window
    {
        public bool dataIsCorect;
        public bool editMode;
        public bool customerIsFirm = false;

        public NewCustomer()
        {
            InitializeComponent();
            dataIsCorect = false;
            customerIsFirm = false;
        }

        private void ClientIsFirm(object sender, RoutedEventArgs e)
        {
            PersonalDataGroup.Visibility = UIResources.Hidden;
            TxtEGN.Text = "VAT:";
            customerIsFirm = true;
        }

        private void ClientIsPerson(object sender, RoutedEventArgs e)
        {
            PersonalDataGroup.Visibility = UIResources.Visible;
            TxtEGN.Text = "EGN:";
            customerIsFirm = false;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            bool isEmpty = false;

            // Validate empty fields
            if (string.IsNullOrWhiteSpace(CustomerName.Text))
            {
                isEmpty = true;
                MessageBox.Show("You must enter customer name.", "Warrning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (string.IsNullOrWhiteSpace(EGN.Text))
            {
                isEmpty = true;
                MessageBox.Show("You must enter customer EGN.", "Warrning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (string.IsNullOrWhiteSpace(Phone.Text))
            {
                isEmpty = true;
                MessageBox.Show("You must enter customer phone.", "Warrning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (string.IsNullOrWhiteSpace(City.Text))
            {
                isEmpty = true;
                MessageBox.Show("You must enter customer city.", "Warrning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
            else if (string.IsNullOrWhiteSpace(Address.Text))
            {
                isEmpty = true;
                MessageBox.Show("You must enter customer address.", "Warrning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }

            if (dataIsCorect && isEmpty == false)
            {
                this.Close();
            }
            if (!dataIsCorect && isEmpty == false)
            {
                MessageBox.Show("The inputted data is not correct.", "Warrning", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            dataIsCorect = false;
            this.Close();
        }

        // Overall validation
        private void NameTextChanged(object sender, TextChangedEventArgs e)
        {
            dataIsCorect = dataIsCorect & UIResources.NameValidate(sender as TextBox, e);
        }

        private void EGNTextChanged(object sender, TextChangedEventArgs e)
        {
            dataIsCorect = dataIsCorect & UIResources.EGNValidate(sender as TextBox, e);
        }

        private void CityTextChanged(object sender, TextChangedEventArgs e)
        {
            dataIsCorect = dataIsCorect & UIResources.CityValidate(sender as TextBox, e);
        }

        private void PhoneTextChanged(object sender, TextChangedEventArgs e)
        {
            dataIsCorect = dataIsCorect & UIResources.PhoneValidate(sender as TextBox, e);
        }

        private void AddressTextChanged(object sender, TextChangedEventArgs e)
        {
            dataIsCorect = UIResources.AddressValidate(sender as TextBox, e);
        }

        private void DLTextChanged(object sender, TextChangedEventArgs e)
        {
            dataIsCorect = UIResources.DLValidate(sender as TextBox, e);
        }
    }
}