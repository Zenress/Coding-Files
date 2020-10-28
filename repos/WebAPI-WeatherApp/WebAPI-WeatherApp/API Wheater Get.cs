using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.IO;
using System.Web;

namespace WebAPI_WeatherApp
{
    public class WheaterData
    {        
        //Variables to keep track of city, temperature and if the method has failed
        public string city;
        public string temperature;
        public bool failed;
        public string URL;
        //GetWheater function used to get the current wheater temperature
        public void GetWheater(string text)
        {
            try
            {        
                //Getting the textinput and adding it to a variable, afterwards we assign the URL to the variable called URL
                city = text;
                URL = String.Format($"http://api.openweathermap.org/data/2.5/weather?q={city}&units=metric&appid=8ce4b97528c5e39547a6d10a919c79d0");
                
                //We then make a webrequest instance with the URL variable, afterwards we make sure that the request object knows that it's a get method object
                WebRequest requestObjGet = WebRequest.Create(URL);
                requestObjGet.Method = "GET";
                //We then make a response object that has the unassigned value of null, and then we make the RequestObj's response, the value of the response obj
                HttpWebResponse responseObjGet = null;
                responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();

                //Then we make a new variable, a string that contains the json format result of the API.
                string jsonResult = null;
                //Using a Using argument to read the response stream of the response object
                using (Stream stream = responseObjGet.GetResponseStream())
                {
                    //Making an instance of the Streamreader class
                    StreamReader sr = new StreamReader(stream);
                    //Making the jsonresult variable contain the streamreaders stream. And then closing the streamreader
                    jsonResult = sr.ReadToEnd();
                    sr.Close();
                }
                //Making the public temperature variable contain the jsonResult variable's value
                Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(jsonResult);
                temperature = myDeserializedClass.main.temp.ToString().Substring(0,2);
            }
            //An error catch, that changes the value of the bool failed, to true. So that we can display an error message
            catch (Exception)
            {
                failed = true;                
            }
        }
    }
    //Making a public Main class for the json response of the API
    public class Main
    {
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
    }
    //Maing a root class for deserialization
    public class Root
    {
        public Main main { get; set; }
    }
}
