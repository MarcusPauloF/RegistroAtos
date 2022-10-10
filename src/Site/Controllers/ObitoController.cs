using Microsoft.AspNetCore.Mvc;
using RegistroDeAtos.Core.Mediator;
using RegistroDeAtos.Services.ObitoService.Commands.Input;
using RegistroDeAtos.Services.ObitoService.Commands.Output;

namespace ResgistroDeAtos.Site.Controllers
{
    public class ObitoController : Controller
    {
        private readonly IMediatorHandler _mediatrHandler;

        public ObitoController(IMediatorHandler mediatrHandler)
        {
            _mediatrHandler = mediatrHandler;
        }

        public IActionResult Index()
        {
            List<QueryObito> obitos = new List<QueryObito>();
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
