namespace GestaoDeEquipamentos.ConsoleApp;

public class TelaChamado
{
    public Chamado[] chamados = new Chamado[100];
    public int contadorChamado = 0;

    public string ApresentarMenuChamado()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Gestão de Chamados");
        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("Escolha a operação desejada:");
        Console.WriteLine("1 - Registro de Chamado");
        Console.WriteLine("2 - Edição de Chamado");
        Console.WriteLine("3 - Exclusão de Chamado");
        Console.WriteLine("4 - Visualização de CHamados");
        Console.WriteLine("--------------------------------------------");

        Console.Write("Digite um opção válida: ");
        string opcaoEscolhida = Console.ReadLine();

        return opcaoEscolhida;
    }

    public void RegistrarChamado(TelaEquipamento telaequipamentos)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Gestão de Chamados");
        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("registrando Chamado...");
        Console.WriteLine("--------------------------------------------");

        Console.WriteLine();

        Console.Write("Digite o Título do Chamado: ");
        string titulo = Console.ReadLine();

        Console.Write("Digite sobre a descrição do Chamado: ");
        string descricao = Console.ReadLine();

        Console.Write("Digite o Id do chamado: ");
        string equipamento = Console.ReadLine();

        Console.Write("Digite o id do equipamento que deseja abrir o chamado: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        Equipamento equipamentoEncontrado = EquipamentoExistente(telaequipamentos, idSelecionado);

        if (equipamentoEncontrado != null)
            Console.WriteLine("Chamado Registrado com perfeição!");

        else
            Console.WriteLine("Equipamento não Achado.");

        Chamado novoChamado = new Chamado(titulo , descricao, equipamentoEncontrado);
        novoChamado.Id = GeradorIds.GerarIdChamado();

        chamados[contadorChamado++] = novoChamado;

        Console.ReadLine();
    }

    public void EditarChamado(TelaEquipamento telaequipamentos)
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Gestão de Chamados");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Editando Chamado...");
        Console.WriteLine("--------------------------------------------");

        Console.Write("Digite o ID do registro que deseja selecionar: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        Chamado chamadoEncontrado = null;

        for (int i = 0; i < chamados.Length; i++)
        {
            if (chamados[i].Id == idSelecionado)
            {
                chamadoEncontrado = chamados[i];
                break;

            }
        }

        Console.WriteLine();

        if (chamadoEncontrado != null)
        { 
            Console.Write("Digite o novo Título do Chamado: ");
            string titulo = Console.ReadLine();

            Console.Write("Digite uma nova descrição do Chamado: ");
            string descricao = Console.ReadLine();

            Console.Write("Digite o iD do equipamento que deseja colocar para o chamado: ");
            idSelecionado = Convert.ToInt32(Console.ReadLine());

            Equipamento equipamentoEncontrado = EquipamentoExistente(telaequipamentos, idSelecionado);

            chamadoEncontrado.Titulo = titulo;
            chamadoEncontrado.Descricao = descricao;
            chamadoEncontrado.Equipamento = equipamentoEncontrado;

            Console.WriteLine("O Chamado foi editado com sucesso!");
        }
        else
            Console.WriteLine("Chamado não definido.");
            Console.ReadLine();
    }

    public static Equipamento EquipamentoExistente(TelaEquipamento telaequipamentos, int id)
    {
        Equipamento equipamentoEncontrado = null;

        foreach (Equipamento equipamento in telaequipamentos.equipamentos)
        {
            if (equipamento != null && equipamento.Id == id)
            {
                equipamentoEncontrado = equipamento;
                break;

            }
        }

        return equipamentoEncontrado;
    }

    public void ExcluirChamado()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Gestão de Chamados");
        Console.WriteLine("--------------------------------------------");

        Console.WriteLine("Excluindo Chamado...");
        Console.WriteLine("--------------------------------------------");

        VisualizarChamados(false);

        Console.Write("Digite o ID do registro que deseja selecionar: ");
        int idSelecionado = Convert.ToInt32(Console.ReadLine());

        bool conseguiuExcluir = false;

        for (int i = 0; i < chamados.Length; i++)
        {
            if (chamados[i] == null) continue;

            else if (chamados[i].Id == idSelecionado)
            {
                chamados[i] = null;
                conseguiuExcluir = true;
            }
        }

        if (!conseguiuExcluir)
        {
            Console.WriteLine("Houve um erro durante a exclusão de um registro...");
            return;
        }

        Console.WriteLine();
        Console.WriteLine("O Chamado foi excluído com sucesso!");
        Console.ReadLine();
    }

    public void VisualizarChamados(bool exibirTitulo)
    {
        if (exibirTitulo)
        {
            Console.Clear();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Gestão de Chamados");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Visualizando Chamados...");
            Console.WriteLine("--------------------------------------------");
        }

        Console.WriteLine();

        Console.WriteLine(
            "{0, -7} | {1, -14} | {2, -17} | {3, -13} | {4, -20} | ",
            "Id", "Titulo", "Equipamento", "Data De Abertura", "Número de dias que o chamado está aberto"
        );

        for (int i = 0; i < chamados.Length; i++)
        {
            Chamado y = chamados[i];

            if (y == null) continue;

            Console.WriteLine(
                "{0, -7} | {1, -14} | {2, -17} | {3, -13} | {4, -20:F0} | ",
                y.Id, y.Titulo, y.Equipamento, y.DataDeAbertura.ToString("dd,MM,yyyy"), (DateTime.Now - chamados[i].DataDeAbertura).TotalDays
            );
        }

        Console.WriteLine();
    }
}




