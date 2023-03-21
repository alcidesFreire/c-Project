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
        static Pessoa[] listaPessoa = new Pessoa[10];
        public static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("ola, digite a ação 1-cadastro de aluno 2-cadastro de atividade  3-alt 4-exc 5-const 6-sair");
                int op = Int32.Parse(System.Console.ReadLine());

                switch (op)
                {
                    case 1:
                        System.Console.WriteLine("digite o id do aluno");
                        int pessoaID = Int32.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("digite o nome");
                        string Nome = System.Console.ReadLine();
                        System.Console.WriteLine("digite a data de nascimento:");
                        DateTime DataNascimento = DateTime.Parse(System.Console.ReadLine());
                        Pessoa p = new Pessoa(pessoaID, Nome, DataNascimento);

                        for (int i = 0; i < listaPessoa.Length; i++)
                        {
                            if (listaPessoa[i] == null)
                            {
                                listaPessoa[i] = p;
                                break;
                            }
                        }
                        break;

                        case 2:
                         TipoAtividade[] atividade = new TipoAtividade[10];
                        System.Console.WriteLine("digite o id da atividade:");
                        int TipoAtividadeID = Int32.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("digite a descrição:");
                        string Descricao = System.Console.ReadLine();
                        TipoAtividade t = new TipoAtividade(TipoAtividadeID, Descricao);
                        for(int i = 0; i< atividade.Length; i++) 
                        {
                            if (atividade[i] == null) 
                            {
                                atividade[i] = t;
                                break;
                            }
                        } break;


                    case 3:

                        System.Console.WriteLine("digite o id do aluno a alterar:");
                        int idAlterar = Int32.Parse(System.Console.ReadLine());

                        for (int i = 0;i < listaPessoa.Length; i++) 
                        {
                            if (listaPessoa[i].PessoaID == idAlterar) 
                            {
                                System.Console.WriteLine("digite o novo nome:");
                                string novoNome = System.Console.ReadLine();
                                System.Console.WriteLine("digite o novo ano:");
                                DateTime novaData = DateTime.Parse(System.Console.ReadLine());
                                listaPessoa[i].DataNascimento = novaData;
                                listaPessoa[i].Nome = novoNome;
                                break;
                            }
                        }
                        break;

                        case 4:
                        System.Console.WriteLine("digite o id do aluno a ser excluido:");
                        int idExcluir = Int32.Parse(System.Console.ReadLine());

                        for(int i = 0; i < listaPessoa.Length;i++) 
                        {
                            if (listaPessoa[i].PessoaID == idExcluir) 
                            {
                                listaPessoa[i] = null;

                            }
                           
                        }    break;

                        case 5:
                        for(int i = 0; i< listaPessoa.Length ; i++) 
                        {
                            Pessoa p2 = listaPessoa[i];
                            if (p2 != null)
                            {
                                System.Console.WriteLine("id: " + p2.PessoaID + "nome: "+ p2.Nome + "data de nascimento" + p2.DataNascimento);
                            }
                        } break;
                        case 6:
                        Environment.Exit(0);
                        break;
                }  
            }
        }
        
    }
}
