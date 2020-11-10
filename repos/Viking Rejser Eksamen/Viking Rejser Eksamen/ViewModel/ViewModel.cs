using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking_Rejser_Eksamen.Model;
using Viking_Rejser_Eksamen.View;

namespace Viking_Rejser_Eksamen.ViewModel
{
    #region MainWindow ViewModel Region
    class MainWindowViewModel
    {
        VikingRejserEksamenEntities _rejseDb = new VikingRejserEksamenEntities();        
        public MainWindow Window { get; set; }
        public MainWindowViewModel(MainWindow window)
        {
            Window = window;           
        }

        public void OpenNewRejseWindow()
        {
            NyRejse newWindow = new NyRejse(Window);
            newWindow.ShowDialog();
        }

        public void OpenNewCustomerWindow()
        {
            NyKunde newWindow = new NyKunde(Window);
            newWindow.ShowDialog();
        }

        public void OpenNewTransporterWindow()
        {
            NyTransportoer newWindow = new NyTransportoer(Window);
            newWindow.ShowDialog();
        }

        public void OpenNewEnrollmentWindow()
        {
            NyTilmelding newWindow = new NyTilmelding();
            newWindow.ShowDialog();
        }        
    }
    #endregion
    #region Rejse ViewModel Region
    class NyRejseViewModel
    {
        VikingRejserEksamenEntities _rejseDb = new VikingRejserEksamenEntities();
        public NyRejse Window { get; set; }
        public MainWindow MainWindow { get; set; }
        public NyRejseViewModel(NyRejse window, MainWindow mainWindow)
        {
            Window = window;
            MainWindow = mainWindow;
        }
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
                    /*                  Transportoer = int.Parse(Window.RejseTransportoer.SelectedItem.ToString()),*/
                    RejseTilmeldinger = 0,
                    PrisPrDeltager = decimal.Parse(Window.PrisPrDeltager.Text),
                    Beskrivelse = Window.RejseBeskrivelse.Text
                };
                //Adding the new movie to the Movies table
                _rejseDb.Rejsearrangementer.Add(nyRejse);
                //Saving the changes made to the database entity
                MainWindow.rejsearrangementerDataGrid.ItemsSource = _rejseDb.Rejsearrangementer.ToList();
                _rejseDb.SaveChanges();
                Window.Hide();
            }
	        catch (FormatException)
	        {

		        throw;
	        }
        }
    }
    #endregion
    #region Transportør ViewModel Region
    class NyTransportoerViewModel
    {
        VikingRejserEksamenEntities _rejseDb = new VikingRejserEksamenEntities();
        public NyTransportoer Window { get; set; }
        public MainWindow MainWindow { get; set; }
        public NyTransportoerViewModel(NyTransportoer window, MainWindow mainWindow)
        {
            Window = window;
            MainWindow = mainWindow;
        }

        public void NewTransportter()
        {
            try
            {
                Transportoer nyTransportør = new Transportoer()
                {
                    Navn = Window.TNavn.Text,
                    Adresse = Window.TAdresse.Text,
                    TelefonNr = Window.TTelefonNr.Text,
                    Bemaerkninger = Window.TBemærkninger.Text,                    
                };
                _rejseDb.Transportoer.Add(nyTransportør);

                MainWindow.transportoerDataGrid.ItemsSource = _rejseDb.Transportoer.ToList();

                _rejseDb.SaveChanges();
                Window.Hide();
            }
            catch (FormatException)
            {

                throw;
            }
        }
    }
    #endregion
    #region Kunde ViewModel Class
    class NyKundeViewModel
    {
        VikingRejserEksamenEntities _rejseDb = new VikingRejserEksamenEntities();
        public NyKunde Window { get; set; }
        public MainWindow MainWindow { get; set; }
        public NyKundeViewModel(NyKunde window, MainWindow mainWindow)
        {
            Window = window;
            MainWindow = mainWindow;
        }

        public void NewCustomer()
        {
            try
            {
                Kunder nyKunde = new Kunder()
                {
                    Navn = Window.KundeNavn.Text,
                    Adresse = Window.KundeAdresse.Text,
                    TelefonNr = Window.KundeTlfNr.Text                    
                };
                _rejseDb.Kunder.Add(nyKunde);

                MainWindow.kunderDataGrid.ItemsSource = _rejseDb.Kunder.ToList();

                _rejseDb.SaveChanges();
                Window.Hide();
            }
            catch (FormatException)
            {

                throw;
            }
        }
    }
    #endregion
}
