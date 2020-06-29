using Newtonsoft.Json;
using PH_MarvelApp.Helpers;
using PH_MarvelApp.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace PH_MarvelApp.Services
{
    public class MarvelAPIService
    {
        private string[] HEROIS = new string[]
        {
          "Spider-Man",
          "Iron Man",
          "Storm"
        };

        public async Task<List<Herois>> getHeroisAsync()
        {
            var httpClient = new HttpClient(); //Instância uma classe de HttpClient --> Chamada Http pra acessar a API
            List<Herois> listaHerois = new List<Herois>();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            //hash - a md5 digest of the ts parameter, your private key and your public key (e.g. md5(ts+privateKey+publicKey) --Espec

            string ts = DateTime.Now.Ticks.ToString(); //time stamp
            string apikey = Constantes.PublicKey;
            string hash = SecurityHelpers.GerarHash(ts, apikey, Constantes.PrivateKey);
            string baseURI = Constantes.ApiBaseUrl + $"characters?ts={ts}&apikey={apikey}&hash={hash}&"; //Monta o endpoint base para realizar a Requisação na API da Marvel
            //string baseURI = "https://gateway.marvel.com:443/v1/public/characters?ts=1593370664&apikey=570431b07c6b40f95270c3ae1a066b76&hash=f8cb5574229f1bd2f8d539c4e899e144&name=Spider-Man";

            foreach (var personagem in HEROIS)
            {
                string request = baseURI + $"name={Uri.EscapeUriString(personagem)}";

                var response = await httpClient.GetAsync(request).ConfigureAwait(false);
                if (response.IsSuccessStatusCode)
                {
                    string content = response.Content.ReadAsStringAsync().Result; //Lê o JSON de retorno como uma string ainda em formato JSON

                    dynamic retorno = JsonConvert.DeserializeObject(content); //Desserializar o JSON de retorno em um resultado Dinâmico
                    
                    Herois meuHeroi = new Herois();

                    meuHeroi.Nome = retorno.data.result[0].name;
                    meuHeroi.Descricao = retorno.data.result[0].description;
                    meuHeroi.UrlImagem = retorno.data.result[0].thumbnail.path + "." + retorno.data.results[0].thumbnail.extension;
                    meuHeroi.UrlWiki = retorno.data.result[0].resourceURI;

                    listaHerois.Add(meuHeroi);
                }
            }

            return listaHerois;

        }

       
    }
}
