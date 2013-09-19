using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSD.Data.DBContext;

namespace SSD.BL
{
     public class DBOperation
    {
         private DBOperation()
         {

         }
         private static object lockOb = new object();

         private static DBDeployContext m_dbDeployContext;
         public static DBDeployContext DBDeployContext
         {
             get
             {
                 lock (lockOb)
                 {
                     if (m_dbDeployContext == null)
                     {
                         m_dbDeployContext = new DBDeployContext();
                     }
                 }
                 return m_dbDeployContext;
             }
         }
    }
}
