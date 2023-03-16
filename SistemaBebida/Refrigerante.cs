using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBebida
{
    public class Refrigerante : Bebida
    {
        public bool Vidro { get; set; }

        public Refrigerante(int id, string nome, decimal mililitro, decimal valorCompra, bool vidro) : base(id, "refrigerante",nome, mililitro, valorCompra)
        {          
            this.Vidro = vidro;
        }

        public override void ImprimirDados()
        {
            string tipoEmbalagem = Vidro ? "vidro" : "garrafa pet";
            if (Vidro)
            {
                Console.WriteLine($"O produto id {Id}, com nome {NomeBebida}, é um refrigerante de {Mililitro} mL envasado em {tipoEmbalagem}");
            }
            else
            {
                Console.WriteLine($"O produto id {Id}, com nome {NomeBebida}, é um refrigerante de {Mililitro} mL envasado em garrafa pet");
            }
        }   
    }
}