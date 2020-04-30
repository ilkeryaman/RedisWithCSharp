using System.Configuration;

namespace RedisWithCSharp.Cache.Configuration
{
    public class RedisConfigurationManager
    {
        private const string SectionName = "RedisConfiguration";

        public static RedisConfigurationSection Config
        {
            get
            {
                return (RedisConfigurationSection)ConfigurationManager.GetSection(SectionName);
            }
        }
    }
}
