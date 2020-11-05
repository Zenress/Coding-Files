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
    /// Interaction logic for EmployeeData.xaml
    /// </summary>
    public partial class EmployeeData : Window
    {
        private readonly EmployeesDataViewModel viewModel;
        public EmployeeData()
        {
            InitializeComponent();
            viewModel = new EmployeesDataViewModel(this);
        }
    }
}
