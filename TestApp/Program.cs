using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PH_MarvelApp.Models;
using PH_MarvelApp.Services;

namespace TestApp
{
    class Program
    {
        public static List<Herois> meusHerois = new List<Herois>();
        static void Main(string[] args)
        {
            Dados();
            
 
            


            foreach (Herois x in meusHerois)
            {
                Console.WriteLine("Nome: ",x.Nome);
                Console.WriteLine("Descrição: ", x.Nome);
                Console.WriteLine("URL da Imagem: ", x.Nome);
                Console.WriteLine("URL da Wiki: ", x.Nome);
            }

            Console.WriteLine("Terminei");
            Console.ReadKey();
        }

        static async void Dados()
        {
            List<Herois> meusHerois = new List<Herois>();
            MarvelAPIService myAPI = new MarvelAPIService();

            var retorno = await Task.Run(() => myAPI.getHeroisAsync());
            await Task.Delay(1000000);
            await Task.Delay(1000000);
            await Task.Delay(1000000);


            foreach (var personagem in retorno)
            {
                meusHerois.Add(personagem);
            }

            //return meusHerois;
        }
    }
}
