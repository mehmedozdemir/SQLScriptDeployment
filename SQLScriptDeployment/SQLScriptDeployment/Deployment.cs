using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLScriptDeployment
{
    class Deployment
    {
        public Deployment()
        {

        }

        public Server Server { get; set; }
        public string SqlScript { get; set; }
    }
}
