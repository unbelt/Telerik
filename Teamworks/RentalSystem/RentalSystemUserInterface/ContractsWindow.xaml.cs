using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RentalSystemUserInterface
{
    /// <summary>
    /// Interaction logic for ContractsWindow.xaml
    /// </summary>
    public partial class ContractsWindow : Window
    {
        public int currentRow = -1;
        public ContractsWindow()
        {
            InitializeComponent();
        }

        private void ContractsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentRow = ContractsDataGrid.SelectedIndex;
        }
    }
}
