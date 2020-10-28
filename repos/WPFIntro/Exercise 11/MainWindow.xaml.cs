using System;
using System.Collections.Generic;
using System.IO;
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

namespace Exercise_11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Variables for the selected number, and a list for the images
        public int number = 0;
        private List<BitmapImage> Images = new List<BitmapImage>();
        public MainWindow()
        {
            InitializeComponent();
            //Using directory info to find the paths to
            DirectoryInfo dir_info = new DirectoryInfo("C:/Users/shan0382/Desktop/bilshow");
            foreach (FileInfo file_info in dir_info.GetFiles())
            {
                //If statement that only works as long as the item has .jpg at the end
                if (file_info.Extension.ToLower() == ".jpg")
                {
                    //Adding the bitmapImages to the Images list
                    Images.Add(new BitmapImage(new Uri(file_info.FullName)));
                }
            }                        
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {            
            //Plus 1 to the current selected image, making it go forward
            number++;
            myPicture.Source = Images[number];
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            //If statement for checking if you already are at the first picture
            if (!(number == 0))
            {
                //Minus 1 for the current selected image, making it go back
                number -= 1;
                myPicture.Source = Images[number];
            }
        }
    }
}
