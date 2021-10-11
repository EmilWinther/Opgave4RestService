using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Opgave4RestService.Secrets
{
    public class MySecrets
    {
        public const string ConnectionString =
            "Server=tcp:emilzealanddb.database.windows.net,1433;Initial Catalog=RestServiceDb;Persist Security Info=False;User ID=emiladmin;Password=Sql12345;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
    }
}
