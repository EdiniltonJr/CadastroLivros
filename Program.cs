var livros = new List<string>();

while (true)
{
    Console.WriteLine("----MENU PRINCIPAL----");
    Console.WriteLine("1-Cadastrar Livros");
    Console.WriteLine("2-Listar Livros");
    Console.WriteLine("3-Remover Livros");
    Console.WriteLine("0-Sair");

    var opção = Console.ReadLine();

    switch (opção)
    {
        case "1":
        Console.WriteLine("Digite o título do livro");
        var nomelivro = Console.ReadLine();
        if (string.IsNullOrEmpty(nomelivro))
        {
            Console.WriteLine("Nome inválido. Tente novamente");
            break;
        }
        while (string.IsNullOrEmpty(nomelivro));
        livros.Add(nomelivro);
        Console.WriteLine("Livro cadastrado com sucesso!");
        break;

        case "2":
        foreach (var livro in livros)
        {
            Console.WriteLine(livro);
        }
        break;

        case "3":
        Console.WriteLine("Digite o nome do livro");
        var livroremover = Console.ReadLine();
        var sucesso = livros.Remove(livroremover);
        if (sucesso)
        {
            Console.WriteLine ("Livro removido com sucesso");
        }
        else
        {
            Console.WriteLine ("Livro não encontrado");
        }
        break;

        case "0":
        Console.WriteLine ("Encerrando a aplicação...");
        return ;
        default:
        Console.WriteLine ("Opção inválida!");
        break; 

    }
}
