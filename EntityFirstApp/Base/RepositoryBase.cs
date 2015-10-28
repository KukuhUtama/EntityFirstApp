using EntityFirstApp.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Base
{
    public class RepositoryBase<T> where T: class, IDbContext
    {
        public RepositoryBase()
        {

        }
        protected IContextFactory<T> ContextFactory { get; set; }

        protected T Context
        {
            get
            {
                return this.ContextFactory.GetContext();
            }
        }

    }
}
