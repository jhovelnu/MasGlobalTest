using Core_MasGlobal.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace Data_MasGlobal
{
    public class DataManager: IDataManager
    {
        public string Url = "http://masglobaltestapi.azurewebsites.net/api/Employees";        

        public IEnumerable<Employe> GetEmployees()
        {
            try
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create(Url);
                httpWebRequest.ContentType = "application/json; charset=utf-8";

                var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                var response = ReadResponse(httpResponse);
                return JsonConvert.DeserializeObject<IEnumerable<Employe>>(response);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error obteniendo Data, error:{ex.Message}");
            }
        }

        protected static string ReadResponse(HttpWebResponse httpResponse)
        {
            if (httpResponse != null)
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();                    
                    return result;
                }
            return string.Empty;
        }
    }
}
