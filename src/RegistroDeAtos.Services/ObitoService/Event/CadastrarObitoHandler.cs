using MediatR;
using RegistroAtos.Domain.Entidade;
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
        public async Task<bool> Handle(ObitoCommand request, CancellationToken cancellationToken)
        {
            Obito obito = new Obito();
            obito.DataRegistro = request.DataRegistro;
            obito.DataObito = request.DataObito;
            obito.Falecido.Nome = request.Falecido.Nome;
            obito.Falecido.Data = request.Falecido.Data;
            obito.Pai.Nome = request.Pai.Nome;
            obito.Mae.Nome = request.Mae.Nome;
            obito.Pai.Data = request.Pai.Data;
            obito.Mae.Data = request.Mae.Data;

            await _obitoRepository.Create(obito);
            bool cadastrado = await _obitoRepository.Commit();
            return cadastrado;
        }
    }
}
