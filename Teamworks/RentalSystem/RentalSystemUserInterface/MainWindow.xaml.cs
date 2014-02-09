namespace RentalSystemUserInterface
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;
    using System.Threading;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Threading;

    using RentalSystem.Models;
    using RentalSystem.Repository;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static RentalUnitOfWork engine;
        private static List<Customer> customers;
        private static List<Dealer> dealers;
        private static List<ITool> machines;
        private static List<ITool> accesories;
        private static List<Contract> contracts;

        public MainWindow()
        {
            InitializeComponent();

            // custom display format in datepicker
            CultureInfo ci = CultureInfo.CreateSpecificCulture(CultureInfo.CurrentCulture.Name);
            ci.DateTimeFormat.ShortDatePattern = "dd MMM yyyy";
            Thread.CurrentThread.CurrentCulture = ci;

            InitializeTimer();

            // дотук мисля че няма да има никакви промени повече - ако ти трябва нещо, слагай след тоя ред.
            engine = new RentalUnitOfWork();
            engine.Start();

            //customers = new List<Customer>(engine.CustomerRepository.Get(null, q => q.OrderBy(s => s.Name).ThenBy(s => s.CustomerId), string.Empty));
            //dealers = new List<Dealer>(engine.DealerRepository.Get(null, q => q.OrderBy(s => s.FirstName).ThenBy(s => s.LastName), string.Empty));
            //machines = new List<ITool>(engine.MachineRepository.Get(null, q => q.OrderBy(s => s.Name).ThenBy(s => s.MachineNumber), string.Empty));
            //accesories = new List<ITool>(engine.AccessoryRepository.Get(null, q => q.OrderBy(s => s.Name), string.Empty));
            //contracts = new List<Contract>(engine.ContractRepository.Get(null, q => q.OrderBy(s => s.ContractNo), string.Empty));

            UpdateCustomers();
            UpdateDealers();
            UpdateMachines();
            UpdateAccesories();
            UpdateContracts();

            ComboBoxDealer.SelectedIndex = 0;

            if (contracts.Count > 0)
                TextBoxContractNo.Text = (contracts[contracts.Count - 1].ContractNo + 1).ToString();
            else
                TextBoxContractNo.Text = "1";
        }

        private void UpdateCustomers()
        {
            engine.Save();
            customers = new List<Customer>(engine.CustomerRepository.Get(null, q => q.OrderBy(s => s.Name).ThenBy(s => s.CustomerId), string.Empty));
            ComboBoxCustomer.ItemsSource = new BindingList<Customer>(customers);
        }

        private void UpdateDealers()
        {
            engine.Save();
            dealers = new List<Dealer>(engine.DealerRepository.Get(null, q => q.OrderBy(s => s.FirstName).ThenBy(s => s.LastName), string.Empty));
            ComboBoxDealer.ItemsSource = new BindingList<Dealer>(dealers);
        }
        private void UpdateMachines()
        {
            engine.Save();
            machines = new List<ITool>(engine.MachineRepository.Get(null, q => q.OrderBy(s => s.Name).ThenBy(s => s.MachineNumber), string.Empty));
            MachineName.ItemsSource = new BindingList<ITool>(machines.Where(x => (x as Machine).ContractId == null).ToList());
        }

        private void UpdateAccesories()
        {
            engine.Save();
            accesories = new List<ITool>(engine.AccessoryRepository.Get(null, q => q.OrderBy(s => s.Name), string.Empty));
            AccessoryName.ItemsSource = new BindingList<ITool>(accesories);
        }

        private void UpdateContracts()
        {
            engine.Save();
            contracts = new List<Contract>(engine.ContractRepository.Get(null, q => q.OrderBy(s => s.ContractNo), string.Empty));
        }

        public void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            this.Dispatcher.Invoke(DispatcherPriority.Normal, (Action)(() =>
            {
                TextBoxDate.Text = DateTime.Now.ToShortDateString();
                TextBoxTime.Text = DateTime.Now.ToString("HH:mm:ss");
                ReturnDate.SelectedDate = DateTime.Now.AddDays(1);
            }));
        }

        private void InitializeTimer()
        {
            // handle event - needed for displayng real time in "Contract Creating Time" textbox
            System.Timers.Timer timer = new System.Timers.Timer(1000);
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Enabled = true;
        }

        public void newCustomerWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Customer selectedCustomer = ComboBoxCustomer.SelectedItem as Customer;
            NewCustomer newCustomerWindow = sender as NewCustomer;

            if (newCustomerWindow.dataIsCorect)
            {
                if (newCustomerWindow.editMode)
                {
                    WindowHelpers.GetNewCustomerData(newCustomerWindow, selectedCustomer);
                    engine.CustomerRepository.Update(selectedCustomer);
                }
                else
                {
                    Customer customerToAdd;
                    if (newCustomerWindow.Firm.IsChecked == true)
                        customerToAdd = new Firm();
                    else
                        customerToAdd = new Person();
                    WindowHelpers.GetNewCustomerData(newCustomerWindow, customerToAdd);
                    engine.CustomerRepository.Insert(customerToAdd);
                    selectedCustomer = customerToAdd;
                    
                }
                UpdateCustomers();
                ComboBoxCustomer.SelectedItem = selectedCustomer;
                WindowHelpers.FillMainWindowWithCustomerData(this, selectedCustomer);
            }
        }

        private void EGN_TextChanged(object sender, TextChangedEventArgs e)
        {
            UIResources.EGNValidate(sender as TextBox, e);
        }

        private void ComboBoxCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex != -1)
            {
                EditClient.IsEnabled = true;
                DeleteClient.IsEnabled = true;
                SaveContract.IsEnabled = true;
                WindowHelpers.FillMainWindowWithCustomerData(this, (sender as ComboBox).SelectedItem as Customer); // customers[selectedCustomer]); // изкарах си нещата в отделен C# файл да не си "мешаме капите"
            }
            else
            {
                EditClient.IsEnabled = false;
                DeleteClient.IsEnabled = false;
                SaveContract.IsEnabled = false;
                WindowHelpers.ClearMainWindow(this, true);
            }
        }

        private void ComboMachines_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MachineName.SelectedIndex > -1)
                MachineNumber.ItemsSource = new BindingList<ITool>(machines.Where(x => (x.Name == (MachineName.SelectedItem as Machine).Name) &&
                    ((x as Machine).ContractId == null)).ToList());
            else
                MachineNumber.ItemsSource = null;
        }

        private void NewClientButtonClick(object sender, RoutedEventArgs e)
        {
            NewCustomer newCustomerWindow = new NewCustomer();
            newCustomerWindow.CustAttr.SelectedIndex = 0;
            newCustomerWindow.Closing += newCustomerWindow_Closing;
            newCustomerWindow.editMode = false;
            newCustomerWindow.Firm.Visibility = UIResources.Visible;
            newCustomerWindow.ShowDialog();
        }

        private void EditClientButtonClick(object sender, RoutedEventArgs e)
        {
            NewCustomer newCustomerWindow = new NewCustomer();
            newCustomerWindow.Closing += newCustomerWindow_Closing;
            newCustomerWindow.editMode = true;
            newCustomerWindow.Firm.Visibility = UIResources.Hidden;
            WindowHelpers.FillNewCustomerWindow(newCustomerWindow, ComboBoxCustomer.SelectedItem as Customer);
            newCustomerWindow.ShowDialog();
        }

        private void DeleteClientButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBoxButton button = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show("Delete this customer?", "Confirm delete", button);

            if (result == MessageBoxResult.Yes)
            {
                Customer selectedCustomer = ComboBoxCustomer.SelectedItem as Customer;
                engine.CustomerRepository.Delete(selectedCustomer);
                UpdateCustomers();
                ComboBoxCustomer.SelectedIndex = -1;
                WindowHelpers.ClearMainWindow(this, true);
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ExitButtonClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void AddMachineButonClick(object sender, RoutedEventArgs e)
        {
            if (MachineName.SelectedIndex > -1)
                if ((MachineName.SelectedItem as Machine).ContractId != null)
                    MessageBox.Show("Machine is already in use in contract" + (MachineName.SelectedItem as Machine).ContractId);
                else
                    WindowHelpers.AddMachine(ToolsGrid, MachineName.SelectedItem as Machine);
        }

        private void AddAccessoryButonClick(object sender, RoutedEventArgs e)
        {
            if (AccessoryName.SelectedIndex > -1)
            {
                AddAccessory.IsEnabled = true;
                WindowHelpers.AddMachine(AccessoryGrid, AccessoryName.SelectedItem as Accessory);
            }
            else
                AddAccessory.IsEnabled = false;
        }

        private void EditMachinesButtonClick(object sender, RoutedEventArgs e)
        {
            EditMachinesWindow machinesWindow = new EditMachinesWindow();
            machinesWindow.bl = new BindingList<string>();

            foreach (Machine item in machines)
                machinesWindow.bl.Add(item.Name.PadRight(10) + " No " + item.MachineNumber);

            machinesWindow.NameCombo.ItemsSource = machinesWindow.bl;
            machinesWindow.ShowDialog();

            if (machinesWindow.currentMachine > -1)
            {
                if (machinesWindow.currentMachine == machines.Count)
                {
                    Machine machineToAdd = new Machine();
                    machineToAdd.Name = machinesWindow.NameBox.Text;
                    int number;
                    bool isNumber = int.TryParse(machinesWindow.NoBox.Text, out number);

                    if (!isNumber)
                    {
                        MessageBox.Show("Invalid machine number");
                        return;
                    }
                    else
                        machineToAdd.MachineNumber = int.Parse(machinesWindow.NoBox.Text);
                    engine.MachineRepository.Insert(machineToAdd);
                    UpdateMachines();
                    MachineNumber.ItemsSource = new BindingList<ITool>(machines);
                }
                else
                {
                    if ((machines[machinesWindow.currentMachine] as Machine).ContractId != null)
                        MessageBox.Show("Cannot delete this machine. It's in use in contract No " + (machines[machinesWindow.currentMachine] as Machine).ContractId);
                    else
                    {
                        engine.MachineRepository.Delete(machines[machinesWindow.currentMachine] as Machine);
                        UpdateMachines();
                        MachineName.SelectedIndex = -1;
                        MachineNumber.ItemsSource = new BindingList<ITool>(machines);
                        MachineNumber.SelectedIndex = -1;
                    }
                }
            }
        }

        private void EditAccButtonClick(object sender, RoutedEventArgs e)
        {
            EditMachinesWindow machinesWindow = new EditMachinesWindow();
            machinesWindow.NoBlock.Visibility = UIResources.Hidden;
            machinesWindow.NoBox.Visibility = UIResources.Hidden;
            machinesWindow.bl = new BindingList<string>();

            foreach (ITool item in accesories)
                machinesWindow.bl.Add(item.Name);

            machinesWindow.NameCombo.ItemsSource = machinesWindow.bl;
            machinesWindow.ShowDialog();

            if (machinesWindow.currentMachine > -1)
            {
                if (machinesWindow.currentMachine == accesories.Count)
                {
                    Accessory accessoryToAdd = new Accessory();
                    accessoryToAdd.Name = machinesWindow.NameBox.Text;
                    engine.AccessoryRepository.Insert(accessoryToAdd);
                    //accesories.Add(accessoryToAdd);
                    //accesories.Sort();
                }
                else
                {
                    engine.AccessoryRepository.Delete(accesories[machinesWindow.currentMachine] as Accessory);
                    accesories.RemoveAt(machinesWindow.currentMachine);
                    AccessoryName.SelectedIndex = -1;
                }
                UpdateAccesories();
//                AccessoryName.ItemsSource = new BindingList<ITool>(accesories);
            }
        }

        private void EditDealersButtonClick(object sender, RoutedEventArgs e)
        {
            EditDealersWindow dealersWindow = new EditDealersWindow();
            dealersWindow.bl = new BindingList<string>();

            foreach (Dealer item in dealers)
                dealersWindow.bl.Add(item.GetName());

            dealersWindow.NameCombo.ItemsSource = dealersWindow.bl;
            dealersWindow.ShowDialog();

            if (dealersWindow.currentDealer > -1)
            {
                if (dealersWindow.currentDealer == dealers.Count)
                {
                    Dealer dealerToAdd = new Dealer();
                    dealerToAdd.FirstName = dealersWindow.FirstNameBox.Text;
                    dealerToAdd.LastName = dealersWindow.LastNameBox.Text;
                    engine.DealerRepository.Insert(dealerToAdd);
                }
                else
                {
                    engine.DealerRepository.Delete(dealers[dealersWindow.currentDealer] as Dealer);
                    ComboBoxDealer.SelectedIndex = -1;
                }
                UpdateDealers();
            }
        }

        private void SaveButtonClick(object sender, RoutedEventArgs e)
        {
            Contract contract = new Contract();
            contract.ContractNo = int.Parse(TextBoxContractNo.Text);
            contract.CreationDate = DateTime.Now;
            contract.Dealer = dealers[ComboBoxDealer.SelectedIndex];
            contract.Customer = customers[ComboBoxCustomer.SelectedIndex];
            contract.ReturnDate = ReturnDate.SelectedDate.Value;
            int price;

            if (int.TryParse(Advance.Text, out price))
                contract.Advance = price;
            else
            {
                MessageBox.Show("Advance price error");
                return;
            }

            if (int.TryParse(Total.Text, out price))
                contract.TotalPrice = price;
            else
            {
                MessageBox.Show("Total price error");
                return;
            }

            foreach (StackPanel item in ToolsGrid.Items)
            {
                if (item.DataContext == null) continue;
                Machine rentedMachine = item.DataContext as Machine;
                contract.Machines.Add(rentedMachine);
                engine.MachineRepository.Update(rentedMachine);
            }

            foreach (StackPanel item in AccessoryGrid.Items)
            {
                int count;
                if (item.DataContext == null || int.TryParse((item.Children[1] as TextBox).Text, out count)) continue;
                Accessory rentedAccesory = new Accessory();
                rentedAccesory.Name = (item.Children[0] as TextBlock).Text;
                rentedAccesory.Count = count;
            }
            contract.GetPromoted();

            engine.ContractRepository.Insert(contract);
            UpdateContracts();

            contract = contracts[contracts.Count - 1];

            int lastContractId = engine.ContractRepository.Get(null, q => q.OrderBy(s => s.ContractNo), string.Empty).Last().ContractId;
            foreach (Machine item in contract.Machines)
                item.ContractId = lastContractId;
            UpdateMachines();
            WindowHelpers.ClearMainWindow(this,false);
            TextBoxContractNo.Text = (contract.ContractNo + 1).ToString();
        }

        private void ComboMachNum_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddMachine.IsEnabled = MachineNumber.SelectedIndex > -1;
        }

        private void AccessoryName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            AddAccessory.IsEnabled = AccessoryName.SelectedIndex > -1;
        }

        private void ContractButtonClick(object sender, RoutedEventArgs e)
        {
            ContractsWindow contractsWindow = new ContractsWindow();
            DataGrid dGrid = contractsWindow.ContractsDataGrid;
            dGrid.ItemsSource = contracts;
            contractsWindow.ShowDialog();
            if (contractsWindow.currentRow > -1)
            {
                if (MessageBox.Show("Mark contract No " + (contractsWindow.ContractsDataGrid.SelectedItem as Contract).ContractNo + " as archived?", "Confirm delete", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    Contract selectedContract = contractsWindow.ContractsDataGrid.SelectedItem as Contract;
                    List<Machine> contractMachines = new List<Machine>(selectedContract.Machines);
                    foreach (Machine item in contractMachines)
                    {
                        (machines[machines.IndexOf(item)] as Machine).ContractId = null;
                        engine.MachineRepository.Update(machines[machines.IndexOf(item)] as Machine);
                    }
                    selectedContract.IsArchived = true;
                    UpdateContracts();
                    MachineName.ItemsSource = new BindingList<ITool>(machines.Where(x => (x as Machine).ContractId == null).ToList());
                }
            }
        }
    }
}