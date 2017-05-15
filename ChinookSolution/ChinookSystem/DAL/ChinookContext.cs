using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Additional Namespaces
using System.Data.Entity;
#endregion

namespace ChinookSystem.DAL
{
    //This is an internal class for security reasons
    //Access is restricted to within this class library project
    //Tnherits DbContext for Entity Framework,which requires
    //  System.Data.Entity
    internal class ChinookContext:DbContext
    {
        //Pass the connection string name to the 
        // DbContext using :base()
        // i.e.connection string name is "ChinookDB"
        public ChinookContext():base("ChinookDB")
            {

             }


    }
}
