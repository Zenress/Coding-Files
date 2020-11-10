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
using Viking_Rejser_Eksamen.ViewModel;

namespace Viking_Rejser_Eksamen.View
{
    /// <summary>
    /// Interaction logic for Tilmeldinger.xaml
    /// </summary>
    public partial class Tilmeldinger : Window
    {
        private readonly Tilmdelding viewModel;
        public Tilmeldinger(MainWindow mainWindow)
        {
            InitializeComponent();
            viewModel = new Tilmdelding(this, mainWindow);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Viking_Rejser_Eksamen.Model.VikingRejserEksamenDataSet vikingRejserEksamenDataSet = ((Viking_Rejser_Eksamen.Model.VikingRejserEksamenDataSet)(this.FindResource("vikingRejserEksamenDataSet")));
            // Load data into the table RejseTilmeldinger. You can modify this code as needed.
            Viking_Rejser_Eksamen.Model.VikingRejserEksamenDataSetTableAdapters.RejseTilmeldingerTableAdapter vikingRejserEksamenDataSetRejseTilmeldingerTableAdapter = new Viking_Rejser_Eksamen.Model.VikingRejserEksamenDataSetTableAdapters.RejseTilmeldingerTableAdapter();
            vikingRejserEksamenDataSetRejseTilmeldingerTableAdapter.Fill(vikingRejserEksamenDataSet.RejseTilmeldinger);
            System.Windows.Data.CollectionViewSource rejseTilmeldingerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("rejseTilmeldingerViewSource")));
            rejseTilmeldingerViewSource.View.MoveCurrentToFirst();
        }
    }
}
