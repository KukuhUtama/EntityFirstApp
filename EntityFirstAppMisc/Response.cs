using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstAppMisc
{
    public class Response<TModel> : ResponseBase
    {
        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The entity.
        /// </value>
        public TModel Model { get; set; }
    }
}
