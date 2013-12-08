using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Reflection;

namespace CSGOLauncher
{
    static class LauncherConfig
    {
        private static string CurrentDirectory
        {
            get { return Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location); }
        }

        private static string ConfigFileName
        {
            get { return "launcher.cfg"; }
        }

        private static string ConfigFilePath
        {
            get { return Path.Combine(CurrentDirectory, ConfigFileName); }
        }

        public static CSGOAttributes StoredConfiguration
        {
            get
            {
                using (StreamReader str = new StreamReader(ConfigFilePath))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(CSGOAttributes));
                    return (CSGOAttributes)ser.Deserialize(str);
                }
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
