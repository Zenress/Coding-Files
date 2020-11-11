using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Viking_Rejser_Eksamen.Model;
using Viking_Rejser_Eksamen.View;
using Newtonsoft.Json;


namespace Viking_Rejser_Eksamen.ViewModel
{
    #region MainWindow ViewModel Region
    class MainWindowViewModel
    {
        //Making a Entity Field, a Property of MainWindow, and a Constructor
        VikingRejserEksamenEntities _rejseDb = new VikingRejserEksamenEntities();        
        public MainWindow Window { get; set; }
        public MainWindowViewModel(MainWindow window)
        {
            Window = window;           
        }

        //Below is all of the methods
        //Method: Opens the New Vacation Window
        public void OpenNewVacationWindow()
        {
            NyRejse newWindow = new NyRejse(Window);
            newWindow.ShowDialog();
        }
        //Method: Opens the New Customer Window
        public void OpenNewCustomerWindow()
        {
            NyKunde newWindow = new NyKunde(Window);
            newWindow.ShowDialog();
        }
        //Method: Opens the New Transporter Window
        public void OpenNewTransporterWindow()
        {
            NyTransportoer newWindow = new NyTransportoer(Window);
            newWindow.ShowDialog();
        }
        //Method: Opens the New Enrollment Window
        public void OpenNewEnrollmentWindow()
        {
            NyTilmelding newWindow = new NyTilmelding(Window);
            newWindow.ShowDialog();
        }
        //Method: Opens the Enrollment Window
        public void OpenEnrollmentWindow()
        {
            Tilmeldinger newWindow = new Tilmeldinger(Window);
            newWindow.ShowDialog();
        }
        //Method: Fills the Transporter Data Grid that holds transporters that is hired on more than 4 Vacations
        public void FillTransportørDataGrid()
        {
            //Making a list that will hold the transporters that is hired for more than 4 vacatons
            List<Transportoer> Over4Transporters = new List<Transportoer>();
            //Foreach Loop that runs a foreach loop inside of it, and runs a comparison on the Id's Connected to the vacations and the corresponding Transporters Id.
            //Then it adds +1 to the amount field.
            foreach (var Transporter in _rejseDb.Transportoer)
            {
                int amount = 0;
                foreach (var Assigned in _rejseDb.Rejsearrangementer)
                {
                    if (Assigned.Transportoer == Transporter.Id)
                    {
                        amount++;
                    }
                }
                if (amount > 4)
                {
                    Over4Transporters.Add(Transporter);
                }
            }
            Window.transportoerDataGrid1.ItemsSource = Over4Transporters;
            /*(MainWindow.transportoerDataGrid1.ItemsSource as DataTable).DefaultView.RowFilter = */
        }
        //Method: Fills the Customer Data Grid that holds the Customers who has more than one vacation
        public void FillKundeDataGrid()
        {
            List<Kunder> Over1arrangement = new List<Kunder>();
            foreach (var KundeId in _rejseDb.Kunder)
            {
                int amount = 0;
                foreach (var Assigned in _rejseDb.RejseTilmeldinger)
                {
                    if (Assigned.Kunde == KundeId.Id)
                    {
                        amount++;
                    }
                }
                if (amount > 3)
                {
                    Over1arrangement.Add(KundeId);
                }
            }
            Window.transportoerDataGrid1.ItemsSource = Over1arrangement;
        }

        

    }
    #endregion
    #region Rejse ViewModel Region
    class NyRejseViewModel
    {
        //Making a Entity Field, a Property of NyRejse, a Property of MainWindow and a Constructor
        VikingRejserEksamenEntities _rejseDb = new VikingRejserEksamenEntities();
        public NyRejse Window { get; set; }
        public MainWindow MainWindow { get; set; }
        public NyRejseViewModel(NyRejse window, MainWindow mainWindow)
        {
            Window = window;
            MainWindow = mainWindow;
        }
        //Below goes the Methods
        //Creating a new Vacation, and making sure you can't type anything wrong in it
        public void NewRejse()
        {
            try 
	        {
                Rejsearrangementer nyRejse = new Rejsearrangementer()
                {
                    //Making the columns equal the input fields text
                    Titel = Window.RejseTitel.Text,
                    By = Window.RejseBy.Text,
                    StartDato = (DateTime)Window.RejseStartDato.SelectedDate,
                    SlutDato = (DateTime)Window.RejseSlutDato.SelectedDate,
                    MaxDeltagere = int.Parse(Window.RejseMaxDeltagere.Text),
                    Transportoer = int.Parse(Window.RejseTransportoer.SelectedItem.ToString()),
                    RejseTilmeldinger = 0,
                    PrisPrDeltager = decimal.Parse(Window.PrisPrDeltager.Text),
                    Beskrivelse = Window.RejseBeskrivelse.Text
                };
                //Adding the new vacation to the _rejseDb entity
                _rejseDb.Rejsearrangementer.Add(nyRejse);
                //Saving the changes made to the database entity
                _rejseDb.SaveChanges();
                //Updating the Itemssource of the Datagrid
                MainWindow.rejsearrangementerDataGrid.ItemsSource = _rejseDb.Rejsearrangementer.ToList();
                Window.Hide();
            }
            //Catching the FormatException that comes from typing anything but a number into the MaxDeltagere textbox
	        catch (FormatException e)
	        {
                MessageBox.Show(e.Message,"Error",MessageBoxButton.OK,MessageBoxImage.Error);
	        }
        }
        //Method: Filling the Transporter Combobox so you can hire them for the vacation
        public void FillCombobox()
        {
            foreach (var item in _rejseDb.Transportoer)
            {
                Window.RejseTransportoer.Items.Add(item.Id);
            }
        }
    }
    #endregion
    #region Transportør ViewModel Region
    class NyTransportoerViewModel
    {
        //Making a Entity Field, a Property of NyTransportoer, a Property of MainWindow and a Constructor
        VikingRejserEksamenEntities _rejseDb = new VikingRejserEksamenEntities();
        public NyTransportoer Window { get; set; }
        public MainWindow MainWindow { get; set; }
        public NyTransportoerViewModel(NyTransportoer window, MainWindow mainWindow)
        {
            Window = window;
            MainWindow = mainWindow;
        }
        //Below are methods for the class
        //Method: Creates a new Entity of Transportoer
        public void NewTransportter()
        {
            try            
            {                
                Transportoer nyTransportør = new Transportoer()
                {
                    //Assigning the value of the textboxes to the new row that is being created
                    Navn = Window.TNavn.Text,
                    Adresse = Window.TAdresse.Text,
                    TelefonNr = Window.TTelefonNr.Text,
                    Bemaerkninger = Window.TBemærkninger.Text,                    
                };
                //Adding the entity to the _rejseDb field
                _rejseDb.Transportoer.Add(nyTransportør);

                //Saving the changes
                _rejseDb.SaveChanges();
                //Updating the Itemssource of the Datagrid
                MainWindow.transportoerDataGrid.ItemsSource = _rejseDb.Transportoer.ToList();
                //Hiding the Window
                Window.Hide();
            }
            //Catching the format exception so that you can't write something wrong.
            catch (FormatException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }        
    }
    #endregion
    #region Kunde ViewModel Class
    public class NyKundeViewModel
    {
        //Making a Entity Field, a Property of NyKunde, a Property of MainWindow and a Constructor
        VikingRejserEksamenEntities _rejseDb = new VikingRejserEksamenEntities();
        public NyKunde Window { get; set; }
        public MainWindow MainWindow { get; set; }
        public NyKundeViewModel(NyKunde window, MainWindow mainWindow)
        {
            Window = window;
            MainWindow = mainWindow;
        }
        //Below are the methods for the class
        //Method: Creating a new Entity for the database
        public void NewCustomer()
        {
            try
            {
                Kunder nyKunde = new Kunder()
                {
                    //Assigning the value of the textboxes to their respective entity columns
                    Navn = Window.KundeNavn.Text,
                    Adresse = Window.KundeAdresse.Text,
                    TelefonNr = Window.KundeTlfNr.Text                    
                };
                //Adding the entity to the field database
                _rejseDb.Kunder.Add(nyKunde);

                //Saving the changes
                _rejseDb.SaveChanges();
                //Updating the Itemssource of the Datagrid
                MainWindow.kunderDataGrid.ItemsSource = _rejseDb.Kunder.ToList();
                //Hiding the Window
                Window.Hide();
            }            
            //Catching the format exception so that you can't write something wrong.
            catch (FormatException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        public void NewCustomer2(string name, string adresse, string telefonnr)
        {
            try
            {
                Kunder nyKunde = new Kunder()
                {
                    //Assigning the value of the textboxes to their respective entity columns
                    Navn = name,
                    Adresse = adresse,
                    TelefonNr = telefonnr
                };
                //Adding the entity to the field database
                _rejseDb.Kunder.Add(nyKunde);

                //Saving the changes
                _rejseDb.SaveChanges();
                //Updating the Itemssource of the Datagrid
                MainWindow.kunderDataGrid.ItemsSource = _rejseDb.Kunder.ToList();
                //Hiding the Window
                Window.Hide();
            }
            //Catching the format exception so that you can't write something wrong.
            catch (FormatException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
    #endregion
    #region Tilmelding ViewModel Class
    class NyTilmeldingViewModel
    {
        //Making a Entity Field, a Property of NyTransportoer, a Property of MainWindow and a Constructor
        VikingRejserEksamenEntities _rejseDb = new VikingRejserEksamenEntities();
        public NyTilmelding Window { get; set; }
        public MainWindow MainWindow { get; set; }
        public NyTilmeldingViewModel(NyTilmelding window, MainWindow mainWindow)
        {
            Window = window;
            MainWindow = mainWindow;
        }
        //Below are methods for the class
        //Method: Creates a new entity for Tilmelding
        public void NewEnrollment()
        {
            try
            {
                //Converting the selecteditems to strings and then to ints
                int KundeId = (int)long.Parse(Window.KundeId.SelectedItem.ToString());
                int RejseId = (int)long.Parse(Window.RejseId.SelectedItem.ToString());
                RejseTilmeldinger nyTilmelding = new RejseTilmeldinger()
                {
                    //Assigning the value of the selected combobox items, after looking for the item with the same Id in the _rejseDb field
                    Kunde = _rejseDb.Kunder.Where(o => o.Id == KundeId).Single().Id,
                    Rejse = _rejseDb.Rejsearrangementer.Where(o => o.Id == RejseId).Single().Id
                };
                //Adding the new Tilmelding to the _rejseDb field
                _rejseDb.RejseTilmeldinger.Add(nyTilmelding);
                //Saving the changes
                _rejseDb.SaveChanges();
                //Hiding the Window
                Window.Hide();
            }
            //Catching any format exceptions that may rise
            catch (FormatException e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        //Method: Filling the combobox with their respective id's
        public void FillCombobox()
        {
            foreach (var row in _rejseDb.Kunder)
            {
                Window.KundeId.Items.Add(row.Id);
            }
            foreach (var row in _rejseDb.Rejsearrangementer)
            {
                Window.RejseId.Items.Add(row.Id);                
            }            
        }
    }

    class Tilmdelding
    {
        //Making a Entity Field, a Property of NyTransportoer, a Property of MainWindow and a Constructor
        VikingRejserEksamenEntities _rejseDb = new VikingRejserEksamenEntities();
        public Tilmeldinger Window { get; set; }
        public MainWindow MainWindow { get; set; }
        public Tilmdelding(Tilmeldinger window, MainWindow mainWindow)
        {
            Window = window;
            MainWindow = mainWindow;
        }
        //Below are methods for the class
        //Method: Filling Datagrid based on the selected Rejse
        public void FillDataGrid()
        {
            List<RejseTilmeldinger> Tilmeldinger = new List<RejseTilmeldinger>();
            RejseTilmeldinger newTilmelding = (RejseTilmeldinger)_rejseDb.RejseTilmeldinger.Where(o => o.Rejsearrangementer == MainWindow.rejsearrangementerDataGrid.SelectedItem);
            if (newTilmelding == MainWindow.rejsearrangementerDataGrid.SelectedItem)
            {
                Tilmeldinger.Add(newTilmelding);

            }                
            
            Window.rejseTilmeldingerDataGrid.ItemsSource = Tilmeldinger;
        }
    }
    #endregion
    #region API Region, containing everything for the API
    class API
    {
        //Making a Entity Field, a Property of MainWindow and a Constructor
        VikingRejserEksamenEntities _rejseDb = new VikingRejserEksamenEntities();
        public MainWindow Window { get; set; }
        public API(MainWindow window)
        {
            Window = window;
        }
        //Creating fields for holding the data
        public double temperature;
        public double temperatureMin;
        public double temperatureMax;
        public string description;
        public DateTime date;
        public string mainWeather;
        public string city;
        public void GetWeather()
        {
            //Assigning the city of the selecteditem in the datagrid
            city = _rejseDb.Rejsearrangementer.Where(o=>o.By == Window.rejsearrangementerDataGrid.SelectedItem.ToString()).Single().By;
            //Assigning the url of the API Call
            string url = $"https://api.openweathermap.org/data/2.5/forecast/daily?q={city}&units=metric&cnt=7&appid=8ce4b97528c5e39547a6d10a919c79d0";
            try
            {
                //WebRequest for getting the json text
                WebRequest requestObject = WebRequest.Create(url);
                //Making sure it's using the same method
                requestObject.Method = "GET";
                //Getting the responseobject ready
                HttpWebResponse responseObject = null;
                //Capturing the response in the response object
                responseObject = (HttpWebResponse)requestObject.GetResponse();

                //Creating jsonResult and reading the resonse object while also assigning the response object's response to the jsonResult variable
                string jsonResult;
                using (Stream myStream = responseObject.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(myStream);
                    jsonResult = sr.ReadToEnd();
                    sr.Close();
                }
                //Breaking the Json into smaller biTs that can be targeted and assigned to our fields
                Root myRoot = JsonConvert.DeserializeObject<Root>(jsonResult);
                temperature = myRoot.main.temp;
                temperatureMin = myRoot.main.temp_min;
                temperatureMax = myRoot.main.temp_max;
                description = myRoot.weather.description;
                mainWeather = myRoot.weather.main;
                date = new DateTime(1970, 1, 1).AddMilliseconds(myRoot.dt);

            }
            catch (global::System.Exception)
            {

                throw;
            }
        }
        //Filling the temperature labels
        public void FillTemperature()
        {
            Window.Temperature.Content = temperature;
            Window.MinTemperature.Content = temperatureMin;
            Window.MaxTemperature.Content = temperatureMax;
            Window.Weather.Content = mainWeather + " " + description;
        }
    }

    //Creating the deserialization properties
    public class Root
    {
        public Main main { get; set; }
        public Weather weather { get; set; }
        public int dt { get; set; }
    }
    
    public class Main
    {
        
        public double temp { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }
    public class Weather
    {
        public string main { get; set; }
        public string description { get; set; }
    }
    #endregion
}
