using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Theson.DBManager
{
    public abstract class AbsDBServer: AbsAccessibleDB
    {
        public String Address
        {
            get
            {
                return Config["Database Server", "Address"];
            }
            set
            {
                Config["Database Server", "Address"] = value;
            }
        }
        
        public String IP{
        	get{
                return Config["Database Server", "IP"];
        	}
        	set{
                Config["Database Server", "IP"] = value;
        	}
        }
        
        public String DefaultDB{
        	get{
        		return Config["Database Server", "DefaultDB"];
        	}
        	set{
        		Config["Database Server", "DefaultDB"] = value;
        	}
        }
    }
}
