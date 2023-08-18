using OrientaçãoObjs.Models;

//Pessoa pessoa = new Pessoa();
//pessoa.setNome("Ygor");
//Console.WriteLine(pessoa.GetNome());

Produto produto = new Produto();
produto.Nome = "Bolacha";
produto.Preco = 4.5;
produto.Validade = DateTime.Now;
Console.WriteLine(produto);

Produto produto1 = new Produto
{
    Nome = "Arroz",
    Preco = 10,
    Validade = DateTime.Now
};

Console.WriteLine(produto1);
