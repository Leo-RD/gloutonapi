using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Newtonsoft.Json;
using OpenFoodFactsCSharp.Models;

namespace OpenFoodFactsCSharp.Clients
{
    public partial class MainWindow : Window

    {

        public MainWindow()

        {



        }
        public class OpenFoodFactsApiLowLevelClient
        {
            private const string ApiUrl = "https://world.openfoodfacts.org/api/v0";
            private readonly HttpClient _httpClient;

            public OpenFoodFactsApiLowLevelClient(HttpClient httpClient)
            {
                _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
            }

            public async Task<ProductResponse> FetchProductByCodeAsync(string code)
            {
                var requestUri = $"{ApiUrl}/product/{code}.json";
                var response = await _httpClient.GetAsync(requestUri);

                if (!response.IsSuccessStatusCode)
                {
                    // Handle error or throw an exception
                    throw new HttpRequestException($"Failed to fetch product by code: {code}");
                }


                var content = await response.Content.ReadAsStringAsync();
                var product = JsonConvert.DeserializeObject<ProductResponse>(content);

                return product;
            }
        }
    }
}
