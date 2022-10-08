using FluentValidation.Results;
using MediatR;

namespace RegistroDeAtos.Core.Mensagens
{
    public abstract class Command : Message, IRequest<bool>
    {
        public DateTime DataHora { get; private set; }
        public ValidationResult ValidationResult { get; private set; }

        protected Command()
        {
            DataHora = DateTime.Now;
        }
        public virtual ValidationResult EhValido()
        {
            throw new NotImplementedException();
        }
    }
}