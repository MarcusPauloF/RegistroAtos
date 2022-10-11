using Microsoft.AspNetCore.Mvc;
using RegistroDeAtos.Core.Mediator;
using RegistroDeAtos.Services.CasamentoService.Commands.Input;
using RegistroDeAtos.Services.CasamentoService.Commands.Output;
using RegistroDeAtos.Services.CasamentoService.Query;

namespace ResgistroDeAtos.Site.Controllers
{
    public class CasamentoController : Controller
    {
        private readonly IMediatorHandler _mediatrHandler;
        private readonly IConsultarCasamentoQuery _consultarCasamentoQuery;
        public CasamentoController(IMediatorHandler mediatrHandler,
            IConsultarCasamentoQuery consultarCasamentoQuery)
        {
            _mediatrHandler = mediatrHandler;
            _consultarCasamentoQuery = consultarCasamentoQuery;
        }
        public async Task<IActionResult> Index()
        {
            List<QueryCasamento> casamentos = new List<QueryCasamento>();
            casamentos = await _consultarCasamentoQuery.ObterTodos();
            return View(casamentos);
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Cadastrar(CasamentoCommand casamentoCommand)
        {
            bool casamento = await _mediatrHandler.EnviarComando(casamentoCommand);
            
            return RedirectToAction(nameof(Index));
        }

    }
}
