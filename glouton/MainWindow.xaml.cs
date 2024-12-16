using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Newtonsoft.Json.Linq;

namespace glouton
{
    public partial class MainWindow : Window
    {
        private const string ApiBaseUrl = "https://world.openfoodfacts.org/api/v0/product/";

        public MainWindow()
        {
            InitializeComponent();
        }

        private async void BTN_Click(object sender, RoutedEventArgs e)
        {
            string barcode = SearchTextBox.Text;

            if (string.IsNullOrWhiteSpace(barcode))
            {
                MessageBox.Show("Veuillez entrer un code-barres valide.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                await FetchProductData(barcode);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Une erreur s'est produite : {ex.Message}", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private async Task FetchProductData(string barcode)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = ApiBaseUrl + barcode + ".json";
                HttpResponseMessage response = await client.GetAsync(url);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Produit introuvable. Veuillez vérifier le code-barres et réessayer.", "Produit introuvable", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                string jsonResponse = await response.Content.ReadAsStringAsync();
                JObject productData = JObject.Parse(jsonResponse);

                if (productData["status"].Value<int>() == 0)
                {
                    MessageBox.Show("Produit introuvable. Veuillez vérifier le code-barres et réessayer.", "Produit introuvable", MessageBoxButton.OK, MessageBoxImage.Information);
                    return;
                }

                UpdateUIWithProductData(productData);
            }
        }

        private void UpdateUIWithProductData(JObject productData)
        {
            JObject product = productData["product"] as JObject;

            if (product == null)
            {
                MessageBox.Show("Les données du produit sont introuvables.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Informations de base
            string productName = product["product_name"]?.ToString() ?? "Inconnu";
            string quantity = product["quantity"]?.ToString() ?? "Inconnu";
            string packaging = product["packaging"]?.ToString() ?? "Inconnu";
            string nutriscore = product["nutriscore_grade"]?.ToString()?.ToUpper() ?? "Inconnu";
            string categories = product["categories"]?.ToString() ?? "Inconnu";
            string certifications = product["labels"]?.ToString() ?? "Aucune";
            string countries = product["countries"]?.ToString() ?? "Inconnu";

            // Apports nutritionnels
            string fat = product["nutriments"]?["fat_100g"]?.ToString() ?? "Inconnu";
            string saturatedFat = product["nutriments"]?["saturated-fat_100g"]?.ToString() ?? "Inconnu";
            string salt = product["nutriments"]?["salt_100g"]?.ToString() ?? "Inconnu";
            string sugar = product["nutriments"]?["sugars_100g"]?.ToString() ?? "Inconnu";
            string proteins = product["nutriments"]?["proteins_100g"]?.ToString() ?? "Inconnu";
            string kcal = product["nutriments"]?["energy-kcal_100g"]?.ToString() ?? "Inconnu";

            // Image du produit
            string imageUrl = product["image_url"]?.ToString() ?? string.Empty;

            // Mise à jour de l'interface utilisateur
            Dispatcher.Invoke(() =>
            {
                // Informations
                ((TextBlock)((StackPanel)((Border)MainGrid.Children[0]).Child).Children[1]).Text = $"Poids/Quantité : {quantity}";
                ((TextBlock)((StackPanel)((Border)MainGrid.Children[0]).Child).Children[2]).Text = $"Conditionnement : {packaging}";
                ((TextBlock)((StackPanel)((Border)MainGrid.Children[0]).Child).Children[3]).Text = $"Nutri-Score : {nutriscore}";
                ((TextBlock)((StackPanel)((Border)MainGrid.Children[0]).Child).Children[4]).Text = $"Catégorie : {categories}";
                ((TextBlock)((StackPanel)((Border)MainGrid.Children[0]).Child).Children[5]).Text = $"Certifications : {certifications}";
                ((TextBlock)((StackPanel)((Border)MainGrid.Children[0]).Child).Children[6]).Text = $"Pays de vente : {countries}";

                // Apports nutritionnels
                ((TextBlock)((StackPanel)((Border)MainGrid.Children[1]).Child).Children[1]).Text = $"Gras : {fat}g";
                ((TextBlock)((StackPanel)((Border)MainGrid.Children[1]).Child).Children[2]).Text = $"Gras Saturés : {saturatedFat}g";
                ((TextBlock)((StackPanel)((Border)MainGrid.Children[1]).Child).Children[3]).Text = $"Sel : {salt}g";
                ((TextBlock)((StackPanel)((Border)MainGrid.Children[1]).Child).Children[4]).Text = $"Sucre : {sugar}g";
                ((TextBlock)((StackPanel)((Border)MainGrid.Children[1]).Child).Children[5]).Text = $"Protéines : {proteins}g";
                ((TextBlock)((StackPanel)((Border)MainGrid.Children[1]).Child).Children[6]).Text = $"Kcal : {kcal}";

                // Image et description
                ((Image)((StackPanel)((Border)MainGrid.Children[2]).Child).Children[1]).Source = string.IsNullOrEmpty(imageUrl) ? null : new System.Windows.Media.Imaging.BitmapImage(new Uri(imageUrl));
            });
        }
    }
}
