using Microsoft.AspNetCore.Mvc;
using RegistroDeAtos.Core.Mediator;
using RegistroDeAtos.Services.NascimentoService.Commands.Input;
using RegistroDeAtos.Services.NascimentoService.Commands.Output;
using RegistroDeAtos.Services.NascimentoService.Query;

namespace ResgistroDeAtos.Site.Controllers
{
    public class NascimentoController : Controller
    {
        private readonly IMediatorHandler _mediatrHandler;
        private readonly IConsultarNascimentoQuery _consultarNascimentoQuery;

        public NascimentoController(IMediatorHandler mediatrHandler,
            IConsultarNascimentoQuery consultarNascimentoQuery)
        {
            _mediatrHandler = mediatrHandler;
            _consultarNascimentoQuery = consultarNascimentoQuery;
        }

        public async Task<IActionResult> Index()
        {
            List<QueryNascimento> nascimentos = new List<QueryNascimento>();
            nascimentos = await _consultarNascimentoQuery.ObterTodos();
            return View(nascimentos);
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
