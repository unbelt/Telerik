namespace RentalSystemUserInterface
{
    using System.Windows;
    using System.Windows.Controls;
    using RentalSystem.Models;

    public class WindowHelpers
    {
        public static void AddMachine(ListBox panel, ITool tool)
        {
            StackPanel container = new StackPanel();
            container.Orientation = Orientation.Horizontal;
            container.DataContext = tool;

            TextBlock machineName = new TextBlock();
            machineName.Width = 110;
            machineName.Text = tool.Name;
            container.Children.Add(machineName);

            if (tool is Machine)
            {
                TextBlock machineNumber = new TextBlock();
                machineNumber.Text = (tool as Machine).MachineNumber.ToString();
                machineNumber.Width = 40;
                machineNumber.Margin = new Thickness(5, 0, 5, 0);

                container.Children.Add(machineNumber);
            }
            else
            {
                TextBox аccesoryQty = new TextBox();
                аccesoryQty.Width = 40;
                аccesoryQty.Margin = new Thickness(5, 0, 5, 0);
                container.Children.Add(аccesoryQty);
            }

            Button deleteButton = new Button();
            deleteButton.Content = "X";
            deleteButton.Width = 40;
            deleteButton.Click += (snd, args) =>
            {
                panel.Items.Remove(container);
            };
            container.Children.Add(deleteButton);
            panel.Items.Add(container);
        }

        public static void GetNewCustomerData(NewCustomer window, Customer customer)
        {
            customer.Name = window.CustomerName.Text;
            customer.City = window.City.Text;
            customer.Address = window.Address.Text;
            customer.Phone = window.Phone.Text;
            customer.Comment = window.Comment.Text;
            customer.CustomerType = Customer.GetCustomerType(window.CustAttr.Text);

            if (customer is Firm)
            {
                Firm firm = customer as Firm;
                firm.VATNumber = window.EGN.Text;
            }
            else
            {
                Person person = customer as Person;
                person.EGN = window.EGN.Text;
                person.PersonalCardNumber = window.PCN.Text;
                person.PCNDate = window.PCNDate.SelectedDate.Value;
                person.DrivingLicense = window.DL.Text;
                person.DLDate = window.DLDate.SelectedDate.Value;
            }
        }

        public static void ClearMainWindow(MainWindow window, bool clearOnlyUserData)
        {
            window.ComboBoxCustomer.SelectedIndex = -1;
            window.PersonalDataGroup.Visibility = UIResources.Visible;
            window.Phone.Clear();
            window.City.Clear();
            window.Address.Clear();
            window.Comment.Clear();
            window.Incorrect.Text = string.Empty;
            window.Incorrect.Background = UIResources.WhiteBrush;
            window.TxtEGN.Text = "EGN:";
            window.EGN.Clear();
            window.PCN.Clear();
            window.PCNDate.SelectedDate = new System.DateTime(2001, 1, 1);
            window.DL.Clear();
            window.DLDate.SelectedDate = new System.DateTime(2001, 1, 1);
            if (clearOnlyUserData) return;
            for (int i = 1; i < window.ToolsGrid.Items.Count; i++)
            {
                window.ToolsGrid.Items.RemoveAt(1);
            }

            for (int i = 1; i < window.AccessoryGrid.Items.Count; i++)
            {
                window.AccessoryGrid.Items.RemoveAt(1);
            }

            window.MachineName.SelectedIndex = -1;
            window.AccessoryName.SelectedIndex = -1;
            window.Advance.Clear();
            window.Total.Clear();
        }

        public static void FillMainWindowWithCustomerData(MainWindow window, Customer customer)
        {
            window.PersonalDataGroup.Visibility = UIResources.Visible;
            window.Phone.Text = customer.Phone;
            window.City.Text = customer.City;
            window.Address.Text = customer.Address;
            window.Comment.Text = customer.Comment;
            window.Incorrect.Text = customer.CustomerType.ToString();

            switch (customer.CustomerType)
            {
                case CustomerType.Regular:
                    window.Incorrect.Text = string.Empty;
                    window.Incorrect.Background = UIResources.WhiteBrush;
                    break;
                case CustomerType.Thief:
                case CustomerType.MachineBreak:
                case CustomerType.NotComplyDeadline:
                    window.Incorrect.Background = UIResources.RedBrush;
                    break;
                case CustomerType.VIPClient:
                case CustomerType.FamilyFriend:
                    window.Incorrect.Background = UIResources.GreenBrush;
                    break;
            }

            if (customer is Person)
            {
                                // window.PersonalDataGroup.Visibility = UIResources.Visible;
                window.TxtEGN.Text = "EGN:";
                window.EGN.Text = (customer as Person).EGN;
                window.PCN.Text = (customer as Person).PersonalCardNumber;
                window.PCNDate.Text = (customer as Person).PCNDate.ToShortDateString();
                window.DL.Text = (customer as Person).DrivingLicense;
                window.DLDate.Text = (customer as Person).DLDate.ToShortDateString();
            }
            else
            {
                window.PersonalDataGroup.Visibility = UIResources.Hidden;
                window.TxtEGN.Text = "VAT:";
                window.EGN.Text = (customer as Firm).VATNumber;
            }
        }

        public static void FillNewCustomerWindow(NewCustomer window, Customer customer)
        {
            window.CustomerName.Text = customer.Name;
            window.PersonalDataGroup.Visibility = UIResources.Visible;
            window.Phone.Text = customer.Phone;
            window.City.Text = customer.City;
            window.Address.Text = customer.Address;
            window.Comment.Text = customer.Comment;
            window.CustAttr.SelectedIndex = (int)customer.CustomerType;

            if (customer is Person)
            {
                window.PersonalDataGroup.Visibility = UIResources.Visible;
                window.TxtEGN.Text = "EGN:";
                window.EGN.Text = (customer as Person).EGN;
                window.PCN.Text = (customer as Person).PersonalCardNumber;
                window.PCNDate.Text = (customer as Person).PCNDate.ToShortDateString();
                window.DL.Text = (customer as Person).DrivingLicense;
                window.DLDate.Text = (customer as Person).DLDate.ToShortDateString();
                window.Firm.IsChecked = false;
            }
            else
            {
                window.PersonalDataGroup.Visibility = UIResources.Hidden;
                window.TxtEGN.Text = "VAT:";
                window.EGN.Text = (customer as Firm).VATNumber;
                window.Firm.IsChecked = true;
            }
        }
    }
}