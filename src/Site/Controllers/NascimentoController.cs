using Microsoft.AspNetCore.Mvc;
using RegistroDeAtos.Core.Mediator;
using RegistroDeAtos.Services.NascimentoService.Commands.Input;
using RegistroDeAtos.Services.NascimentoService.Commands.Output;

namespace ResgistroDeAtos.Site.Controllers
{
    public class NascimentoController : Controller
    {
        private readonly IMediatorHandler _mediatrHandler;

        public NascimentoController(IMediatorHandler mediatrHandler)
        {
            _mediatrHandler = mediatrHandler;
        }

        public IActionResult Index()
        {
            List<QueryNascimento> nascimentos = new List<QueryNascimento>();
            return View();
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(NascimentoCommand nascimentoCommand)
        {
            bool nascimento = await _mediatrHandler.EnviarComando(nascimentoCommand);

            return RedirectToAction(nameof(Index));
        }
    }
}
