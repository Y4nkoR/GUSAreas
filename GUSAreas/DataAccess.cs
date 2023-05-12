using GUSAreas.Models;
using GUSAreas.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace GUSAreas
{
    // Normaly this would be in some kind of library
    public class DataAccess
    {
        public async Task<List<AreaModel>> GetAreasData()
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("https://api-dbw.stat.gov.pl/api/1.1.0/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var uri = "area/area-area";
            var response = await httpClient.GetAsync(uri);

            var areas = response.IsSuccessStatusCode ? await response.Content.ReadFromJsonAsync<List<AreaModel>>()?? new List<AreaModel>() : new List<AreaModel>();

            return areas;
        }
    }
}
