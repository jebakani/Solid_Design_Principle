using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion
{
    class AccessFactory
    {
        //method to access the GetDetail method 
        //returns th object of operation management class
        public static IGetAccess GetDetails()
        {
            return new OperationManagement();
        }

    
    }
}
