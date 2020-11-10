using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Viking_Rejser_Eksamen.Model;

namespace Viking_Rejser_Eksamen.ViewModel
{
    class MainWindowViewModel
    {
        VikingRejserEksamenEntities _rejseDb = new VikingRejserEksamenEntities();        
        public MainWindow Window { get; set; }
        public MainWindowViewModel(MainWindow window)
        {
            Window = window;           
        }
    }
}
