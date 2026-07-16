using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaRendaCS.Models
{
    public class Despesa
    {
        public double ValorTotal {get; set;}
        public double ValorUnico {get; set}
        public String Nome {get; set;}
        public String Descricao {get; set;}
    }
}