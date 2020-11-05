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
    }
}
