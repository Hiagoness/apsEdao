using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apsEdao.Models.Calculadora
{
    public class CalculadoraResponse
    {
        public int resultado { get; set; }
        public CalculadoraResponse()
        {
        }
        public CalculadoraResponse(int resultado)
        {
            this.resultado = resultado;
        }
        public CalculadoraResponse(CalculadoraRequest request)
        {
            this.resultado = request.n1 + request.n2;
        }
    }
}
