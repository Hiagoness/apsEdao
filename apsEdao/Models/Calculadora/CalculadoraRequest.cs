using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apsEdao.Models.Calculadora
{
    public class CalculadoraRequest
    {
        [JsonProperty("n1")]
        public int n1 { get; set; }

        [JsonProperty("n2")]
        public int n2 { get; set; }

        public CalculadoraRequest()
        {
        }

        public CalculadoraRequest(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }

    }
}
