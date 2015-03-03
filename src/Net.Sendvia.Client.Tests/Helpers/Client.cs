using Net.Sendvia.Tests.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Sendvia.Helpers
{
    public static class Client 
    {
        public static Net.Sendvia.Client Create()
        {
            return new Sendvia.Client(Settings.Default.Client_Id, Settings.Default.Secret);
        }
    }
}
