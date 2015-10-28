using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstApp.Context
{
    /// <summary>
    /// Interface for database context.
    /// </summary>
    public interface IDbContext : IDisposable
    {
        /// <summary>
        /// Gets the database context.
        /// </summary>
        /// <value>
        /// The database context.
        /// </value>
        DbContext DbContext { get; }

        /// <summary>
        /// Saves changes into persistence.
        /// </summary>
        /// <returns>Number of records that changes.</returns>
        int SaveChanges();
    }
}
