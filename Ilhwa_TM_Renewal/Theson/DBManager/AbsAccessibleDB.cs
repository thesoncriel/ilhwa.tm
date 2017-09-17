using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theson.DBManager
{
    public abstract class AbsAccessibleDB: AbsDBManager
    {
        public String Id
        {
            get
            {
                return Config["Database Server", "Id"];
            }
            set
            {
                Config["Database Server", "Id"] = value;
            }
        }
        public String Password
        {
            get
            {
                return Config["Database Server", "Password"];
            }
            set
            {
                Config["Database Server", "Password"] = value;
            }
        }
        
    }
}
