using First.Solution.Domain.ProjectDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSolution.userInterface.Console.ConsoleApp
{
    class Program
    {
        static List<Pessoa> listaPessoa = new List<Pessoa>();
        static List< TipoAtividade> listaAtividade = new List<TipoAtividade>();
        static List<AtividadeComplementar> listaAtividadeComplementar = new List<AtividadeComplementar>();

        public static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("ola, digite a ação 1-cadastro de aluno 2-cadastro de atividade  3-cadastro de atividade complementar 4-alteracao de alunos" +
                    " 5-alteracao de atividades 6-alteração de atividade complementar " +
                    "7-excluir alunos 8-excluir atividades 9-excluir atividade complementar  10-ler atividades 11-ler alunos 12-ler atividade complementar 13-sair");
                int op = Int32.Parse(System.Console.ReadLine());

                switch (op)
                {
                    //cadastro de alunos
                    case 1:
                        System.Console.WriteLine("digite o id do aluno");
                        int pessoaID = Int32.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("digite o nome");
                        string Nome = System.Console.ReadLine();
                        System.Console.WriteLine("digite a data de nascimento:");
                        DateTime DataNascimento = DateTime.Parse(System.Console.ReadLine());
                        Pessoa p = new Pessoa(pessoaID, Nome, DataNascimento);
                        listaPessoa.Add(p);

                        break;

                    //cadastro de atividades
                    case 2:

                        System.Console.WriteLine("digite o id da atividade:");
                        int TipoAtividadeID = Int32.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("digite a descrição:");
                        string Descricao = System.Console.ReadLine();
                        TipoAtividade t = new TipoAtividade(TipoAtividadeID, Descricao);
                      listaAtividade.Add(t);
                        break;

                        //cadastro de atividade complementar
                    case 3:
                        System.Console.WriteLine("digite o id da atividade complementar:");
                        int AtividadeComplementarID = Int32.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("digite a data da atividade:");
                        DateTime data = DateTime.Parse(System.Console.ReadLine());
                        
                        System.Console.WriteLine("digite o id do aluno:");
                        int idPessoa = Int32.Parse(System.Console.ReadLine());
                        var aluno = GetPessoa(idPessoa);

                        System.Console.WriteLine("digite o id do tipo de atividade:");
                        int idTipoAtividade = Int32.Parse(System.Console.ReadLine());
                        var tipoAtividade = GetTipoAtividade(idTipoAtividade);

                        System.Console.WriteLine("digite a instituição");
                        string instituicao = System.Console.ReadLine();
                        System.Console.WriteLine("digite o ano de formação");
                        int anoFormacao = Int32.Parse(System.Console.ReadLine());

                        AtividadeComplementar a = new AtividadeComplementar(AtividadeComplementarID, data, instituicao, aluno, tipoAtividade,anoFormacao);
                        listaAtividadeComplementar.Add(a);

                        break;  

                    //alteracao de alunos
                    case 4:

                        System.Console.WriteLine("digite o id do aluno a alterar:");
                        int idAlunoAlterar = Int32.Parse(System.Console.ReadLine());
                        var alunoAlterar = GetPessoa(idAlunoAlterar);
                        if (alunoAlterar == null) continue;

                                                
                        System.Console.WriteLine("digite o novo nome:");
                        string novoNome = System.Console.ReadLine();
                        System.Console.WriteLine("digite o novo ano:");
                        DateTime novaData = DateTime.Parse(System.Console.ReadLine());
                        alunoAlterar.DataNascimento = novaData;
                        alunoAlterar.Nome = novoNome;

                        break;

                    //alteracao de atividades
                    case 5:
                        System.Console.WriteLine("digite o id da atividade a alterar");
                        int idAtividadeAlterar = Int32.Parse(System.Console.ReadLine());
                        var atividadeAlterar = GetTipoAtividade(idAtividadeAlterar);
                        if (atividadeAlterar == null) continue;
                        System.Console.WriteLine("digite a nova descricao:");
                        string novaDescricao = System.Console.ReadLine();
                        atividadeAlterar.Descricao = novaDescricao;

                      
                        break;

                    //alteração de atividade complementar
                    case 6:
                        System.Console.WriteLine("digite o id da atividade complementar a alterar");
                        int idAtividadeComplementarAlterar = Int32.Parse(System.Console.ReadLine());
                        var atividadeComplementarAlterar = GetAtividadeComplementar(idAtividadeComplementarAlterar);
                        if (atividadeComplementarAlterar == null) continue;
                        System.Console.WriteLine("digite a nova Data");
                        DateTime novaAtividadeComplementar = DateTime.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("digite a nova instituição:");
                        string novaInstituicao = System.Console.ReadLine();
                        System.Console.WriteLine("digite o novo ano de formação:");
                        int novoAnoFormacao = Int32.Parse(System.Console.ReadLine());
                        atividadeComplementarAlterar.AnoFormacao = novoAnoFormacao; 
                        atividadeComplementarAlterar.Instituicao = novaInstituicao;
                        atividadeComplementarAlterar.Data = novaAtividadeComplementar;
                     
                        break;
                    //excluir alunos
                    case 7:
                        System.Console.WriteLine("digite o id do aluno a ser excluido:");
                        int idAlunoExcluir = Int32.Parse(System.Console.ReadLine());
                        var alunoExcluir = GetPessoa(idAlunoExcluir);
                        listaPessoa.Remove(alunoExcluir);                        
                        break;

                    //excluir atividades
                    case 8:
                        System.Console.WriteLine("digite o id da atividade a ser excluida");
                        int idAtividadeExcluir = Int32.Parse(System.Console.ReadLine());
                        var atividadeExcluir = GetTipoAtividade(idAtividadeExcluir);
                        listaAtividade.Remove(atividadeExcluir);
                      
                        break;
                    //excluir atividade complementar
                    case 9:
                        System.Console.WriteLine("digite o id da atividade complementar a ser excluida:");
                        int idAtividadeComplementarExcluir = Int32.Parse(System.Console.ReadLine());
                        var atividadeComplementarExcluir = GetAtividadeComplementar(idAtividadeComplementarExcluir);
                        listaAtividadeComplementar.Remove(atividadeComplementarExcluir);
                        break;

                    //ler atividades
                    case 10:
                        foreach(var t2 in listaAtividade)
                        {
                            System.Console.WriteLine("id: " + t2.TipoAtividadeID + "descricao: " + t2.Descricao);

                        }
                      

                        break;

                    //ler alunos
                    case 11:
                        foreach(var p2 in listaPessoa)
                        {
                            System.Console.WriteLine("id: " + p2.PessoaID + "nome: " + p2.Nome + "data de nascimento" + p2.DataNascimento);
                        }
                        
                        break;
                    //ler atividade complementar        
                    case 12:
                        foreach(var ac in listaAtividadeComplementar)
                        {
                            System.Console.WriteLine("id: " + ac.AtividadeComplementarId + "data: " + ac.Data + "aluno: " + ac.Aluno + "tipo de atividade: " 
                                + ac.Tipo + "instituição: " + ac.Instituicao + "ano de formação: " + ac.AnoFormacao);
                        }
                        break;

                    //sair
                    case 13:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        private static Pessoa GetPessoa(int pessoaId)
        {
            var pessoa = listaPessoa.Where(x => x.PessoaID == pessoaId).First();
            return pessoa;
        }

        private static TipoAtividade GetTipoAtividade(int tipoAtividadeId)
        {
            var atividade = listaAtividade.Where(x => x.TipoAtividadeID == tipoAtividadeId).First();
            return atividade;
          
        }

        private static AtividadeComplementar GetAtividadeComplementar(int AtividadeComplementarId)
        {
            var complemento = listaAtividadeComplementar.Where(x => x.AtividadeComplementarId == AtividadeComplementarId).First();
            return complemento;
        }
    }
}
