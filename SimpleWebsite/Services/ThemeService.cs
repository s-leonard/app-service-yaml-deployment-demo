using Microsoft.Extensions.Configuration;

namespace SimpleWebsite.Services
{
    public interface IThemeService
    {
        string GetThemeName();
        string GetEnvironment();
    }

    public class ThemeService : IThemeService
    {
        private IConfiguration _config;
        public ThemeService(IConfiguration config)
        {
            _config = config;
        }

        public string GetThemeName()
        {
            return _config["App:Theme"];
        }

        public string GetEnvironment()
        {
            return _config["App:Environment"];
        }
    }
}
