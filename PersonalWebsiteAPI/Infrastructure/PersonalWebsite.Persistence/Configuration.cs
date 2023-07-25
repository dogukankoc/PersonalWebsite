using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Protocols;

namespace PersonalWebsiteAPI.Persistence
{
    public static class Configuration
    {
        public static string ConnectionString
        {
            get
            {
                //Use ConfigurationManager Library for Static Files
                ConfigurationManager configurationManager = new();
                configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../../Presentation/PersonalWebsiteAPI.API/"));
                configurationManager.AddJsonFile("appsettings.json");
                return configurationManager.GetConnectionString("MSSQLServer");
            }
        
        }
    }
}
