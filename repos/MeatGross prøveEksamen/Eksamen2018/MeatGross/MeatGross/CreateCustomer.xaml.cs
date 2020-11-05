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
    /// Interaction logic for CreateCustomer.xaml
    /// </summary>
    public partial class CreateCustomer : Window
    {
        private readonly CreateCustomerViewModel viewModel;
        public CreateCustomer()
        {
            //Initalizing the window
            InitializeComponent();

            //Assigning a window to the viewModel
            viewModel = new CreateCustomerViewModel(this);
        }

        private void CreateCustomerBtn_Click(object sender, RoutedEventArgs e)
        {
            //Running the CreateCustomerBtn method
            viewModel.CreateCustomerBtn();
        }

        private void CancelCreateBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
