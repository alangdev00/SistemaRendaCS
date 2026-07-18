using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaRendaCS.Models
{
    public class Ano
    {
        
        List<Mes> meses=new List<Mes>();
        public Ano()
        {
            for (int i = 1; i <= 12; i++)
            {
                this.meses.Add(Mes)
            }
        }
    }
}