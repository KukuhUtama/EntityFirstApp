using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Context
{
    public class DatabaseFactory : IDatabaseFactory<DbContext>
    {
        DbContext Get()
        {
           
            //var xx = new DbContext(); 
            return null;
        }
    }
}
