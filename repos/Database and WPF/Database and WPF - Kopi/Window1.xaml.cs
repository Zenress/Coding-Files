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
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// //Naming fail. The real name of the window should have been UpdatePage
    public partial class Window1 : Window
    {
        MovieDatabaseEntities _db = new MovieDatabaseEntities();        
        int id;
        public Window1(int moviesId)
        {
            InitializeComponent();
            //Making the id variable we made hold the value of moviesId(Used as a placeholder for the database.Id)
            id = moviesId;            
        }

        //Updatebutton click event
        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            //If statement that prevents updating a row if the inputs are empty
            if (!(movieName.Text == "" || movieReleaseYear.Text == null || movieGenre.Text == "" || movieInstructor.Text == "" || movieActors.Text == ""))
            {
                //Updatemovie is an action where m is a movie entity
                //in the Movies table
                //It selects a movie which has the same id as the variable we made earlier
                //And only selects one movie*
                Movies updateMovie = (from m in _db.Movies
                                     where m.Id == id
                                     select m).Single();
                //Updating the movie columns with the text that is written in the input fields of the updatepage
                updateMovie.MovieName = movieName.Text;
                updateMovie.ReleaseYear = int.Parse(movieReleaseYear.Text);
                updateMovie.Genre = movieGenre.Text;
                updateMovie.Instructor = movieInstructor.Text;
                updateMovie.Actors = movieActors.Text;
            }
            //Saving the changes to the database
            _db.SaveChanges();
            //Adding the changes to the list of movies
            MainWindow.datagrid.ItemsSource = _db.Movies.ToList();
            //Hiding the window
            this.Hide();
        }
    }
}
