using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsportDanmark_PEO.ViewModel
{
    #region MainWindowViewModel, the ViewModel class for MainWindow
    public class MainWindowViewModel
    {
        Model.EsportDanmarkEntities _esportDb = new Model.EsportDanmarkEntities();
        public MainWindow Window { get; set; }
        public MainWindowViewModel(MainWindow window)
        {
            Window = window;
        }
    }
    #endregion
    #region PlayerDataViewModel, the ViewModel class for PlayerData
    public class PlayerDataViewModel
    {
        Model.EsportDanmarkEntities _esportDb = new Model.EsportDanmarkEntities();
        public PlayerData Window { get; set; }
        public PlayerDataViewModel(PlayerData window)
        {
            Window = window;
        }
    }
    #endregion
    #region EmployeesDataViewModel, the ViewModel class for EmployeesData
    public class EmployeesDataViewModel
    {
        Model.EsportDanmarkEntities _esportDb = new Model.EsportDanmarkEntities();
        public EmployeeData Window { get; set; }
        public EmployeesDataViewModel(EmployeeData window)
        {
            Window = window;
        }
    }
    #endregion
    #region TournamentDataViewModel, the ViewModel class for TournamentData
    public class TournamentDataViewModel
    {
        Model.EsportDanmarkEntities _esportDb = new Model.EsportDanmarkEntities();
        public TournamentData Window { get; set; }
        public TournamentDataViewModel(TournamentData window)
        {
            Window = window;
        }
    }
    #endregion
    public class SponsorDataViewModel
    {
        Model.EsportDanmarkEntities _esportDb = new Model.EsportDanmarkEntities();
        public SponsorData Window { get; set; }
        public SponsorDataViewModel(SponsorData window)
        {
            Window = window;
        }
    }
}
