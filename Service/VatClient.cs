using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using PrintExample.Model;
namespace PrintExample.Service
{
    public class VatClient
    {
        private readonly HttpClient client;
        public VatClient()
        {

            client = new HttpClient();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        }

        public Vat GetData(string url)
        {
            try
            {
                HttpResponseMessage response = client.GetAsync(url).Result;
                response.EnsureSuccessStatusCode();
                var respContent = response.Content.ReadAsStringAsync();
                //var oVat = Vat.FromJson(respContent.ToString());
                var oVat = Newtonsoft.Json.JsonConvert.DeserializeObject<Vat>(respContent.Result);
                return oVat;
            }
            catch (Exception e)
            {
                throw;
            }

        }
    }
}
