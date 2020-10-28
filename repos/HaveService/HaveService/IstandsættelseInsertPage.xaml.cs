using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Interaction logic for IstandsættelseInsertPage.xaml
    /// </summary>
    public partial class IstandsættelseInsertPage : Window
    {
        //Variables and entitie instances created for the sake of using them in the program. 
        //istandDB is a placeholder Database instance, id is a placeholder for the real Id, hasSucceeded is a bool variable made for UnitTesting 
        HaveService.HaveserviceEntities _istandDb = new HaveService.HaveserviceEntities();
        int id;
        public bool hasSucceeded = false;
        public IstandsættelseInsertPage(int istandsættelsesId)
        {
            InitializeComponent();
            //Variable for containing the Id
            id = istandsættelsesId;
        }

        public void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            //Method used in unit testing, other instances of this type of event doesn't look like this
            insertBtn();
        }

        public void insertBtn()
        {
            //Making a new movie entity
            HaveService.Istandsættelse nyOrdre = new HaveService.Istandsættelse()
            {
                //Making the columns equal the input fields text
                Kundeadresse = IstandsættelseAdresse.Text,
                Start_Dato = (DateTime)IstandsættelseStartDato.SelectedDate,
                Slut_Dato = (DateTime)IstandsættelseSlutDato.SelectedDate,
                Pris = int.Parse(IstandsættelsePris.Text),
                Areal_Af_Have = int.Parse(IstandsættelseArealAfHave.Text),
                Beskrivelse_af_Opgave = IstandsættelseBAO.Text,
            };
            //For Unit Testing
            if (nyOrdre.Kundeadresse == IstandsættelseAdresse.Text)
            {
                hasSucceeded = true;
            }
            //Adding the new movie to the Movies table
            _istandDb.Istandsættelse.Add(nyOrdre);
            //Saving the changes made to the database entity
            _istandDb.SaveChanges();
            //Adding the changes and all other table data to the datagrid
            MainWindow.Istanddatagrid.ItemsSource = _istandDb.Istandsættelse.ToList();
            //Hiding the window
            this.Hide();
        }

        private void IstandsættelseOpdaterBtn_Click(object sender, RoutedEventArgs e)
        {
            //If statement that prevents updating a row if the inputs are empty
            if (OpdaterPris.Text.Any(char.IsDigit) == true && OpdaterArealAfHave.Text.Any(char.IsDigit) == true && !(OpdaterSlutDato.SelectedDate == null || OpdaterStartDato.SelectedDate == null || OpdaterPris.Text == "" || OpdaterArealAfHave.Text == "" || OpdaterBAO.Text == ""))
            {
                //opdateretOrdre is an action where m is a ordre entity
                //in the Istandsættelse table
                //It selects a ordre which has the same id as the variable we made earlier
                //And only selects one ordre*
                HaveService.Istandsættelse opdateretOrdre = (from i in _istandDb.Istandsættelse
                                                     where i.Id == id
                                                     select i).Single();
                //Updating the movie columns with the text that is written in the input fields of the updatepage
                opdateretOrdre.Start_Dato = (DateTime)OpdaterStartDato.SelectedDate;
                opdateretOrdre.Slut_Dato = (DateTime)OpdaterSlutDato.SelectedDate;
                opdateretOrdre.Pris = int.Parse(OpdaterPris.Text);
                opdateretOrdre.Areal_Af_Have = int.Parse(OpdaterArealAfHave.Text);
                opdateretOrdre.Beskrivelse_af_Opgave = OpdaterBAO.Text;
            }
            //Saving the changes to the database
            _istandDb.SaveChanges();
            //Adding the changes to the list of movies
            MainWindow.Istanddatagrid.ItemsSource = _istandDb.Istandsættelse.ToList();
            //Hiding the window
            this.Hide();
        }
    }
}
