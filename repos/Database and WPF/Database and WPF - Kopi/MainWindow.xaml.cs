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

namespace Database_and_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Making a new database entity for storing data
        MovieDatabaseEntities _db = new MovieDatabaseEntities();
        //Making a placeholder Datagrid for holding the data
        public static DataGrid datagrid;
        public MainWindow()
        {
            InitializeComponent();            
        }


        private void MovieGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Code used for loading the data of the Data-first EntityFramework
            Database_and_WPF.MovieDatabaseDataSet movieDatabaseDataSet = ((Database_and_WPF.MovieDatabaseDataSet)(this.FindResource("movieDatabaseDataSet")));
            // Load data into the table Movies. You can modify this code as needed.
            Database_and_WPF.MovieDatabaseDataSetTableAdapters.MoviesTableAdapter movieDatabaseDataSetMoviesTableAdapter = new Database_and_WPF.MovieDatabaseDataSetTableAdapters.MoviesTableAdapter();
            movieDatabaseDataSetMoviesTableAdapter.Fill(movieDatabaseDataSet.Movies);
            System.Windows.Data.CollectionViewSource moviesViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("moviesViewSource")));
            moviesViewSource.View.MoveCurrentToFirst();
            //Adding the items to the database entities Movies list
            moviesDataGrid.ItemsSource = _db.Movies.ToList();
            //Making the placeholder Datagrid hold the information from the main MoviesDatagrid
            datagrid = moviesDataGrid;
        }

        //Insertbutton click event
        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            //creating a new instance of the Insertpage window
            InsertPage Ipage = new InsertPage();
            //Opening up the insertpage window
            Ipage.ShowDialog();
        }

        //Updatebutton click event
        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            //Making sure that the selected item is the item that is updated
            int id = (moviesDataGrid.SelectedItem as Movies).Id;
            //Failed name, should have been UpdatePage
            Window1 Upage = new Window1(id);
            //Opening the update page window
            Upage.ShowDialog();
        }

        //Deletebutton click event
        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            //Making sure that the selected item is the item that is updated
            int id = (moviesDataGrid.SelectedItem as Movies).Id;
            //Creating a deletemovies variable, that can delete the single selected row
            var deleteMovies = _db.Movies.Where(movies => movies.Id == id).Single();
            //Using the deletemovies variable to delete a row
            _db.Movies.Remove(deleteMovies);
            //Saving the changes so it get's updated on the datagrid
            _db.SaveChanges();
            //Adding the changes and entities to the real database
            moviesDataGrid.ItemsSource = _db.Movies.ToList();
        }
    }
}
