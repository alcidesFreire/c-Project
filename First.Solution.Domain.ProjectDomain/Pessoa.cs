using System;

namespace First.Solution.Domain.ProjectDomain
{
    public class Pessoa
    {
        public int PessoaID { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get;  set; }

         public Pessoa(int pessoaID, String Nome, DateTime DataNascimento)
        {
            this.PessoaID = pessoaID;
            this.Nome = Nome;
            this.DataNascimento = DataNascimento;
        }
        public static Pessoa Parse(string v) 
        {
            throw new NotImplementedException();
        }
    }
    
}
