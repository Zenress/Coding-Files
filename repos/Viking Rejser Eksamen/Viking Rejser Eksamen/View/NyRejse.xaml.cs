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
using Viking_Rejser_Eksamen.ViewModel;

namespace Viking_Rejser_Eksamen.View
{
    /// <summary>
    /// Interaction logic for NyRejse.xaml
    /// </summary>
    public partial class NyRejse : Window
    {
        //Creating a viewModel field for the NyRejseViewModel class, so i can access it's methods
        private readonly NyRejseViewModel viewModel;
        public NyRejse(MainWindow mainWindow)
        {
            InitializeComponent();
            //Assigning the necessary windows for the Viewmodel class
            viewModel = new NyRejseViewModel(this, mainWindow);
            //Using the FillCombobox method
            viewModel.FillCombobox();
        }

        private void RejseCreate_Click(object sender, RoutedEventArgs e)
        {
            //Using the NewRejse (New Vacation) method in the Event: RejseCreate_Click
            viewModel.NewRejse();
        }
    }
}
