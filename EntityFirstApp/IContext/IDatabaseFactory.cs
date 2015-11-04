using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.IContext
{
    public interface IDatabaseFactory<D> : IDisposable where D : DbContext
    {
        D Get();
    }
}
