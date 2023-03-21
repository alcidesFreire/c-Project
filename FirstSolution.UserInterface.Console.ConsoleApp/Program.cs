using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using


namespace FirstSolution.UserInterface.Console.ConsoleApp
{
    class Program
    {
        static Pessoa[] listaPessoa = new Pessoa[10];
        static void Main(string[] args)
        {
            while (true)
            {
                System.Console.WriteLine("ola, digite o que quer fazer: 1-cad 2-alt 3-excl 4-const 5-sair");
                int op = Int32.Parse(System.Console.ReadLine());

                switch (op)
                {
                    case 1:
                        System.Console.WriteLine("digite o id do aluno:");
                        int pessoaID = Int32.Parse(System.Console.ReadLine());
                        System.Console.WriteLine("dugute o nome:");
                        string Nome = System.Console.ReadLine();
                        System.Console.WriteLine("digite a data de nascimento");
                        DateTime DataNascimento = DateTime.Parse(System.Console.ReadLine());

                        Pessoa p = new Pessoa(pessoaID, Nome, DataNascimento);

                        for(int i = 0; i < listaPessoa.Length; i++)
                        {
                            if (listaPessoa[i] = null)
                            {
                                listaPessoa[i] = p;
                                break;
                            }
                        }
                        break;
                        case 2:
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
