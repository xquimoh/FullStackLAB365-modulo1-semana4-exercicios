using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBebida
{
    public static class Menu
    {
        public static void DisplayInicial()
        {
            Console.WriteLine("\nBem-vind@ ao Sistema de Bebidas!"); 
            Console.WriteLine("********************************\n"); 
        }

        public static int SelecionarOpcao()
        {
           try
           {
                Console.WriteLine("Selecione a opção desejada:");
                Console.WriteLine("1 - Inserir bebida");
                Console.WriteLine("2 - Alterar bebida");
                Console.WriteLine("3 - Excluir bebida");
                Console.WriteLine("4 - Listar todas as bebidas");
                Console.WriteLine("5 - Listar todos os sucos");
                Console.WriteLine("6 - Listar todos os refrigerantes");
                Console.WriteLine("7 - Sair");
                Console.WriteLine("\n");
                
                Console.WriteLine("Opção:");
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Essa opção não existe, por favor, selecione uma válida");
                Console.ReadLine();
            }

            return SelecionarOpcao();
        }

        public static bool ReiniciarDisplayConsole()
        {
            Console.WriteLine("\n");
            Console.WriteLine("************************");
            Console.WriteLine("Deseja reiniciar o menu?");
            Console.WriteLine("1 - Sim");
            Console.WriteLine("2 - Não");
            Console.WriteLine("\n");

            Console.WriteLine("Opção:");

            if (Convert.ToInt32(Console.ReadLine()) == 1)
            {
                Menu.SelecionarOpcao();
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void InserirBebida()
        {
            int id;
            string tipo;
            decimal mililitro; 
            string nomeBebida; 
            decimal valorCompra;

                Console.Write("Informe os dados da bebida a ser adicionada:\n");
                Console.Write("Qual é o id da bebida?\n");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o tipo de bebida que quer adicionar?\n");
                tipo = Console.ReadLine();
                Console.Write("Informe a quantidade de mL da bebida:\n");
                mililitro = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Qual o nome da bebida?\n");
                nomeBebida = Console.ReadLine();
                Console.Write("Qual o valor da bebida?\n");
                valorCompra = Convert.ToDecimal(Console.ReadLine());

                Bebida bebida = new Bebida(id, tipo, nomeBebida, mililitro, valorCompra);

                if(tipo == "suco") {
                Console.Write("Qual o tipo da caixa do suco?\n");
                string tipoCaixa = Console.ReadLine();

                Suco suco = new Suco(id, nomeBebida, mililitro, valorCompra, tipoCaixa);
                Repositorio.AdicionarSuco(suco);
                }

                if(tipo == "refrigerante") {
                Console.Write("Embalagem de vidro ou pet?\n");
                string embalagem = Console.ReadLine();
                bool vidro = (embalagem == "vidro") ? true : false;

                Refrigerante refrigerante = new Refrigerante(id, nomeBebida, mililitro, valorCompra, vidro);
                Repositorio.AdicionarRefrigerante(refrigerante);
                }

               Repositorio.AdicionarBebida(bebida);
        }

        public static void AlterarBebida()
        {
            int id;
            string tipo;
            decimal mililitro; 
            string nomeBebida; 
            decimal valorCompra;

                Console.Write("Qual o id da bebida?\n");
                id = Convert.ToInt32(Console.ReadLine());
                Console.Write("Qual o tipo de bebida?\n");
                tipo = Console.ReadLine();
                Console.Write("Informe a quantidade de mL da bebida:\n");
                mililitro = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Qual o nome da bebida?\n");
                nomeBebida = Console.ReadLine();
                Console.Write("Qual o valor da bebida?\n");
                valorCompra = Convert.ToDecimal(Console.ReadLine());

            foreach (var item in Repositorio.ListaBebidas.Where(x => x.Id == id)) 
            {
                item.NomeBebida = nomeBebida;
                item.Tipo = tipo;
                item.Mililitro = mililitro;
                item.ValorCompra = valorCompra;
            }
        }

        public static void ExcluirBebida(int id)
        {
            var localBebida = Repositorio.ListaBebidas.FirstOrDefault(w => w.Id == id);
            if (localBebida != null)
            {
                Repositorio.ListaBebidas.Remove(localBebida);
            }
        }
    }
}