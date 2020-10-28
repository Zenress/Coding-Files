using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.IO;
using Newtonsoft.Json;

namespace WeatherApp_V2
{
    public class WeatherAPI
    {       
        public double temperature;
        public double feelsLike;
        public double temperatureMin;
        public double temperatureMax;
        public void getWeather(string text)
        {
            string url = $"http://api.openweathermap.org/data/2.5/weather?q={text}&units=metric&appid=8ce4b97528c5e39547a6d10a919c79d0";
            try
            {
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
                Root myRoot = JsonConvert.DeserializeObject<Root>(jsonResult);
                temperature = myRoot.main.temp;
                feelsLike = myRoot.main.feels_like;
                temperatureMin = myRoot.main.temp_min;
                temperatureMax = myRoot.main.temp_max;
            }
            catch (Exception)
            {

                throw;
            }

        }
    }

    class Root
    {
        public Main main { get; set; }
    }

    class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
    }
}
