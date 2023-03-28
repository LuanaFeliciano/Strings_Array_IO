// 5) Arquivo “produtos_estoque” mostrar o valor total de itens em estoque e o valor total em $.


TextReader produtos = new StreamReader("C:\\Users\\luana\\OneDrive\\Documentos\\aula6\\produtos_estoque.txt");

String linha = produtos.ReadLine();
int totalItems = 0;
decimal totalValor = 0;
while (linha != null)
{

    string[] dados = linha.Split("\t");
    string valorParaConverter = dados[1].Replace("$", "").Replace(".", ",");
    string itensParaConverter = dados[2].Replace("|", "");


    decimal valor = Decimal.Parse(valorParaConverter);
    int itens = int.Parse(itensParaConverter);

    totalItems += itens;
    if (itens != 0)
    {
        totalValor += valor;
    }


    linha = produtos.ReadLine();

}

Console.WriteLine("total de itens em estoque: " + totalItems);
Console.WriteLine("valor total de todos os itens: " + totalValor.ToString("C"));
