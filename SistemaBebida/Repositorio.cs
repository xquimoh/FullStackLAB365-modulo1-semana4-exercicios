using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SistemaBebida;

namespace SistemaBebida
{
     public static class Repositorio
    {
        public static List<Bebida> ListaBebidas {get; set; }
        public static List<Suco> ListaSuco {get; set; }
        public static List<Refrigerante> ListaRefrigerante {get; set;}


        static Repositorio()
        {
            if (ListaBebidas == null)
            {
                ListaBebidas = new List<Bebida>();
            }

            if (ListaSuco == null)
            {
                ListaSuco = new List<Suco>();
            }

            if (ListaRefrigerante == null)
            {
                ListaRefrigerante = new List<Refrigerante>();
            }
        }
        public static void AdicionarSuco(Suco suco)
        {
            ListaSuco.Add(suco);
        }
        public static void AdicionarRefrigerante(Refrigerante refrigerante)
        {
            ListaRefrigerante.Add(refrigerante);
        }
       
        public static void AdicionarBebida(Bebida bebida)
        {
             ListaBebidas.Add(bebida);
        }

        public static void AlterarBebida(Bebida bebida)
        {

            foreach (var item in ListaBebidas.Where(listaEmMemoria => listaEmMemoria.Id == bebida.Id)) 
            {
                item.NomeBebida = bebida.NomeBebida;
                item.Tipo = bebida.Tipo;
                item.Mililitro = bebida.Mililitro;
            }
        }

        public static void ExcluirBebida(int id)
        {
            var localBebida = ListaBebidas.FirstOrDefault(w => w.Id == id);
            if (localBebida != null)
            {
                ListaBebidas.Remove(localBebida);
            }
        }

        public static void ImprimirDados()
        {
            foreach (var bebida in ListaBebidas)
            {
                bebida.ImprimirDados();
            }
        }

        public static void ImprimirSuco()
        {
            foreach (var suco in ListaSuco)
            {
                suco.ImprimirDados();
            }
        }

        public static void ImprimirRefrigerante()
        {
            foreach (var refrigerante in ListaRefrigerante)
            {
                refrigerante.ImprimirDados();
            }
        }

        public static void ListarTodasBebidas()
        {
            foreach (var bebida in ListaBebidas)
            {
                bebida.ImprimirDados();
            }
        }

        public static void ListarTodosSucos()
        {
            foreach (var suco in ListaSuco)
            {
                suco.ImprimirDados();
            }
        }

        public static void ListarTodosRefrigerantes()
        {
            foreach (var refrigerante in ListaRefrigerante)
            {
                refrigerante.ImprimirDados();
            }
        }
    }
}