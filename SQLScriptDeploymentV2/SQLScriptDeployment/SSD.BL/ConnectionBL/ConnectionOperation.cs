using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSD.Data.Entities;
using System.Data.Entity;

namespace SSD.BL.ConnectionBL
{
    public class ConnectionOperation
    {
        public ConnectionOperation()
        { 
        
        }

        public IQueryable<Connection> GetAllConnection()
        {
            return DBOperation.DBDeployContext.Connection.AsQueryable<Connection>();
        }

        public Connection GetConnectionById(int Id)
        {
            return DBOperation.DBDeployContext.Connection.Find(Id);
        }

        public void Save(Connection c)
        {
            DBOperation.DBDeployContext.Connection.Add(c);
            DBOperation.DBDeployContext.SaveChanges();
        }
    }
}
