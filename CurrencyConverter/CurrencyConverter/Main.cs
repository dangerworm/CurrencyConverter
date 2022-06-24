using System.Collections.ObjectModel;
using System.Net.Http.Headers;
using System.Text.Json;
using CurrencyConverter.FixerIoData;

namespace CurrencyConverter
{
    public partial class Main : Form
    {
        private const string AccessKey = "aa26a6ecdd16c2f0da14a684f2bfb2f7";

        private HttpClient _httpClient;
        private FixerIoResponse _currencyData;

        public Main()
        {
            InitializeComponent();

            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://data.fixer.io/api")
            };

            InitialiseForm();
        }

        private async Task InitialiseForm()
        {
            await GetCurrencyRates();

            PopulateCurrencyCombo();
        }

        private async Task GetCurrencyRates()
        {
            var uri = BuildQueryString();

            var response = await _httpClient.GetAsync(uri);

            var json = await response.Content.ReadAsStringAsync();

            _currencyData = JsonSerializer.Deserialize<FixerIoResponse>(json)!;
        }

        private string BuildQueryString()
        {
            return $"latest?access_key={AccessKey}";
        }

        private void PopulateCurrencyCombo()
        {
            CurrencyCombo.Items.AddRange(Constants.Currencies.Cast<object>().ToArray());
        }
    }
}
