using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SSD.Data.Entities;

namespace SSD.Data.DBContext
{
    public class DBDeployContext : DbContext
    {
        public DBDeployContext()
        {

        }
        public DbSet<Connection> Connection { get; set; }
        public DbSet<ConnecionGroup> ConnectionGroup { get; set; }

    }
}
