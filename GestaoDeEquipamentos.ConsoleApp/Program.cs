namespace GestaoDeEquipamentos.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {

        TelaEquipamento telaEquipamento = new TelaEquipamento();
        TelaChamado telaChamado = new TelaChamado();

        while (true)
        {
            TelaMenuPrincipal.MostrarMenu();
            string opcaoEscolhida = Console.ReadLine();
            switch (opcaoEscolhida)
            {
                case "1": MenuEquipamento(telaEquipamento); break;

                case "2": MenuChamado(telaChamado, telaEquipamento); break;
                default:
                    Console.WriteLine("Opção não selecionada corretamente, Desligando programa");
                    return;
            }

        }
    }

    public static void MenuEquipamento(TelaEquipamento telaEquipamento)
    {
        string opcaoEscolhida = telaEquipamento.ApresentarMenu();

        switch (opcaoEscolhida)
        {
            case "1":
                telaEquipamento.CadastrarEquipamento(); break;
            case "2":
                telaEquipamento.EditarEquipamento(); break;
            case "3":
                telaEquipamento.ExcluirEquipamento(); break;
            case "4":
                telaEquipamento.VisualizarEquipamentos(true); break;
            default:
                Console.WriteLine("Saindo do programa..."); break;
        }
    }

    public static void MenuChamado(TelaChamado telaChamado, TelaEquipamento telaEquipamento)
    {
        string opcaoEscolhida = telaChamado.ApresentarMenuChamado();
        switch (opcaoEscolhida)
        {
            case "1":
                telaChamado.RegistrarChamado(telaEquipamento); break;
            case "2":
                telaChamado.EditarChamado(telaEquipamento); break;
            case "3":
                telaChamado.ExcluirChamado(); break;
            case "4":
                telaChamado.VisualizarChamados(true); break;
            default:
                Console.WriteLine("opção não selecionada corretamente, Desligando programa"); break;
        }
    }
}