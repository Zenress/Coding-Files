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

namespace EsportDanmark_PEO.View
{
    /// <summary>
    /// Interaction logic for SummonerCheck.xaml
    /// </summary>
    public partial class SummonerCheck : Window
    {
        public readonly RiotApi viewModel;        
        public SummonerCheck()
        {            
            InitializeComponent();
            viewModel = new RiotApi(this);
            RegionSelect.Items.Add("EUW1");
            RegionSelect.Items.Add("EUN1");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.GetSummoner(InputField.Text);
        }
    }
}
