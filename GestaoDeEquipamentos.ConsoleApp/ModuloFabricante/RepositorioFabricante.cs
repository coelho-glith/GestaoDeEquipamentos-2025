using GestaoDeEquipamentos.ConsoleApp.Compartilhado;
using GestaoDeEquipamentos.ConsoleApp.ModuloChamado;

namespace GestaoDeEquipamentos.ConsoleApp.ModuloFabricante;

public class RepositorioFabricante
{
    public Fabricante[] fabricantes = new Fabricante[100];
    public int contadorFabricantes = 0;

    public void CadastrarFabricante(Fabricante novoFabricante)
    {
        novoFabricante.Id = GeradorIds.GerarIdFabricante();

        fabricantes[contadorFabricantes++] = novoFabricante;
    }

    public bool EditarFabricante(int idFabricante, Fabricante fabricanteEditadoo)
    {
        for (int i = 0; i < fabricantes.Length; i++)
        {
            if (fabricantes[i] == null)
                continue;

            else if (fabricantes[i].Id == idFabricante)
            {
                fabricantes[i].Nome = fabricanteEditadoo.Nome;
                fabricantes[i].Email = fabricanteEditadoo.Email;
                fabricantes[i].Telefone = fabricanteEditadoo.Telefone;

                return true;
            }
        }

        return false;
    }

    public Fabricante[] SelecionarFabricante()
    {
        return fabricantes;
    }

    public bool ExcluirFabricante(int idFabricante)
    {
        for (int i = 0; i < fabricantes.Length; i++)
        {
            if (fabricantes[i] == null) continue;

            else if (fabricantes[i].Id == idFabricante)
            {
                fabricantes[i] = null;

                return true;
            }
        }

        return false;
    }

    public Fabricante SelecionarFabricantePorId(int idFabricante)
    {
        for (int i = 0; i < fabricantes.Length; i++)
        {
            if (fabricantes[i] == null) continue;
            else if (fabricantes[i].Id == idFabricante)
                return fabricantes[i];
        }
        return null;
    }
}