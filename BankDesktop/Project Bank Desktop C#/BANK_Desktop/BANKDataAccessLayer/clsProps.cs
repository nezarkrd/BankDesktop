using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANKDataAccessLayer
{
    public class clsProps
    {
        public string ServerName { get; set; }
        public string DataBase { get; set; }
        public string UserNameDB { get; set; }
        public string PasswordDB { get; set; }
        public bool CheckShow { get; set; }


        public clsProps()
        {
            ServerName = Properties.Settings1.Default.SERVERNAME;
            DataBase = Properties.Settings1.Default.DATABASE;
            UserNameDB = Properties.Settings1.Default.USERNAMEDB;
            PasswordDB = Properties.Settings1.Default.PASSWORDDB;
            CheckShow = Properties.Settings1.Default.CheckShow;
        }


        public clsProps(string servername, string database, string usenamedb, string passworddb, bool checkshow)
        {
            ServerName = servername;
            DataBase = database;
            UserNameDB = usenamedb;
            PasswordDB = passworddb;
            CheckShow = checkshow;

            Properties.Settings1.Default.SERVERNAME = ServerName;
            Properties.Settings1.Default.DATABASE = DataBase;
            Properties.Settings1.Default.USERNAMEDB = UserNameDB;
            Properties.Settings1.Default.PASSWORDDB = PasswordDB;
            Properties.Settings1.Default.CheckShow = CheckShow;
            Properties.Settings1.Default.Save();

        }


        public void getcheckshow(bool checkshow)
        {
            CheckShow = checkshow;
            Properties.Settings1.Default.CheckShow = CheckShow;
            Properties.Settings1.Default.Save();
        }
    }
}
