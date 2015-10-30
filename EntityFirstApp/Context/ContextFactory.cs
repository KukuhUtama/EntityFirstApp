using EntityFirstApp.Context;
using Microsoft.Practices.ServiceLocation;

namespace EntityFirstApp
{
    /// <summary>
    /// Connection factory, that generate context based on tenant identifier.
    /// </summary>
    /// <typeparam name="T">Type parameter.</typeparam>
    public class ContextFactory<T> : IContextFactory<T> where T : class, IDbContext
    {
        /// <summary>
        /// The context.
        /// </summary>
        private T _context;

        /// <summary>
        /// The database connection string factory.
        /// </summary>
        private IDbConnectionStringFactory _databaseConnectionStringFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContextFactory{T}"/> class.
        /// </summary>
        /// <param name="connectionStringFactory">The connection string factory.</param>
        public ContextFactory(IDbConnectionStringFactory connectionStringFactory)
        {
            this._databaseConnectionStringFactory = connectionStringFactory;
        }

        /// <summary>
        /// Gets the context based on the tenant identifier.
        /// </summary>
        /// <returns>Context based on the tenant identifier.</returns>
        public T GetContext()
        {
            if (this._context == null)
            {
                this._context = ServiceLocator.Current.GetInstance(typeof(T)) as T;

                var tenantConnectionString = this._databaseConnectionStringFactory.FindConnectionStringByTenantId();

                if (!string.IsNullOrEmpty(tenantConnectionString))
                {
                    this._context.DbContext.Database.Connection.ConnectionString = tenantConnectionString;
                }
            }

            return this._context;
        }
    }
}
