using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFirstAppMisc
{
   public class ResponseBase
    {
        /// <summary>
        /// List of exception message.
        /// </summary>
       private List<Message> _messages;

         /// <summary>
         /// Initializes a new instance of the <see cref="ResponseBase"/> class.
         /// </summary>
        public ResponseBase()
        {
            this._messages = new List<Message>();
        }

        /// <summary>
        /// Gets the messages.
        /// </summary>
        /// <value>
        /// The messages.
        /// </value>
        public IList<Message> Messages
        {
            get { return this._messages; }
        }
    }
}

