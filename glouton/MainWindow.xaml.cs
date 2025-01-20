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
            Search_Prod("3017620425035");

        }

        public async Task<Root> FetchProductByCodeAsync(string code)
        {

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

        public async void Search_Prod(string code)
        {
            Root BarCode = await FetchProductByCodeAsync(code);

            if (BarCode != null && BarCode.product != null)
            {
                TB_Name.Text = $"Nom: {BarCode.product.product_name}";
                TB_weight.Text = $"Poids: {BarCode.product.product_quantity}g";
                TB_package.Text = $"{BarCode.product.packaging_text_en}";
                TB_Score.Text = $"Nutriscore: {BarCode.product.nutriscore_data.grade}";
                TB_country.Text = $"Pays avec la plus grande consomation : {BarCode.product.countries_hierarchy[0].Remove(0,3)}";

                TB_Fat.Text = $"Gras: {BarCode.product.nutriments.fat}g";
                TB_sat_Fat.Text = $"Gras Saturer: {BarCode.product.nutriments.saturatedfat}g";
                TB_salt.Text = $"sel: {BarCode.product.nutriments.salt}g";
                TB_sugre.Text = $"sucre: {BarCode.product.nutriments.sugars}g";
                TB_prot.Text = $"Proteine: {BarCode.product.nutriments.proteins}g";
                TB_kcal.Text = $"kcalorie: {BarCode.product.nutriments.energykcal}";


            }
            else

            {

                TB_Name.Text = "couldn't reach API";

            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string inputText = SearchTextBox.Text;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string code = SearchTextBox.Text.Trim();

            if(!string.IsNullOrEmpty(code)) 
            {
                Search_Prod(code);
            }
        }
    }
}
