namespace OrientaçãoObjs.Models;
public class Produto
{
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public DateTime Validade { get; set; }

    public override string? ToString()
    {
        return $"Nome: {Nome} \nPreço: {Preco}";
    }
}