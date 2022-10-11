using Microsoft.AspNetCore.Mvc;
using RegistroDeAtos.Core.Mediator;
using RegistroDeAtos.Services.ObitoService.Commands.Input;
using RegistroDeAtos.Services.ObitoService.Commands.Output;
using RegistroDeAtos.Services.ObitoService.Query;

namespace ResgistroDeAtos.Site.Controllers
{
    public class ObitoController : Controller
    {
        private readonly IMediatorHandler _mediatrHandler;
        private readonly IConsultarObitoQuery _consultarObitoQuery;

        public ObitoController(IMediatorHandler mediatrHandler,
            IConsultarObitoQuery consultarObitosQuery)
        {
            _mediatrHandler = mediatrHandler;
            _consultarObitoQuery = consultarObitosQuery;
        }

        public async Task<IActionResult> Index()
        {
            List<QueryObito> obitos = new List<QueryObito>();
            obitos = await _consultarObitoQuery.ObterTodos();
            return View(obitos);

        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(ObitoCommand obitoCommand)
        {
            bool obito = await _mediatrHandler.EnviarComando(obitoCommand);

            return RedirectToAction(nameof(Index));
        }
    }
}
