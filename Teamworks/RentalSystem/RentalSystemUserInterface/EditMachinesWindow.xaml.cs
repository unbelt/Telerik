namespace RentalSystemUserInterface
{
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for EditMachinesWindow.xaml
    /// </summary>
    public partial class EditMachinesWindow : Window
    {
        public int currentMachine = -1;
        public BindingList<string> bl;

        public EditMachinesWindow()
        {
            InitializeComponent();
        }

        private void NameCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentMachine = NameCombo.SelectedIndex;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // int number;
            // bool dataChanged = int.TryParse(NoBox.Text, out number);
            // if (!dataChanged)
            //    MessageBox.Show("Invalid machine number");
            // else
            // {
                currentMachine = bl.Count;
                this.Close();

            // }
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            currentMachine = -1;
            this.Close();
        }
    }
}