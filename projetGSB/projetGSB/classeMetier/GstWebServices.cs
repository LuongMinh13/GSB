using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace projetGSB.classeMetier
{
    public class GstWebServices
    {
        // Membres privés de la classe
        private HttpClient ws;
        private string reponse;

        // Constructeur de la classe
        public GstWebServices()
        {
            ws = new HttpClient();
        }

        // Méthodes qui vont appeler les API PHP
        public async Task<List<Region>> ListRegion()
        {
            reponse = await ws.GetStringAsync(App.LocalHost + "GetAllRegion.php");
            List<Region> LesRegions = JsonConvert.DeserializeObject<List<Region>>(reponse);
            return LesRegions;
        }

        public async Task<List<Secteur>> ListSecteur()
        {
            reponse = await ws.GetStringAsync(App.LocalHost + "GetAllSecteur.php");
            List<Secteur> LesSecteur = JsonConvert.DeserializeObject<List<Secteur>>(reponse);
            return LesSecteur;
        }

        // Méthodes pour récupérer les id région
         public async Task<List<Region>> ListIdRegion(string coderegion)
        {
             reponse = await ws.GetStringAsync(App.LocalHost + "GetAllIdRegion.php?codetregion="+coderegion);
             List<Region> LesIdRegion = JsonConvert.DeserializeObject<List<Region>>(reponse);
             return LesIdRegion;
         }


        //Méthode pour modifier les régions
        public async Task modifierRegion(string CODE_REG, string CODE_SEC, string REG_NOM)
        {
            await ws.GetStringAsync(App.LocalHost + "UpdateRegion.php?coderegion=" + CODE_REG + "&nomregion=" + REG_NOM + "&codesecteur=" + CODE_SEC );
        }


    }
}
