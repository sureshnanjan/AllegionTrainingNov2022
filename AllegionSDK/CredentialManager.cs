using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllegionSDK
{
    /// <summary>
    /// 
    /// </summary>
    public class CredentialManager
    {
        /// <summary>
        /// 
        /// </summary>
        public void CreateCredentials() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="pass"></param>
        /// <param name="apiId"></param>
        /// <returns></returns>
        public int getCredentials(string uname, string pass, int apiId) {
            return 100;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="pass"></param>
        /// <param name="apiId"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public int getCredentials2(string uname, string pass, int apiId)
        {
            if (true) {
                throw new Exception("Invalid");
            }
            else { return 100; }
            
        }
    }
}
