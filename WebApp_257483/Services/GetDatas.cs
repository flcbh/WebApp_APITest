using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System.Net.Http.Headers;
using System.Numerics;
using WebApp_257483.Models;

namespace WebApp_257483.Services
{
    public class GetDatas : IGetDatas
    {
        private const string uriAssets = @"https://environment.data.gov.uk/flood-monitoring/id/stations/";

        public GetDatas()
        {
        }

        public async Task<Union> GetDataAssets(string id, string radius)
        {

            List<Items> listAssets = new List<Items>();
            Union unions = new Union();
            RootAssets rootAssets = new RootAssets();

            Uri uriAssets = new Uri(GetDatas.uriAssets);

            var clientAssets = new HttpClient();

            clientAssets.BaseAddress = uriAssets;
            clientAssets.DefaultRequestHeaders.Accept.Clear();
            clientAssets.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseAssets = await clientAssets.GetAsync(uriAssets);

            if (responseAssets.IsSuccessStatusCode)
            {
                string resultAssets = await responseAssets.Content.ReadAsStringAsync();

                rootAssets = JsonConvert.DeserializeObject<RootAssets>(resultAssets);
            }

            if (string.IsNullOrEmpty(id))
            {
                listAssets = rootAssets?.items;
            }
            else
            {
                listAssets = rootAssets?.items.Where(i => i.id.Contains(id)).ToList();
            }

            unions.Assets = new List<Items>();
            unions.Monitorings = new List<RootMonitoring> { new RootMonitoring() };

            foreach (var item in listAssets)
            {
                unions.Assets?.Add(item);
                unions.Monitorings?.Add(GetDataMonitoring(item.lat, item.@long, radius).Result);
            }

            return unions;
        }

        private async Task<RootMonitoring> GetDataMonitoring(double lat, double lng, string radius)
        {

            var listMonitoring = new List<Items>();
            RootMonitoring rootMonitoring = new RootMonitoring();

            string v = "https://environment.data.gov.uk/asset-management/maintained-asset.geojson?lat=" + lat + "&lng=" + lng + "&radius=" + radius;

            Uri uriMonitoring = new Uri(v);

            var clientMonitoring = new HttpClient();

            clientMonitoring.BaseAddress = uriMonitoring;
            clientMonitoring.DefaultRequestHeaders.Accept.Clear();
            clientMonitoring.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var responseMonitoring = await clientMonitoring.GetAsync(uriMonitoring);

            if (responseMonitoring.IsSuccessStatusCode)
            {
                string resultMonitoring = await responseMonitoring.Content.ReadAsStringAsync();

                rootMonitoring = JsonConvert.DeserializeObject<RootMonitoring>(resultMonitoring);
            }

            return rootMonitoring;
        }

    }
}
