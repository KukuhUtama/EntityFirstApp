using EntityFirstApp.Base;
using EntityFirstApp.IContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Context
{
    public class DatabaseFactory<D> : Disposable, IDatabaseFactory<D> where D : DataContext, new()
    {
        private D dataContext;
        public D Get()
        {
            return dataContext ?? (dataContext = new D());
        }

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
