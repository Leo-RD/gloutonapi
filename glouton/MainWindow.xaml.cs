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
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Service _service; // Instance de la classe Service

        public MainWindow()
        {
            InitializeComponent();
            _service = new Service(); // Initialisation de l'instance
            Search_Prod("5000159461122");
        }

        public async void Search_Prod(string code)
        {
            Root BarCode = await _service.FetchProductByCodeAsync(code); // Utilisation de l'instance _service

            if (BarCode != null && BarCode.product != null)
            {
                TB_Name.Text = $"Nom : {BarCode.product.product_name}";
                TB_weight.Text = $"Poids : {BarCode.product.product_quantity}g";
                TB_package.Text = $"{BarCode.product.packaging}";
                TB_Score.Text = $"Nutriscore : {BarCode.product.nutriscore_2023_tags}";
                TB_country.Text = $"{BarCode.product.countries}";

                TB_Fat.Text = $"Gras : {BarCode.product.nutriments.fat}g";
                TB_sat_Fat.Text = $"Gras Saturé : {BarCode.product.nutriments.saturatedfat}g";
                TB_salt.Text = $"Sel : {BarCode.product.nutriments.salt}g";
                TB_sucre.Text = $"Sucre : {BarCode.product.nutriments.sugars}g";
                TB_prot.Text = $"Protéine : {BarCode.product.nutriments.proteins}g";
                TB_kcal.Text = $"Kcalorie : {BarCode.product.nutriments.energykcal}";
            }
            else
            {
                TB_Name.Text = "Impossible d'atteindre l'API";
            }
        }

        private void SearchTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string inputText = SearchTextBox.Text;
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
