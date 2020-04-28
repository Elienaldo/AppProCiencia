using Newtonsoft.Json;
using AppProCiencia.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace AppProCiencia.API
{
    public static class ApiService
    {
        public const string UrlServico = "https://servicoprociencia.conveyor.cloud";
        public static HttpClient client = new HttpClient();

        public static async Task<ObservableCollection<Projeto>> ObterProjetos()
        {
            string url = UrlServico + "/api/Projetos";
            var response = await client.GetStringAsync(url);

            ObservableCollection<Projeto> listaProjetos = JsonConvert.DeserializeObject<ObservableCollection<Projeto>>(response);

            return listaProjetos;
        }

        public static async Task<ObservableCollection<Area>> ObterAreas()
        {
            string url = UrlServico + "/api/Areas";
            var response = await client.GetStringAsync(url);

            ObservableCollection<Area> listaAreas = JsonConvert.DeserializeObject<ObservableCollection<Area>>(response);

            return listaAreas;
        }

        public static async Task<ObservableCollection<SubArea>> ObterSubAreas()
        {
            string url = UrlServico + "/api/SubAreas";
            var response = await client.GetStringAsync(url);

            ObservableCollection<SubArea> listaSubAreas = JsonConvert.DeserializeObject<ObservableCollection<SubArea>>(response);

            return listaSubAreas;
        }

        public static async Task<ObservableCollection<Instituicao>> ObterInstituicoes()
        {
            string url = UrlServico + "/api/Instituicoes";
            var response = await client.GetStringAsync(url);

            ObservableCollection<Instituicao> listaInstituicoes = JsonConvert.DeserializeObject<ObservableCollection<Instituicao>>(response);

            return listaInstituicoes;
        }
    }
}
