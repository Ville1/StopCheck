using System.Configuration;

namespace StopCheck.Utils
{
    public class Config
    {
        public static string TimeFormat { get { return ConfigurationManager.AppSettings["TimeFormat"]; } }
        public static string HSLRestUrlStop { get { return ConfigurationManager.AppSettings["HSLRestUrlStop"]; } }
    }
}