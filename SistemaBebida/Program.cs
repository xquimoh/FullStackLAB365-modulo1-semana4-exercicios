using SistemaBebida;

int opcaoEscolhida = 0;

while (opcaoEscolhida != 7)
{
    Menu.DisplayInicial();
    opcaoEscolhida = Menu.SelecionarOpcao();
    
    switch (opcaoEscolhida)
    {
        case 1:
            Console.WriteLine("Você escolheu 'Inserir Bebida'! Precisamos coletar algumas informações:");            
            Menu.InserirBebida();
            break;

        case 2:
            Console.WriteLine("Você escolheu 'Alterar Bebida'! Precisamos coletar algumas informações:");         
            Menu.AlterarBebida();
            break;

        case 3:
            Console.WriteLine("Você escolheu 'Excluir Bebida'! Informe o Id da bebida:");
            int id = Convert.ToInt32(Console.ReadLine());
            Menu.ExcluirBebida(id);
            break;

        case 4:
            Console.WriteLine("Você escolheu 'Listar todas as bebidas'!");
            Repositorio.ListarTodasBebidas();
            break;

        case 5:
            Console.WriteLine("Você escolheu 'Listar todos os sucos'!");
            Repositorio.ListarTodosSucos();
            break;

        case 6:
            Console.WriteLine("Você escolheu 'Listar todos os refrigerantes'!");
            Repositorio.ListarTodosRefrigerantes();
            break;

        case 7:
            Console.Write("Obrigad@ por consultar o Sistema de Bebidas\nAté logo! :)");            
            break;

        default:
            Console.WriteLine("Opção inválida, aguarde 2 segundos para retornar ao menu principal");
            Thread.Sleep(2000);
            break;
    }    
}

