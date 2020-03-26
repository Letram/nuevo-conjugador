using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;
namespace conjugador.Pages.Components
{
    public class Rec_Table_Controller : ComponentBase
    {
        [Parameter] public ConexionLematizador.Reconocimiento[] reconocimientos { get; set; }
        [Parameter] public ConexionLematizador.InfoCanonica[] infoCanonicas { get; set; }
        [Parameter] public string Text { get; set; }

        [Parameter] public int selectedIndex { get; set; }
        public string[] reconocimientoHeaders = 
        { 
            "Forma canónica", 
            "Frecuencia", 
            "Código de flexión",
            "Código de forma canónica", 
            "Prefijos", 
            "Pronombres" 
        };

        public string[] canonicaHeaders =
        {
            "AntiguaField",
            "DRAEXXIIIField",
            "FormaCanonicaField",
            "FrecuenciaField",
            "IdCategoriaField",
            "IdCategoriaGNField",
            "IdFlexionField",
            "MaxAcepcionesField",
            "MaxEtimologiaField",
            "NumAcepcionField",
            "NumAcepcionSecField",
            "NumEtimologiaField",
            "PosAcepcionField",
            "PosAcepcionSecField"
        };
    }
}
