using glouton.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace glouton.CONTROLLER
{
    public class Service
    {
        // Méthode pour récupérer les produits par catégorie
        public async Task<Root> FetchProductByCodeAsync(string code) // code = code barre du produit
        {
            // communication avec l'API OpenFoodFacts
            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync($"https://world.openfoodfacts.org/api/v2/product/{code}.json");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Root product = JsonConvert.DeserializeObject<Root>(content);
                return product;
            }

            return null;
        }
    }
}
