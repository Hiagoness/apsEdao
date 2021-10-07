using apsEdao.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apsEdao.Models.Calculadora;

namespace apsEdao.Controllers
{
    public class CalculadoraController : Controller
    {
        //
        //
        //      FAZER A REQUEST NO SEGUINTE FORMATO:
        //
        //      {
        //          "n1": valor,
        //          "n2": valor
        //      }
        //
        //

        [HttpPost]
        [Route("/unipam.rest/webresources/calculadora/somar")]
        public CalculadoraResponse CalculadoraRequest([FromBody] CalculadoraRequest request)
        {
            try
            {
                return new CalculadoraResponse(request);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }
}
