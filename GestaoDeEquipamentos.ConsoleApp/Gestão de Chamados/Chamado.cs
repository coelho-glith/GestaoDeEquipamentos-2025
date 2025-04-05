namespace GestaoDeEquipamentos.ConsoleApp;

public class Chamado
{
    public int Id;
    public string Titulo;
    public string Descricao;
    public Equipamento Equipamento;
    public DateTime DataDeAbertura;

    public Chamado(string titulo, string descricao,Equipamento equipamento)
    {
        this.Titulo = titulo;
        this.Descricao = descricao;
        this.Equipamento = equipamento;
        this.DataDeAbertura = DateTime.Now;
    }
}
