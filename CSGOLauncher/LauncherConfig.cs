using System.IO;
using System.Reflection;
using System.Xml.Serialization;

namespace CSGOLauncher
{
    static class LauncherConfig
    {
        /// <summary>
        /// Returns the directory the current Assembly is in.
        /// </summary>
        public static string CurrentDirectory
        {
            get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); }
        }

        /// <summary>
        /// Returns configuration file name.
        /// </summary>
        private static string ConfigFileName
        {
            get { return "csgo_launcher.cfg"; }
        }

        /// <summary>
        /// Returns full qualified file name path to config file.
        /// </summary>
        private static string ConfigFilePath
        {
            get { return Path.Combine(CurrentDirectory, ConfigFileName); }
        }

        /// <summary>
        /// Returns saved configuration if read and stores it on disk if set.
        /// </summary>
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
