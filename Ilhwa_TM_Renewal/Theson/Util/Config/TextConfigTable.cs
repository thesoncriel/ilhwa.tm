using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Theson.Common;

namespace Theson.Util.Config
{
    public abstract class TextConfigTable: AbsConfigTable
    {

    	
		public override void Load(string targetPath)
		{
			throw new NotImplementedException();
		}
    	
		public override bool GoToCategory(String category)
        {
            throw new NotImplementedException();
        }
    }
}
