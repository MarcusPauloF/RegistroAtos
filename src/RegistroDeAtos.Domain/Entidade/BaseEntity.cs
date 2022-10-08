using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroAtos.Domain.Entidade
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            Id = Guid.NewGuid();
            DataRegistro = DateTime.UtcNow.AddHours(-3);
        }

        public Guid Id { get; set; }
        public DateTime DataRegistro { get; set; }
        public bool Desabilitar { get; set; }
    }
}
