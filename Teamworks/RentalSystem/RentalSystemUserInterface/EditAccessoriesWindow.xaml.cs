namespace RentalSystemUserInterface
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Windows;
    using System.Windows.Controls;

    using RentalSystem.Models;

    /// <summary>
    /// Interaction logic for EditAccessoriesWindow.xaml
    /// </summary>
    public partial class EditAccessoriesWindow : Window
    {
        public int currentAccessory;
        private BindingList<string> bl;

        public EditAccessoriesWindow(List<Accessory> machines)
        {
            InitializeComponent();
            bl = new BindingList<string>();

            foreach (Accessory item in machines)
            {
                bl.Add(item.Name);
            }

            NameCombo.ItemsSource = bl;
            currentAccessory = 0;
        }

        private void NameCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentAccessory = NameCombo.SelectedIndex;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            currentAccessory = bl.Count;
            this.Close();
        }

        private void DelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            currentAccessory = -1;
            this.Close();
        }
    }
}