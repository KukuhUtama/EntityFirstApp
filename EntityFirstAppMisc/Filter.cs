using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstAppMisc
{
    public class Filter
    {
        /// <summary>
        /// Gets or sets PropertyName property.
        /// </summary>
        /// <value>
        /// The PropertyName.
        /// </value>
        public string PropertyName { get; set; }

        /// <summary>
        /// Gets or sets Operation property.
        /// </summary>
        /// /// <value>
        /// The Operation.
        /// </value>
        public Operator Operation { get; set; }

        /// <summary>
        /// Gets or sets Value property.
        /// </summary>
        /// /// <value>
        /// The Value.
        /// </value>
        public object Value { get; set; }
    }
}
