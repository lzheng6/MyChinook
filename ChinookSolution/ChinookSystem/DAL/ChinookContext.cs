﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


#region Additional Namespaces
using System.Data.Entity;
using ChinookSystem.Data.Entities;
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
        //Setup all DbSet properties once Entity classed are created
        public DbSet<Artist> Artists{ get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Track> Tracks { get; set; }



    }
}
