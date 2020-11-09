using EsportDanmark_PEO.ViewModel;
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

namespace EsportDanmark_PEO
{
    /// <summary>
    /// Interaction logic for SponsorData.xaml
    /// </summary>
    public partial class SponsorData : Window
    {
        private readonly SponsorDataViewModel viewModel;
        public SponsorData()
        {
            InitializeComponent();
            viewModel = new SponsorDataViewModel(this);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            EsportDanmark_PEO.Model.EsportDanmarkDataSet esportDanmarkDataSet = ((EsportDanmark_PEO.Model.EsportDanmarkDataSet)(this.FindResource("esportDanmarkDataSet")));
            // Load data into the table Sponsorer. You can modify this code as needed.
            EsportDanmark_PEO.Model.EsportDanmarkDataSetTableAdapters.SponsorerTableAdapter esportDanmarkDataSetSponsorerTableAdapter = new EsportDanmark_PEO.Model.EsportDanmarkDataSetTableAdapters.SponsorerTableAdapter();
            esportDanmarkDataSetSponsorerTableAdapter.Fill(esportDanmarkDataSet.Sponsorer);
            System.Windows.Data.CollectionViewSource sponsorerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("sponsorerViewSource")));
            sponsorerViewSource.View.MoveCurrentToFirst();
        }

        private void Check_Click(object sender, RoutedEventArgs e)
        {
            viewModel.SponserAmount();
        }
    }
}
