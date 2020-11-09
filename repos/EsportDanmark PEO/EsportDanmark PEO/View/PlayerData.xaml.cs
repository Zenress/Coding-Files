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
    /// Interaction logic for PlayerData.xaml
    /// </summary>
    public partial class PlayerData : Window
    {
        private readonly PlayerDataViewModel viewModel;
        public PlayerData()
        {
            InitializeComponent();
            viewModel = new PlayerDataViewModel(this);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            EsportDanmark_PEO.Model.EsportDanmarkDataSet esportDanmarkDataSet = ((EsportDanmark_PEO.Model.EsportDanmarkDataSet)(this.FindResource("esportDanmarkDataSet")));
            // Load data into the table Players. You can modify this code as needed.
            EsportDanmark_PEO.Model.EsportDanmarkDataSetTableAdapters.PlayersTableAdapter esportDanmarkDataSetPlayersTableAdapter = new EsportDanmark_PEO.Model.EsportDanmarkDataSetTableAdapters.PlayersTableAdapter();
            esportDanmarkDataSetPlayersTableAdapter.Fill(esportDanmarkDataSet.Players);
            System.Windows.Data.CollectionViewSource playersViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("playersViewSource")));
            playersViewSource.View.MoveCurrentToFirst();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.OpenWindow();
        }
    }
}
