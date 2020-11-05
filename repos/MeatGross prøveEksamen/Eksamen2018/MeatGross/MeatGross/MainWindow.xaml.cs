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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using MeatGross.Interaction_Logic_OR_BIZ;

namespace MeatGross
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Creating a readonly public property of the MainWindowViewModel
        private readonly MainWindowViewModel viewModel;
        public MainWindow()
        {
            //Code for the window initialization
            InitializeComponent();

            //Assigning the window to the viewModel, using the FillCombobox method
            viewModel = new MainWindowViewModel(this);
            viewModel.FillCombobox();

            //Preventing the textBoxSoldKg_TextChanged event from triggering before the viewModel is assigned
            textBoxSoldKg.Text = "0";
        }

        #region Left side of program. Meat combobox, input field for amount, button and labels.
                
        private void comboBoxMeatType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModel.UpdateInfo();
            viewModel.updatePriceAndStock();
        }

        private void textBoxSoldKg_TextChanged(object sender, TextChangedEventArgs e)
        {
            //Code for the input field where you type the amount of kg's of meat you want
            viewModel.updatePriceAndStock();          
        }
                
        private void buttonSellToCustomer_Click(object sender, RoutedEventArgs e)
        {
            viewModel.SellToCustomerBtn();
        }
        #endregion

        #region Right side of program. Customer combobox, Edit customer button and Create customer btn
        private void comboBoxCustomer_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            viewModel.UpdateCustomerInfo();     
        }

        private void buttonEditCustomer_Click(object sender, RoutedEventArgs e)
        {
            viewModel.EditCustomerBtn();
        }

        private void buttonNewCustomer_Click(object sender, RoutedEventArgs e)
        {
            viewModel.NewCustomerBtn();
        }
        #endregion
    }


}
