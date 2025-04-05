namespace GestaoDeEquipamentos.ConsoleApp;

public static class TelaMenuPrincipal
{
    public static void MostrarMenu()
    {
        Console.Clear();
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("           Bem vindo ao Sistema             ");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("    Por favor escolha uma opção abaixo      ");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("1 - Entrar em menu de Equipamentos");
        Console.WriteLine("2 - Entrar em menu de Chamados");
        Console.WriteLine("--------------------------------------------");
        Console.Write("Digite uma opção: ");
    }
}
