using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
namespace conjugador.Pages
{
    public class IndexModel : PageModel
    {
        public ConexionLematizador.Reconocimiento[] _reconocimientos;
        public ConexionLematizador.InfoCanonica[] _infoCanonicas;
        public string[] _sugerencias;
        public string[] _similares;

        private Services.LematizadorService _lematizadorService = new Services.LematizadorService();
        private Services.SpellCheckService _spellCheckService = new Services.SpellCheckService();

        [BindProperty]
        public string verb { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            verb = "";
            _lematizadorService = new Services.LematizadorService();
            _spellCheckService  = new Services.SpellCheckService();
            _reconocimientos    = new ConexionLematizador.Reconocimiento[] { };
            _infoCanonicas      = new ConexionLematizador.InfoCanonica[] { };
            _sugerencias        = new string[] { };
            _similares          = new string[] { };
        }


        public void OnPostSearch(string verb)
        {
            _reconocimientos = _lematizadorService.GetReconocimientosAsync(verb).Result;
            List<ConexionLematizador.InfoCanonica> canonicasRes = new List<ConexionLematizador.InfoCanonica>();
            for(int i = 0; i < _reconocimientos.Length; i++)
            {
                canonicasRes.Add(_lematizadorService.GetInfoCanonicaAsync(_reconocimientos[i].IdFormaCanonica).Result);
            }
            _infoCanonicas = canonicasRes.ToArray();
            if(_reconocimientos.Length > 0)
            {
                _sugerencias = _spellCheckService.GetSugerenciasAsync(verb).Result;
                _similares = _spellCheckService.GetSimilaresAsync(verb).Result;
            }
        }
    }
}
