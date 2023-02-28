using First.Solution.Domain.ProjectDomain;

class Program
{
    private static void Main(string[] args)
    {
        var pessoa = new Pessoa(); 
      
            Console.WriteLine("digite as informações das pessoas");
        Console.WriteLine("id: ");
        pessoa.PessoaId = Int32.Parse(Console.ReadLine());

    }
}