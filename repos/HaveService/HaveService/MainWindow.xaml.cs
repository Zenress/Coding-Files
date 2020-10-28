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
using System.Collections.ObjectModel;
using System.Data.SqlClient;

namespace HaveService
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// Major Problems: 
    /// Identity Auto Increment Jump, A Windows SQL Server Instance "Feature", Cannot be turned off because of
    /// Invalid installation of SQL Server Management Studio. Could be fixed on another pc
    public partial class MainWindow : Window
    {
        //Making a new database entity for storing data
        HaveService.HaveserviceEntities _kundeDb = new HaveService.HaveserviceEntities();
        HaveService.HaveserviceEntities _lauDb = new HaveService.HaveserviceEntities();
        HaveService.HaveserviceEntities _istandDb = new HaveService.HaveserviceEntities();
        //Making a placeholder Datagrid for holding the data
        public static DataGrid Kundedatagrid;
        public static DataGrid Istanddatagrid;
        public static DataGrid Laudatagrid;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {            
            HaveService.HaveserviceDataSet haveserviceDataSet = ((HaveService.HaveserviceDataSet)(this.FindResource("haveserviceDataSet")));
            //Data Entries for the Table = KunderTable
            // Load data into the table Kunder. You can modify this code as needed.
            HaveService.HaveserviceDataSetTableAdapters.KunderTableAdapter haveserviceDataSetKunderTableAdapter = new HaveService.HaveserviceDataSetTableAdapters.KunderTableAdapter();
            haveserviceDataSetKunderTableAdapter.Fill(haveserviceDataSet.Kunder);
            System.Windows.Data.CollectionViewSource kunderViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("kunderViewSource")));
            kunderViewSource.View.MoveCurrentToFirst();

            //Data Entries for the Table = Lejning Af Udstyr
            // Load data into the table LejningAfUdstyr. You can modify this code as needed.
            HaveService.HaveserviceDataSetTableAdapters.LejningAfUdstyrTableAdapter haveserviceDataSetLejningAfUdstyrTableAdapter = new HaveService.HaveserviceDataSetTableAdapters.LejningAfUdstyrTableAdapter();
            haveserviceDataSetLejningAfUdstyrTableAdapter.Fill(haveserviceDataSet.LejningAfUdstyr);
            System.Windows.Data.CollectionViewSource lejningAfUdstyrViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("lejningAfUdstyrViewSource")));
            lejningAfUdstyrViewSource.View.MoveCurrentToFirst();

            //Data Entries for the Table = Istandsættelse
            // Load data into the table Istandsættelse. You can modify this code as needed.
            HaveService.HaveserviceDataSetTableAdapters.IstandsættelseTableAdapter haveserviceDataSetIstandsættelseTableAdapter = new HaveService.HaveserviceDataSetTableAdapters.IstandsættelseTableAdapter();
            haveserviceDataSetIstandsættelseTableAdapter.Fill(haveserviceDataSet.Istandsættelse);
            System.Windows.Data.CollectionViewSource istandsættelseViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("istandsættelseViewSource")));
            istandsættelseViewSource.View.MoveCurrentToFirst();

            //Adding the data from the grid into the Lists of each of the entitie Databases
            kunderDataGrid.ItemsSource = _kundeDb.Kunder.ToList();
            lauDataGrid.ItemsSource = _lauDb.LejningAfUdstyr.ToList();
            istandsættelseDataGrid.ItemsSource = _istandDb.Istandsættelse.ToList();

            //Making the palceholder datagrids hold the data of the real datagrids, for cross access use in other files
            Kundedatagrid = kunderDataGrid;
            Laudatagrid = lauDataGrid;
            Istanddatagrid = istandsættelseDataGrid;
        }

        private void KunderinsertBtn_Click(object sender, RoutedEventArgs e)
        {
            //Making the currently selected item's Id the same as the Id of the variable
            int id = (kunderDataGrid.SelectedItem as HaveService.Kunder).Id;

            //creating a new instance of the Insertpage window
            KunderInsertPage KunderIpage = new KunderInsertPage(id);

            //Opening the created window
            KunderIpage.ShowDialog();                       
        }

        private void LejningInsertBtn_Click(object sender, RoutedEventArgs e)
        {
            //Using a try catch to try and catch if the Id code doesn't work, As the default is only selected on the Kunder Table, no default is selected in the Lejning Af Udstyr Table
            try
            {
                //Making the currently selected item's Id the same as the Id of the variable
                int id2 = (lauDataGrid.SelectedItem as HaveService.LejningAfUdstyr).Id;

                //Creating a new instance of the insertpage window
                Leje_af_udstyrInsertPage LAUIpage = new Leje_af_udstyrInsertPage(id2);

                //Opening the created window
                LAUIpage.ShowDialog();
            }
            catch (NullReferenceException)
            {
                //Making the error message
                errorMsg.Content = "Please select an item";                
            }
        }             

        private void IstandsættelseInsertBtn_Click(object sender, RoutedEventArgs e)
        {
            //Using a try catch to try and catch if the Id code doesn't work, As the default is only selected on the Kunder Table, no default is selected in the Istandsættelse Table
            try
            {
                int id3 = (istandsættelseDataGrid.SelectedItem as HaveService.Istandsættelse).Id;

                //creating a new instance of the Insertpage window
                IstandsættelseInsertPage IstandsættelseIpage = new IstandsættelseInsertPage(id3);

                //Opening up the insertpage window
                IstandsættelseIpage.ShowDialog();      
            }
            catch (NullReferenceException)
            {
                //Making the error message
                errorMsg.Content = "Please select an item";
            }
        }

        private void KunderdeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //Making sure that the selected item is the item that is updated
            int id = (kunderDataGrid.SelectedItem as HaveService.Kunder).Id;
            string adresse = (istandsættelseDataGrid.SelectedItem as HaveService.Istandsættelse).Kundeadresse;
            string kunderAdresse = (kunderDataGrid.SelectedItem as HaveService.Kunder).Adresse;

            //Creating a deleteKunde and deleteDependency variable, that can delete the single selected rows
            var deleteKunde = _kundeDb.Kunder.Where(kunder => kunder.Id == id).Single();
            var deleteDependency = _istandDb.Istandsættelse.Where(istandsættelse => istandsættelse.Kundeadresse == kunderAdresse).Single();

            //Using the deleteKunde and deleteDependency variable to delete the rows
            _istandDb.Istandsættelse.Remove(deleteDependency);
            _kundeDb.Kunder.Remove(deleteKunde);

            //Saving the changes so it get's updated on the datagrid
            _istandDb.SaveChanges();
            _kundeDb.SaveChanges();

            //Adding the changes and entities to the real database
            istandsættelseDataGrid.ItemsSource = _istandDb.Istandsættelse.ToList();
            kunderDataGrid.ItemsSource = _kundeDb.Kunder.ToList();
        }

        private void IstandsættelseDeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //Making sure that the selected item is the item that is updated
            int id = (istandsættelseDataGrid.SelectedItem as HaveService.Istandsættelse).Id;

            //Creating a deleteOrdre variable, that can delete the single selected row
            var deleteOrdre = _istandDb.Istandsættelse.Where(ordre => ordre.Id == id).Single();

            //Using the deleteOrdre variable to delete a row
            _istandDb.Istandsættelse.Remove(deleteOrdre);

            //Saving the changes so it get's updated on the datagrid
            _istandDb.SaveChanges();

            //Adding the changes and entities to the real database
            istandsættelseDataGrid.ItemsSource = _istandDb.Istandsættelse.ToList();
        }

        private void LejningDeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //Making sure that the selected item is the item that is updated
            int id = (lauDataGrid.SelectedItem as HaveService.LejningAfUdstyr).Id;

            //Creating a deleteOrdre variable, that can delete the single selected row
            var deleteOrdre = _lauDb.LejningAfUdstyr.Where(ordre => ordre.Id == id).Single();

            //Using the deleteOrdre variable to delete a row
            _lauDb.LejningAfUdstyr.Remove(deleteOrdre);

            //Saving the changes so it get's updated on the datagrid
            _lauDb.SaveChanges();

            //Adding the changes and entities to the real database
            lauDataGrid.ItemsSource = _lauDb.LejningAfUdstyr.ToList();
        }
    }
}
