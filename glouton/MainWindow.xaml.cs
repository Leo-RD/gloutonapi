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
using glouton.CONTROLLER;

namespace glouton
{
    public partial class MainWindow : Window
    {
        private Service _service; // Instance de la classe Service

        public MainWindow()
        {
            InitializeComponent();
            _service = new Service(); // Initialisation de l'instance
            Search_Prod("5449000000996");
        }

        // Méthode pour rechercher un produit par code barre
        public async void Search_Prod(string code)
        {
            Root BarCode = await _service.FetchProductByCodeAsync(code); // Utilisation de l'instance _service

            if (BarCode != null && BarCode.product != null)
            {
                TB_Name.Text = $"Nom: {BarCode.product.product_name}";

                TB_weight.Text = $"Poids: {BarCode.product.product_quantity}g";

                TB_package.Text = $"{BarCode.product.packaging_text_en}";

                TB_Score.Text = $"Nutriscore: {BarCode.product.nutriscore_data.grade}";

                TB_country.Text = $"Pays avec la plus grande consomation : {BarCode.product.countries_hierarchy[0].Remove(0, 3)}";

                TB_Fat.Text = $"Gras: {BarCode.product.nutriments.fat}g";

                TB_sat_Fat.Text = $"Gras Saturés: {BarCode.product.nutriments.saturatedfat}g";

                TB_salt.Text = $"Sel: {BarCode.product.nutriments.salt}g";

                TB_sucre.Text = $"Sucre: {BarCode.product.nutriments.sugars}g";

                TB_prot.Text = $"Protéines: {BarCode.product.nutriments.proteins}g";

                TB_kcal.Text = $"KiloCalories: {BarCode.product.nutriments.energykcal}";
            }
            else
            {
                TB_Name.Text = "Impossible d'atteindre l'API";
            }
        }

        // Méthode pour utiliser la barre de recherche
        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string inputText = SearchTextBox.Text;
        }

        // Gestionnaire d'événements pour bloquer les entrées non numériques
        private void SearchTextBox_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!IsTextNumeric(e.Text))
            {
                e.Handled = true; // Bloque l'entrée
                MessageBox.Show("Seuls les chiffres sont autorisés.", "Entrée invalide", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

       

        // Méthode pour vérifier si une chaîne est numérique
        private bool IsTextNumeric(string text)
        {
            return int.TryParse(text, out _);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string code = SearchTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(code))
            {
                Search_Prod(code);
            }
        }
    }
}
