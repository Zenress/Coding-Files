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

namespace MeatGross.Interaction_Logic_OR_BIZ
{
    /// <summary>
    /// Here goes the MeatGrossBiz Class
    /// </summary>    

    #region Interaction Logic for Main Window AKA ViewModel for MainWindow
    public class MainWindowViewModel
    {
        //Creating a Entity Database and Property that lets other windows read the methods in this class
        MeatGross.Interaction_Logic_OR_BIZ.MeatGrossEntities _meatDb = new MeatGross.Interaction_Logic_OR_BIZ.MeatGrossEntities();
        public MainWindow Window { get; set; }

        //Constructor for class
        public MainWindowViewModel(MainWindow window)
        {
            Window = window;
        }
        public void FillCombobox()
        {
            //Foreach loops that add the items of the meat table and customer table into the comboboxes
            foreach (var item in _meatDb.Meat)
            {
                Window.comboBoxMeatType.Items.Add(item.meatType);
            }
            foreach (var item in _meatDb.Customer)
            {
                Window.comboBoxCustomer.Items.Add(item.companyName);
            }
        }
        public void updatePriceAndStock()
        {
            //If statement that only turns true if you have selected a type of meat and the textbox isn't empty
            if (Window.comboBoxMeatType.SelectedItem != null && Window.textBoxSoldKg.Text != "")
            {
                //TryCatch statement that checks if you have written a number in the field
                try
                {
                    decimal placeholder = _meatDb.Meat.Where(meats => meats.meatType == Window.comboBoxMeatType.SelectedItem.ToString()).Single().price;
                    Window.labelCostPrise.Content = Math.Round((double)placeholder * double.Parse(Window.textBoxSoldKg.Text), 2).ToString() + ",00 kr.";
                }
                catch (System.FormatException eee)
                {
                    MessageBox.Show(eee.Message, "Warning Thrown", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
        }
        public void UpdateInfo()
        {
            //Code for the Meat type Combobox
            Window.labelMeatPrice.Content = Math.Round(_meatDb.Meat.Where(meat => meat.meatType == Window.comboBoxMeatType.SelectedItem.ToString()).Single().price, 2);
            Window.labelMeatOnStock.Content = _meatDb.Meat.Where(meat => meat.meatType == Window.comboBoxMeatType.SelectedItem.ToString()).Single().stock;
        }
        public void SellToCustomerBtn()
        {
            int stockPlaceholder = _meatDb.Meat.Where(meats => meats.meatType == Window.comboBoxMeatType.SelectedItem.ToString()).Single().stock;
            //Code for the sell button
            try
            {
                if (stockPlaceholder >= int.Parse(Window.textBoxSoldKg.Text) && Window.textBoxSoldKg.Text != "")
                {
                    MeatGross.Interaction_Logic_OR_BIZ.Meat opdateretStock = (from o in _meatDb.Meat
                                                                              where o.meatType == Window.comboBoxMeatType.SelectedItem.ToString()
                                                                              select o).Single();
                    opdateretStock.stock -= int.Parse(Window.textBoxSoldKg.Text);
                }
                //Saving and updating the stock of meat
                _meatDb.SaveChanges();
                Window.labelMeatOnStock.Content = _meatDb.Meat.Where(meat => meat.meatType == Window.comboBoxMeatType.SelectedItem.ToString()).Single().stock;
                //Code for creating the customers order                
                if (stockPlaceholder >= int.Parse(Window.textBoxSoldKg.Text) && Window.textBoxSoldKg.Text != "" && Window.comboBoxCustomer.SelectedItem != null && Window.comboBoxMeatType.SelectedItem != null)
                {
                    //Placeholder that makes sure that the selected row in the database has the same meattype as the combobox selection
                    decimal placeholder = _meatDb.Meat.Where(meats => meats.meatType == Window.comboBoxMeatType.SelectedItem.ToString()).Single().price;

                    //Making a new order based on the inputfields and selected combobox elements.
                    MeatGross.Interaction_Logic_OR_BIZ.Orders neworder = new MeatGross.Interaction_Logic_OR_BIZ.Orders()
                    {
                        customer = _meatDb.Customer.Where(customer => customer.companyName == Window.comboBoxCustomer.SelectedItem.ToString()).Single().Id,
                        meat = _meatDb.Meat.Where(meat => meat.meatType == Window.comboBoxMeatType.SelectedItem.ToString()).Single().Id,
                        weight = int.Parse(Window.textBoxSoldKg.Text),
                        orderDate = DateTime.Today,
                        orderPrice = (decimal)Math.Round((double)placeholder * double.Parse(Window.textBoxSoldKg.Text), 2)
                    };

                    //Adding the row to the database table, and saving the new change to the table.
                    _meatDb.Orders.Add(neworder);
                    _meatDb.SaveChanges();
                    MessageBox.Show("test");

                }
                else if (Window.comboBoxMeatType.SelectedItem == null || Window.comboBoxCustomer.SelectedItem == null)
                {
                    //Showing a message box if you haven't chosen either a meattype or customer
                    MessageBox.Show("To create an order, please select a meattype and the customer", "Warning Thrown", MessageBoxButton.OK, MessageBoxImage.Warning);

                }
                else if (stockPlaceholder < int.Parse(Window.textBoxSoldKg.Text) && Window.textBoxSoldKg.Text != "")
                {
                    //Shows a message box if you have typed an amount of meat that is higher than the available amnount
                    Window.textBoxSoldKg.Text = stockPlaceholder.ToString();
                    MessageBox.Show("The stock is lower than your entered amount. Your entered Amount has been corrected", "Amount too high", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }

            }
            //Code for catching mistakes
            catch (System.FormatException eee)
            {
                MessageBox.Show(eee.Message, "Warning Thrown", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
        public void UpdateCustomerInfo()
        {
            //Updating the labels containing the information o the customer
            MeatGross.Interaction_Logic_OR_BIZ.Customer updateLabels = (from o in _meatDb.Customer
                                                                           where o.companyName == Window.comboBoxCustomer.SelectedItem.ToString()
                                                                           select o).Single();
            Window.labelCustomerId.Content = updateLabels.Id;
            Window.labelCustomerName.Content = updateLabels.companyName;
            Window.labelCustomerAddress.Content = updateLabels.address;
            Window.labelCustomerZipCity.Content = updateLabels.zip + " " + _meatDb.ZipCity.Where(city => city.zip == updateLabels.zip).Single().cityName;
            Window.labelCustomerPhone.Content = updateLabels.phone;
            Window.labelCustomerMail.Content = updateLabels.mail;
            Window.labelCustomerContaktName.Content = updateLabels.contactName;
        }
        public void EditCustomerBtn()
        {
            //Checking that you have selected a customer, and then opening the window if you have
            if (!(Window.comboBoxCustomer.SelectedItem == null))
            {
                WindowEditCustomer redigerKunde = new WindowEditCustomer(Window);
                redigerKunde.ShowDialog();
            }
            //Shows a message box telling you to select the customer you want to edit
            else
            {
                MessageBox.Show("Please select the customer you want to edit", "Select a Customer", MessageBoxButton.OK,MessageBoxImage.Error);
            }
        }
        public void NewCustomerBtn()
        {
            //Opening the customer window
            CreateCustomer opretKunde = new CreateCustomer();
            opretKunde.ShowDialog();
        }
    }
    #endregion
    #region Interaction Logic for CreateCustomer Window AKA ViewModel for CreateCustomerWindow
    public class CreateCustomerViewModel
    {
        //Creating a Entity Database and Property that lets other windows read the methods in this class
        MeatGross.Interaction_Logic_OR_BIZ.MeatGrossEntities _meatDb = new MeatGross.Interaction_Logic_OR_BIZ.MeatGrossEntities();
        public CreateCustomer Window { get; set; }

        //Constructor for class
        public CreateCustomerViewModel(CreateCustomer window)
        {
            Window = window;
        }
        public void CreateCustomerBtn()
        {
            //Making sure you can't create a customer with one or more fields empty
            if (!(Window.TBCompanyName.Text == "" && Window.TBAdresse.Text == "" && Window.TBZip.Text == "" && Window.TBPhone.Text == "" && Window.TBMail.Text == "" && Window.TBContactName.Text == ""))
            {
                //Creating a new entry in the customer table. Essentially making a new customer
                MeatGross.Interaction_Logic_OR_BIZ.Customer newCustomer = new MeatGross.Interaction_Logic_OR_BIZ.Customer()
                {
                    companyName = Window.TBCompanyName.Text,
                    address = Window.TBAdresse.Text,
                    zip = Window.TBZip.Text,
                    phone = Window.TBPhone.Text,
                    mail = Window.TBMail.Text,
                    contactName = Window.TBContactName.Text
                };
                //Adding the new customer to the customer table, and then saving the new change to the _meatDb entity database
                _meatDb.Customer.Add(newCustomer);
                _meatDb.SaveChanges();
            }
        }

    }
    #endregion
    #region Interaction Logic for EditCustomer Window AKA ViewModel for WindowEditCustomer
    public class WindowEditCustomerViewModel
    {
        //Creating a Entity Database and Properties that lets other windows read the methods in this class
        MeatGross.Interaction_Logic_OR_BIZ.MeatGrossEntities _meatDb = new MeatGross.Interaction_Logic_OR_BIZ.MeatGrossEntities();       
        public WindowEditCustomer Window { get; set; }
        public MainWindow MainWindow { get; set; }

        //Constructor for class
        public WindowEditCustomerViewModel(WindowEditCustomer window, MainWindow mainWindow)
        {
            //Assigning the public propertys the value of the local parameters
            Window = window;
            MainWindow = mainWindow;
        }
        public void FillCombobox()
        {
            //Filling the combobox with the items in the zipcity table, so you can select a zipcode to update to
            foreach (var item in _meatDb.ZipCity)
            {
                Window.CBZip.Items.Add(item.zip + " : " + item.cityName);
            }
        }
        public void PreloadCustomer()
        {
            //Code for preloading the selected customer information
            MeatGross.Interaction_Logic_OR_BIZ.Customer updateLabels = (from o in _meatDb.Customer
                                                                           where o.companyName == MainWindow.comboBoxCustomer.SelectedItem.ToString()
                                                                           select o).Single();
            Window.TBCompanyName.Text = updateLabels.companyName;
            Window.TBAdresse.Text = updateLabels.address;
            Window.TBPhone.Text = updateLabels.phone;
            Window.TBMail.Text = updateLabels.mail;
            Window.TBContactName.Text = updateLabels.contactName;
        }

        public void UpdateCustomer()
        {
            //If statement that prevents updating a row if the inputs are empty
            if (!(Window.TBCompanyName.Text == "" || Window.TBAdresse.Text == "" || Window.TBPhone.Text == "" || Window.TBMail.Text == "" || Window.TBContactName.Text == ""))
            {
                //updateCustomer is an action where customer is a customer entity in the Customer table
                //It selects a customer which has the same companyName as the comboBoxCustomer's selectedItem
                //And only selects one customer*
                MeatGross.Interaction_Logic_OR_BIZ.Customer updateCustomer = (from customer in _meatDb.Customer
                                                                              where customer.companyName == MainWindow.comboBoxCustomer.SelectedItem.ToString()
                                                                              select customer).Single();
                updateCustomer.companyName = Window.TBCompanyName.Text;
                updateCustomer.address = Window.TBAdresse.Text;
                updateCustomer.zip = Window.CBZip.SelectedItem.ToString().Substring(0, 4);
                updateCustomer.phone = Window.TBPhone.Text;
                updateCustomer.mail = Window.TBMail.Text;
                updateCustomer.contactName = Window.TBContactName.Text;
            }
            //Saving the changes to the database
            _meatDb.SaveChanges();
        }
    }
    #endregion    
}
