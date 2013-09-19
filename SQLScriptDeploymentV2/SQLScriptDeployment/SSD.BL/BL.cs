using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSD.BL.ConnectionBL;

namespace SSD.BL
{
    public class BL
    {
        private static ConnectionOperation m_cOp;
        public static ConnectionOperation ConnectionOperatin
        {
            get
            {
                if (m_cOp == null)
                {
                    m_cOp = new ConnectionOperation();
                }
                return m_cOp;
            }
        }

    }
}
