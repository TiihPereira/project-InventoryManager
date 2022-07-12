using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManager.Repositorio.dbConnection
{
    public class dbConnection
    {
        private static string ConnectionString = "Data Source=THIAGUERA-PC;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static string GetConn()
        {
            return ConnectionString;
        }
    }
}
