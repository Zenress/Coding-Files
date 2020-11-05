using MeatGross.Interaction_Logic_OR_BIZ;
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

namespace MeatGross
{
    /// <summary>
    /// Eventhandler logic for WindowEditCustomer
    /// </summary>
    public partial class WindowEditCustomer : Window
{    
        private readonly WindowEditCustomerViewModel viewModel;
        public WindowEditCustomer(MainWindow mainWindow)
        {            
            InitializeComponent();
            //Filling the combobox and preloading the customer information based on what customer you picked
            viewModel = new WindowEditCustomerViewModel(this, mainWindow);
            viewModel.FillCombobox();
            viewModel.PreloadCustomer();          
        }

        private void UpdateCustomerBtn_Click(object sender, RoutedEventArgs e)
        {
            //Running the updatecustomer method to update the information of the selected customer
            viewModel.UpdateCustomer();
        }

        private void CancelEditBtn_Click(object sender, RoutedEventArgs e)
        {
            //Closing the window
            Close();
        }
    }

    
}
