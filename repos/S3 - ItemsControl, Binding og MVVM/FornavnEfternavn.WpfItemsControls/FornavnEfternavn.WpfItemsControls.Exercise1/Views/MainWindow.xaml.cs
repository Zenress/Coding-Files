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
using System.Windows.Navigation;
using System.Windows.Shapes;
using FornavnEfternavn.WpfItemsControls.Exercise1.Model;

namespace FornavnEfternavn.WpfItemsControls.Exercise1.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Person Shano = new Person("Shano","Fog","BlahBlah","202020");
            people.Items.Add(Shano);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Person selectedPerson = (Person)people.SelectedItem;
            firstNameTB.Text = selectedPerson.FirstName;
            lastNameTB.Text = selectedPerson.LastName;
            eMailTB.Text = selectedPerson.Email;
            tlfNrTB.Text = selectedPerson.TlfNr;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NewPerson window = new NewPerson(people);
            window.Show();
        }
    }
}
