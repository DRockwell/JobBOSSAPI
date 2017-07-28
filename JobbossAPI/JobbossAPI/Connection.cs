using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobbossAPI
{
    public class Connection
    {
        public Settings Settings { get; set; } = new Settings();
        
        public string ConnectionString
        {
            get
            {
                return "data source=" + Settings.ServerName + ";initial catalog=" + Settings.DatabaseName + ";persist security info=True;user id=" + Settings.UserName + ";password=" + Settings.Password + ";MultipleActiveResultSets=True;App=EntityFramework";
            }
        }
        private JobbossDatabase _Database;
        public JobbossDatabase Database
        {
            get
            {
                return _Database ?? new JobbossDatabase(ConnectionString);
            }
            set
            {
                _Database = value;
            }
        }
        public void Connect()
        {
            Settings.Load();
            Database = new JobbossDatabase(ConnectionString);
        }
    }
}
