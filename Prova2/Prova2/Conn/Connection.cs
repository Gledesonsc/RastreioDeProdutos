using Npgsql;
using System;
using System.Collections.Generic;
using System.Text;

namespace Prova2.Conn
{
    internal class Connection
    {
        private static string host = "ec2-52-71-23-11.compute-1.amazonaws.com";

        private static string port = "5432";

        private static string user = "cexqirxqpwfqcg";

        private static string database = "ddbth9o0r149re";

        private static string password = "299efa36d2b5442acb848b6559687c05eefcb8e7eda5217d872d7a2caf6cd934";


        public string Connectionstring()
        {
            return $"server={host};db={database};userId={user};port={port};password={password}";
        }

       
    }
}
