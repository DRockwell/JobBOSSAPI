using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobbossAPI
{
    /// <summary>
    /// All settings stored in config.xml file. This file will genearate on first call of Load() if it does not exist.
    /// I suppose I could attach it to the project, but it's not important at the moment.
    /// </summary>
    public class Settings
    {
        private string SettingsPath = AppDomain.CurrentDomain.BaseDirectory + "config.xml";

        public string UserName { get; set; }
        public string Password { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public void Load()
        {
            try
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
                FileStream fs = new FileStream(SettingsPath, FileMode.Open);
                System.Xml.XmlReader reader = System.Xml.XmlReader.Create(fs);
                Settings Loaded = (Settings)serializer.Deserialize(reader);
                UserName = Loaded.UserName;
                Password = Loaded.Password;
                ServerName = Loaded.ServerName;
                DatabaseName = Loaded.DatabaseName;
                fs.Close();
            }
            catch (FileNotFoundException)
            {
                UserName = UserName ?? "USERNAME";
                Password = Password ?? "PASSWORD";
                ServerName = ServerName ?? "SERVERNAME";
                DatabaseName = DatabaseName ?? "DATABASENAME";
                Save();
            }
        }
        public void Save()
        {
            using (FileStream fs = new FileStream(SettingsPath, FileMode.OpenOrCreate))
            {
                System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(Settings));
                serializer.Serialize(fs, this);
            }
        }
    }
}
