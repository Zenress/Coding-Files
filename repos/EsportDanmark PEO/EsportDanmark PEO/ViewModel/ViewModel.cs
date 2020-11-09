using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using EsportDanmark_PEO.Model;
using EsportDanmark_PEO.View;
using Newtonsoft.Json;

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

        public void OpenPlayerDataBtn()
        {
            PlayerData newWindow = new PlayerData();
            newWindow.ShowDialog();
        }

        public void OpenEmployeesDataBtn()
        {
            EmployeeData newWindow = new EmployeeData();
            newWindow.ShowDialog();
        }

        public void OpenTournamentDataBtn()
        {
            TournamentData newWindow = new TournamentData();
            newWindow.ShowDialog();
        }

        public void OpenSponsorDataBtn()
        {
            SponsorData newWindow = new SponsorData();
            newWindow.ShowDialog();
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

        public void OpenWindow()
        {
            SummonerCheck newWindow = new SummonerCheck();
            newWindow.ShowDialog();            
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


    #region SponsorDataViewModel, the ViewModel class for SponsorData
    public class SponsorDataViewModel
    {
        Model.EsportDanmarkEntities _esportDb = new Model.EsportDanmarkEntities();
        public SponsorData Window { get; set; }
        public SponsorDataViewModel(SponsorData window)
        {
            Window = window;
        }

        public void SponserAmount()
        {
            /*decimal sum = 0;

            foreach (DataRowView row in Window.sponsorerDataGrid1.ItemsSource)
            {
                sum += row[_esportDb.Sponsorer.Single().SponsorAmount];
            }
            Window.SponseredAmount.Content = sum;*/
        }
    }
    #endregion

    #region API, Checking whether the Summoner exists or not
    public class RiotApi
    {
        Model.EsportDanmarkEntities _esportDb = new Model.EsportDanmarkEntities();
        public SummonerCheck Window { get; set; }
        public RiotApi(SummonerCheck window)
        {
            Window = window;            
        }
        

        public string SummonerName;
        public long SummonerLvl;
        public long RevisionDate;
        public string SummonerId;

        
        public void GetSummoner(string input)
        {            
            try 
	        {
                string url = $"https://{Window.RegionSelect.SelectedItem}.api.riotgames.com/lol/summoner/v4/summoners/by-name/{input}?api_key=RGAPI-85d8c7f8-3460-43f6-ae58-def8b5d2e44e";
                WebRequest requestObject = WebRequest.Create(url);
                requestObject.Method = "GET";
                HttpWebResponse responseObject = null;
                responseObject = (HttpWebResponse)requestObject.GetResponse();

                string jsonResult;
                using (Stream myStream = responseObject.GetResponseStream())
                {
                    StreamReader sr = new StreamReader(myStream);
                    jsonResult = sr.ReadToEnd();
                    sr.Close();
                }
                Summoner check = JsonConvert.DeserializeObject<Summoner>(jsonResult);
                Window.SummonerName.Text = check.Name;
                Window.SummonerLvl.Text = check.SummonerLevel.ToString();
                var date = (new DateTime(1970, 1, 1)).AddMilliseconds(check.RevisionDate);
                Window.RevisionDate.Content = "Revision Date: \n"+ date;
                SummonerId = check.Id;
    }
	        catch (Exception)
	        {
		        throw;
	        }
        }        
    }

    public class Summoner
    {
        public string Name { get; set; }
        public long SummonerLevel { get; set; }
        public long RevisionDate { get; set; }
        public string Id { get; set; }
    }
    #endregion
}
