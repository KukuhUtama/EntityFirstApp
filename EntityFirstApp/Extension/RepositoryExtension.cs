using EntityFirstAppMisc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Extension
{
    public static class RepositoryExtension
    {
        public static IEnumerable<T> GetEntityByParam<T>(IDbSet<T> value, List<Filter> filters) where T:class
        {
            IEnumerable<T> filteredCollection = null;

            if (filters.Count > 0)
            {
                var expression = ExpressionBuilder.GetExpression<T>(filters).Compile();
                filteredCollection = value.Where(expression).ToList(); 
            }
            else
            {
                filteredCollection = value.ToList<T>();
            }

            return filteredCollection;
        }
    }
}
