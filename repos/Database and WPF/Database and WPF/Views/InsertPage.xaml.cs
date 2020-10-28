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

namespace Database_and_WPF
{
    /// <summary>
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Window
    {
        //Making a database entity
        Entities.MovieDatabaseEntities _db = new Entities.MovieDatabaseEntities();
        public InsertPage()
        {
            InitializeComponent();
        }

        //Insertbutton click event
        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            //Making a new movie entity
            Entities.Movies newMovie = new Entities.Movies()
            {                
                //Making the columns equal the input fields text
                MovieName = movieName.Text,
                ReleaseYear = int.Parse(movieReleaseYear.Text),
                Genre = movieGenre.Text,
                Instructor = movieInstructor.Text,
                Actors = movieActors.Text
            };
            //Adding the new movie to the Movies table
            _db.Movies.Add(newMovie);
            //Saving the changes made to the database entity
            _db.SaveChanges();
            //Adding the changes and all other table data to the datagrid
            MainWindow.datagrid.ItemsSource = _db.Movies.ToList();
            //Hiding the window
            this.Hide();
        }
    }
}
