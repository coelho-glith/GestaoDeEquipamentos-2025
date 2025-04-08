using GestaoDeEquipamentos.ConsoleApp.ModuloEquipamento;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloFabricante;

public class Fabricante
{
    public int Id;
    public string Nome;
    public string Email;
    public string Telefone;

    public Fabricante(string nome, string email,string telefone)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
    }

    public override string ToString()
    {
        return Nome;
    }
}
