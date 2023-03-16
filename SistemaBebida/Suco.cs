using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBebida
{
    public class Suco : Bebida
    {
        public string TipoCaixa { get; set; }

        public Suco(int id, string nome, decimal mililitro, decimal valorCompra, string tipoCaixa) : base(id, "suco", nome, mililitro, valorCompra)
        {          
            this.TipoCaixa = tipoCaixa;
        }

        public override void ImprimirDados()
        {
            Console.WriteLine($"O produto id {this.Id} é um suco de {this.Mililitro} mL na embalagem {this.TipoCaixa}");            
        }
    }
}