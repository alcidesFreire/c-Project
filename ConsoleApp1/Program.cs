using First.Solution.Domain.ProjectDomain;
using System.Runtime.Serialization;
using System.Text.Json;
class Program
{
    private static void Main(string[] args)
    {
        var pessoa = new Pessoa();  //tipos anonimos

        
      
            Console.WriteLine("digite as informações das pessoas");
        Console.WriteLine("id: ");
        pessoa.PessoaId = Int32.Parse(Console.ReadLine());
        Console.WriteLine("nome: ");
        pessoa.Nome = Console.ReadLine();
        Console.WriteLine("data de nascimento: ");
        pessoa.DataNascimento = DateTime.Parse(Console.ReadLine());

        //Instanciar tipo de atividade
        var tipoAtividade = new TipoAtividade();
        Console.WriteLine("digite o id do tipo de atividade: ");
        tipoAtividade.TipoAtividadeId = Int32.Parse(Console.ReadLine());
        Console.WriteLine("digite a descrição: ");
        tipoAtividade.Descricao = (Console.ReadLine());


        //instanciar atividade complementar
        var atividadeComplementar = new AtividadeComplementar();
        Console.WriteLine("digite o id da atividade complementar: ");
       atividadeComplementar.AtividadeComplementarId = Int32.Parse(Console.ReadLine());
        Console.WriteLine("digite a data: ");
        atividadeComplementar.Data = DateTime.Parse(Console.ReadLine());
        Console.WriteLine("digite a instituição: ");
       atividadeComplementar.Instituicao = (Console.ReadLine());
        Console.WriteLine("digite o ano de formação: ");
        atividadeComplementar.AnoFormacao = Int32.Parse(Console.ReadLine());

        atividadeComplementar.Aluno = pessoa;
        atividadeComplementar.Tipo = tipoAtividade;
        // Console.WriteLine("id do aluno: " + pessoa.PessoaId + "nome do aluno: " + pessoa.Nome + "data de nascimento: " + pessoa.DataNascimento);
        // Console.WriteLine("\n");
        //Console.WriteLine("id do tipo de atividade: " + tipoAtividade.TipoAtividadeId + "descrição: " + tipoAtividade.Descricao);
        //Console.WriteLine("\n");
        //Console.WriteLine("id da atividade complementar: " + atividadeComplementar.AtividadeComplementarId + "data: " +
        //  atividadeComplementar.Data + "instituição: " + atividadeComplementar.Instituicao + "ano de formação: " + atividadeComplementar.AnoFormacao + atividadeComplementar.Aluno + atividadeComplementar.Tipo);
     Console.WriteLine(JsonSerializer.Serialize(atividadeComplementar));
    }
}