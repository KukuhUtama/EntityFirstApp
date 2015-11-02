using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Context
{
    public class DataContext : DbContext, IDataContext
    {
        private readonly Guid _instanceId;

        public DataContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {
            _instanceId = Guid.NewGuid();
            //Configuration.LazyLoadingEnabled = false;
            //Configuration.ProxyCreationEnabled = false;
        }

        public Guid InstanceId
        {
            get { return _instanceId; }
        }

        public new DbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public override int SaveChanges()
        {
            var changes = base.SaveChanges();
            return changes;
        }
    }
}
