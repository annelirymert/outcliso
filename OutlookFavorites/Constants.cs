using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace OutlookFavorites
{
    internal static class Constants
    {
        public static string HostUri { get { return "https://demo23annelirymert.sharepoint.com/sites/DocumentCenter"; } }
        public static string UserName { get { return "admin@demo23annelirymert.onmicrosoft.com"; } }
        public static SecureString Password 
        { 
            get 
            {
                var securePassword = new SecureString();
                var passwordChars = "Basf2014".ToCharArray();
                foreach (char c in passwordChars)
                {
                    securePassword.AppendChar(c);
                }
                return securePassword; 
            } 
        }
    }
}
