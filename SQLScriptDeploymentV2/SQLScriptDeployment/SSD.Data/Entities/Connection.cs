using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSD.Data.Entities
{
    [Serializable]
    public class Connection
    {
        public Connection()
        {

        }

        public int ConnectionID { get; set; }
        public string ServerName { get; set; }
        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public int ConnectionGroupID { get; set; }
        public virtual ConnecionGroup ConnectionGrup { get; set; }
    }
}
