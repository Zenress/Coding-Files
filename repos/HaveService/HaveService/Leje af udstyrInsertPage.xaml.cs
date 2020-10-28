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
    /// Interaction logic for Leje_af_udstyrInsertPage.xaml
    /// </summary>
    public partial class Leje_af_udstyrInsertPage : Window
    {
        //Creating an entitie database for storing the rows of data, and creating a Id placeholder variable
        HaveService.HaveserviceEntities _lauDb = new HaveService.HaveserviceEntities();
        int id;
        public Leje_af_udstyrInsertPage(int ordreId)
        {
            //Assigning the value of the placeholder variable
            InitializeComponent();
            id = ordreId;
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            //Making a new movie entity
            HaveService.LejningAfUdstyr nyOrdre = new HaveService.LejningAfUdstyr()
            {
                //Making the columns equal the input fields text
                Navn = OrdreNavn.Text,
                Adresse = OrdreAdresse.Text,
                Bemærkninger = OrdreBemærkninger.Text                
            };
            //Adding the new movie to the Movies table
            _lauDb.LejningAfUdstyr.Add(nyOrdre);
            //Saving the changes made to the database entity
            _lauDb.SaveChanges();
            //Adding the changes and all other table data to the datagrid
            MainWindow.Laudatagrid.ItemsSource = _lauDb.LejningAfUdstyr.ToList();
            //Hiding the window
            this.Hide();
        }

        private void OpdaterBtn_Click(object sender, RoutedEventArgs e)
        {
            //If statement that prevents updating a row if the inputs are empty
            if (!(OpdaterAdresse.Text == "" || OpdaterBemærkninger.Text == ""))
            {
                //opdateretOrdre is an action where o is an ordre entity
                //in the Ordre table
                //It selects a Ordre which has the same id as the variable we made earlier
                //And only selects one ordre*
                HaveService.LejningAfUdstyr opdateretOrdre = (from o in _lauDb.LejningAfUdstyr
                                                     where o.Id == id
                                                     select o).Single();
                //Updating the ordre columns with the text that is written in the input fields of the updatepage
                opdateretOrdre.Adresse = OpdaterAdresse.Text;
                opdateretOrdre.Bemærkninger = OpdaterBemærkninger.Text;                
            }
            //Saving the changes to the database
            _lauDb.SaveChanges();
            //Adding the changes to the list of movies
            MainWindow.Laudatagrid.ItemsSource = _lauDb.LejningAfUdstyr.ToList();
            //Hiding the window
            this.Hide();
        }
    }
}
