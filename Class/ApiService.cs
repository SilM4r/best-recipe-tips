using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace best_recipe_tips
{
    
    public class ApiService
    {
        HttpClient client;
        public ApiService()
        {
            client = new HttpClient();
        }

        public async Task<Recipes> ZískejRychlýRecept(string parametr)
        {
            string adresa = $"https://api.edamam.com/api/recipes/v2?type=public&q={parametr}&app_id=xxx&app_key=xxx";
            //                https://api.edamam.com/api/recipes/v2?type=public&q=chicken&app_id=xxx&app_id=xxx&app_key=xxx


            Recipes data = client.GetFromJsonAsync<Recipes>(adresa).Result;
            
            /*
            string json;
            using (StreamReader r = new StreamReader("E:\\STAŽENÉ SOUBORY\\response_1713981141614.json"))
            {
                json = r.ReadToEnd();;
            }

            Recipes data = JsonConvert.DeserializeObject<Recipes>(json);
            */

            return data;
        }

        public async Task<Recipes> AdvancedSearch(string parametr)
        {
            string adresa = $"https://api.edamam.com/api/recipes/v2?type=public&app_id=xxx&app_key=xxx{parametr}";
            //                https://api.edamam.com/api/recipes/v2?type=public&app_id=xxx&app_key=xxx&ingr=10&diet=high-protein&health=alcohol-free&cuisineType=British&mealType=Dinner&dishType=Side%20dish&calories=1-800&time=360&co2EmissionsClass=B


            HttpResponseMessage response = client.GetAsync(adresa).Result;

            if (response.IsSuccessStatusCode)
            {
                string responseContent = await response.Content.ReadAsStringAsync();
                Recipes data = JsonConvert.DeserializeObject<Recipes>(responseContent);
                return data;
            }
            else
            {
                return null;
            }

            
        }
    }
}
