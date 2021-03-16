using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationSalon
{
    class StaticContext
    {
        public static CSDBContext context;
        public StaticContext(string connectionString)
        {
            context = new CSDBContext(connectionString);
        }
    }
}
