namespace CurrencyConverter.FixerIoData
{
    public class FixerIoResponse
    {
        public bool success { get; set; }
        public int timestamp { get; set; }
        public string _base { get; set; }
        public string date { get; set; }
        public Rates rates { get; set; }
    }
}
