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
    /// Interaction logic for NyRejse.xaml
    /// </summary>
    public partial class NyRejse : Window
    {
        private readonly NyRejseViewModel viewModel;
        public NyRejse(MainWindow mainWindow)
        {
            InitializeComponent();
            viewModel = new NyRejseViewModel(this, mainWindow);
        }

        private void RejseCreate_Click(object sender, RoutedEventArgs e)
        {
            viewModel.NewRejse();
        }
    }
}