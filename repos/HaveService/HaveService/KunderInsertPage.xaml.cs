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

namespace HaveService
{
    /// <summary>
    /// Interaction logic for KunderInsertPage.xaml
    /// </summary>
    public partial class KunderInsertPage : Window
    {
        HaveService.HaveserviceEntities _kundeDb = new HaveService.HaveserviceEntities();
        int id;
        public KunderInsertPage(int kundeId)
        {
            InitializeComponent();
            id = kundeId;
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            //Making a new movie entity
            HaveService.Kunder nyKunde = new HaveService.Kunder()
            {
                //Making the columns equal the input fields text
                Name = KundeNavn.Text,
                Adresse = KundeAdresse.Text,
                TelefonNr = KundeTelefonNr.Text,
                PostNr = int.Parse(KundePostNr.Text),
                OpgaveType = KundeOpgaveBeskrivelse.Text
            };
            //Adding the new movie to the Movies table
            _kundeDb.Kunder.Add(nyKunde);
            //Saving the changes made to the database entity
            _kundeDb.SaveChanges();
            //Adding the changes and all other table data to the datagrid
            MainWindow.Kundedatagrid.ItemsSource = _kundeDb.Kunder.ToList();
            //Hiding the window
            this.Hide();
        }

        private void OpdaterBtn_Click(object sender, RoutedEventArgs e)
        {
            //If statement that prevents updating a row if the inputs are empty
            if (!(OpdaterNavn.Text == "" || OpdaterTelefonNr.Text == "" || OpdaterPostNr.Text == "" || OpdaterOpgaveBeskrivelse.Text == ""))
            {
                //opdateretKunde is an action where m is a movie entity
                //in the Movies table
                //It selects a movie which has the same id as the variable we made earlier
                //And only selects one movie*
                HaveService.Kunder opdateretKunde = (from m in _kundeDb.Kunder
                                               where m.Id == id
                                               select m).Single();
                //Updating the movie columns with the text that is written in the input fields of the updatepage
                opdateretKunde.Name = OpdaterNavn.Text;               
                opdateretKunde.TelefonNr = OpdaterTelefonNr.Text;
                opdateretKunde.PostNr = int.Parse(OpdaterPostNr.Text);
                opdateretKunde.OpgaveType = OpdaterOpgaveBeskrivelse.Text;
            }
            //Saving the changes to the database
            _kundeDb.SaveChanges();
            //Adding the changes to the list of movies
            MainWindow.Kundedatagrid.ItemsSource = _kundeDb.Kunder.ToList();
            //Hiding the window
            this.Hide();
        }
    }
}
