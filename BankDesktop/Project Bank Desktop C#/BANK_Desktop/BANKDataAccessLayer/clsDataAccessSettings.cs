using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKDataAccessLayer
{
    internal class clsDataAccessSettings
    {

      // public static string ConnectionString = "Server=.;Database=BankDB;User Id=sa1;password=123456";
        public static string ConnectionString = "Server=" + Properties.Settings1.Default.SERVERNAME + ";Database=" + Properties.Settings1.Default.DATABASE + ";User Id=" + Properties.Settings1.Default.USERNAMEDB + ";password=" + Properties.Settings1.Default.PASSWORDDB + "";
    }
}
