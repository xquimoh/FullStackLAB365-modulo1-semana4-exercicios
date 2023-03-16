using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBebida
{
    // Criando a Classe-pai Bebida
    public class Bebida
    {
        // Propriedades da Classe-pai Bebida: Id, Tipo, Mililitro, NomeBebida e ValorCompra
        public int Id { get; set; }
        public string Tipo { get; set; } // Valores permitidos: "refrigerante" ou "suco"
        public decimal Mililitro { get; set; }
        public string NomeBebida { get; set; }
        public decimal ValorCompra { get; set; }


        public Bebida(int id, string tipo, string nome, decimal mililitro, decimal valorCompra) 
        {
            this.Id = id;
            this.Tipo = tipo;
            this.NomeBebida = nome;
            this.Mililitro = mililitro;
            this.ValorCompra = valorCompra;   
        }
        
        // Método público denominado Comprar
        public void Comprar(decimal novoValorCompra)
        {
            ValorCompra = novoValorCompra;
            Console.WriteLine($"Valor da compra do produto id {Id} alterado para {ValorCompra}");
        }

        public virtual void ImprimirDados()
        {
            Console.WriteLine($"O produto id {this.Id} é uma bebida com {this.Mililitro} mL"); 
        }
    }
}