using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobbossAPI
{
    /// <summary>
    /// All API calls made from this class are sent via the same connection.
    /// Thread safety is not a design goal.
    /// </summary>
    public class API
    {
        public API()
        {
            Connection = new Connection();
            Connection.Connect();
        }

        public Connection Connection { get; set; }

        public string GetJobNumber(int JobOperation)
        {
            return Connection.Database.Job_Operation.Where(x => x.Job_Operation1 == JobOperation).FirstOrDefault()?.Job;
        }
    }
}
