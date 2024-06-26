using System.Collections.Specialized;

namespace CapaDatos 
{
    public static class ConfigurationManager
    {
        public static NameValueCollection AppSettings { get; }
        public static ConnectionStringSettingsCollection ConnectionStrings { get; }
    }
}