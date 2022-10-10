using MediatR;
using RegistroAtos.Domain.Repositorio;
using RegistroDeAtos.Services.ObitoService.Commands.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDeAtos.Services.ObitoService.Event
{
    public class CadastrarObitoHandler : IRequestHandler<ObitoCommand, bool>
    {
        public readonly IObitoRepository _obitoRepository;

        public CadastrarObitoHandler(IObitoRepository obitoRepository)
        {
            _obitoRepository = obitoRepository;
        }
        public Task<bool> Handle(ObitoCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
