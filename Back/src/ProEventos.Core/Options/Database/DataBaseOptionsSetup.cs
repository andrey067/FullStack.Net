using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace ProEventos.Core.Options.Database
{
    public class DataBaseOptionsSetup : IConfigureOptions<DataBaseOptions>
    {
        private const string ConfigurationSectionName = nameof(DataBaseOptions);
        private readonly IConfiguration _configuration;

        public DataBaseOptionsSetup(IConfiguration configuration) => _configuration = configuration;


        public void Configure(DataBaseOptions options)
        {
            var connectionString = _configuration.GetConnectionString("Database");
            options.ConectionString = connectionString;

            _configuration.GetSection(ConfigurationSectionName).Bind(options);
        }
    }
}
