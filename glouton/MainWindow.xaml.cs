using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using glouton.Models;

namespace glouton
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Search_Prod("5000159461122");

        }

        public async Task<Root> FetchProductByCodeAsync(string code)
        {

            HttpClient client = new HttpClient();

            HttpResponseMessage response = await client.GetAsync($"https://world.openfoodfacts.org/api/v2/product/3017620425035.json");

            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Root product = JsonConvert.DeserializeObject<Root>(content);
                return product;
            }

            return null;
        }

        public async void Search_Prod(string code)
        {
            Root BarCode = await FetchProductByCodeAsync(code);

            if (BarCode != null && BarCode.product != null)
            {
                TB_Name.Text = $"Nom : {BarCode.product.product_name}";
                TB_weight.Text = $"Poids :{BarCode.product.product_quantity}g";
                TB_package.Text = $"{BarCode.product.packaging}";
                TB_Score.Text = $"Nutriscore :{BarCode.product.nutriscore}";
                TB_country.Text = $"{BarCode.product.labels}";

                TB_Fat.Text = $"Gras: {BarCode.product.nutrient_levels.fat}g";
                TB_sat_Fat.Text = $"Gras Saturer {BarCode.product.nutrient_levels.saturatedfat}g";
                TB_salt.Text = $"Niveau de sel{BarCode.product.nutrient_levels.salt}g";
                TB_sugre.Text = $"{BarCode.product.nutrient_levels.sugars}";
                TB_prot.Text = $"{BarCode.product.nutriments.proteins}";
                TB_kcal.Text = $"{BarCode.product.nutriments.energykcal}";

                // = $"{BarCode.Product.ImageUrl}";

            }
            else

            {

                TB_Name.Text = "couldn't reach API";

            }
        }
    }
}
