using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLScriptDeployment
{
    class ProgramOperation
    {

        private ProgramOperation()
        {

        }

        private static ServerOperation m_serverOperation;
        public static ServerOperation ServerOperation
        {
            get
            {
                if (m_serverOperation == null)
                {
                    m_serverOperation = new ServerOperation();
                }
                return m_serverOperation;
            }
        }

        private static DeploymentOperation m_deploymentOp;
        public static DeploymentOperation DeploymentOperation
        {
            get
            {
                if (m_deploymentOp == null)
                {
                    m_deploymentOp = new DeploymentOperation();
                }
                return m_deploymentOp;
            }
        }
    }
}
