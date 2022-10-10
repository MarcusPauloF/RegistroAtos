using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Core.Mensagens
{
    public abstract class Message
    {
        protected Message()
        {
            TipoMensagem = GetType().Name;
        }

        public string TipoMensagem { get; protected set; }
        public Guid AggregateId { get; protected set; }
    }
}
