using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Allegion_SDK
{
    /// <summary>
    /// 
    /// </summary>
    public class CredentialManager
    {
        private int x;

        /// <value>Property <c>X</c> represents the point's x-coordinate.</value>
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public void CreateCredential()
        {
            
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="pass"></param>
        /// <param name="apiID"></param>
        /// <returns></returns>
        public int getCredentials(string uname, string pass, int apiID)
        {
            return 199;

        }

        public int getCredentials2(string uname, string pass, int apiID)
        { 
            if (true)
            {
                throw new Exception("invalid");
            }
            else
            {
                return 100;
            }

        }

    }
}
