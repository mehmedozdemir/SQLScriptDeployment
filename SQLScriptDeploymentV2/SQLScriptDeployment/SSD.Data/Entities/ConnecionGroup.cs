using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SSD.Data.Entities
{
    public class ConnecionGroup
    {
        public ConnecionGroup()
        {

        }

        public int ConnectionGroupID { get; set; }
        public string GroupName { get; set; }
        public virtual List<Connection> Connections { get; set; }

    }
}
