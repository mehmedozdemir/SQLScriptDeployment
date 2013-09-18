using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLScriptDeployment
{
    public class DeploymentResult
    {
        public string ServerName { get; set; }
        public bool IsSucces { get; set; }
        public string ResultDescription { get; set; }
    }
}
