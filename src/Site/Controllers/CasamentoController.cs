using Microsoft.AspNetCore.Mvc;
using RegistroDeAtos.Core.Mediator;
using RegistroDeAtos.Services.CasamentoService.Commands.Input;
using RegistroDeAtos.Services.CasamentoService.Commands.Output;

namespace ResgistroDeAtos.Site.Controllers
{
    public class CasamentoController : Controller
    {
        private readonly IMediatorHandler _mediatrHandler;
        public CasamentoController(IMediatorHandler mediatrHandler)
        {
            _mediatrHandler = mediatrHandler;
        }
        public IActionResult Index()
        {
            List<QueryCasamento> casamentos = new List<QueryCasamento>();
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
