﻿using System;
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
    /// Interaction logic for NyTransportør.xaml
    /// </summary>
    public partial class NyTransportoer : Window
    {
        //Creating a viewModel field for the NyTransportoerViewModel class, so i can access it's methods
        private readonly NyTransportoerViewModel viewModel;
        public NyTransportoer(MainWindow mainWindow)
        {
            InitializeComponent();
            //Assigning the necessary windows to the ViewModel class
            viewModel = new NyTransportoerViewModel(this, mainWindow);
        }

        private void RejseCreate_Click(object sender, RoutedEventArgs e)
        {
            //Using the NewTransportter method in the Event: RejseCreate_Click
            viewModel.NewTransportter();
        }
    }
}
