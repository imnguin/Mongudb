using Microsoft.Extensions.Configuration;

namespace LXN.DATAACCESS
{
    public class AppConfig
    {
        private readonly ConfigurationBuilder _config;
        public AppConfig()
        {
            _config = (ConfigurationBuilder)new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
        }
        public string? GetConnectionString() => _config.Build().GetConnectionString("ConnectionString");
        public string? GetDatabaseName() => _config.Build().GetConnectionString("DatabaseName");
    }
}
