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
        //Adicionar lista de parcelas e taxa de juros etc
        public String Nome {get; set;}
        public String Descricao {get; set;}
        String ID;
    }
    public class Parcela
    {
        public DateTime pagamento {get; set;}
        double ValorParcela {get; set;}
        //será usado pra atrelar-se ao seu "nó pai"
        String ID;
        //Informações vai ser um atributo genérico e por enquanto informará dados como taxa de juros e etc
        public Parcela(String ID)
        {
            this.ID=ID;
        }
}