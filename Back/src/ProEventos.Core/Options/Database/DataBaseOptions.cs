namespace ProEventos.Core.Options.Database
{
    public class DataBaseOptions
    {
        public string ConectionString { get; set; } = string.Empty;
        public int MaxRetryCount { get; set; }
        public int CommandTimeout { get; set; }
        public bool EnableDetailedErrors { get; set; }
        public bool EnableSensitiveDataLoggind { get; set; }
    }
}
