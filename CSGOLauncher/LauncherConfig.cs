using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace CSGOLauncher
{
    static class LauncherConfig
    {
        public static string CurrentDirectory
        {
            get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); }
        }

        private static string ConfigFileName
        {
            get { return "csgo_launcher.cfg"; }
        }

        private static string ConfigFilePath
        {
            get { return Path.Combine(CurrentDirectory, ConfigFileName); }
        }

        public static CSGOAttributes StoredConfiguration
        {
            get
            {
                try
                {
                    using (StreamReader str = new StreamReader(ConfigFilePath))
                    {
                        XmlSerializer ser = new XmlSerializer(typeof(CSGOAttributes));
                        return (CSGOAttributes)ser.Deserialize(str);
                    }
                }
                catch (FileNotFoundException) { return new CSGOAttributes(); }
            }
            set
            {
                using (StreamWriter str = new StreamWriter(ConfigFilePath, false))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(CSGOAttributes));
                    ser.Serialize(str, value);
                }
            }
        }
    }
}
