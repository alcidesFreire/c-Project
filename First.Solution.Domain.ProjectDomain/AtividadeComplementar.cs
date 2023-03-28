using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Solution.Domain.ProjectDomain
{
    public class AtividadeComplementar
    {
        public int AtividadeComplementarId { get; set; }
        public DateTime Data { get; set; }
        public Pessoa Aluno { get; set; }
        public TipoAtividade Tipo { get; set; }
        public string Instituicao { get; set; }
        public int AnoFormacao { get; set; }

        public AtividadeComplementar(int AtividadeComplementarId, DateTime Data, string Instituicao, Pessoa aluno, TipoAtividade tipo, int AnoFormacao)
        {
            this.AtividadeComplementarId = AtividadeComplementarId;
            this.Data = Data;
            this.Aluno = aluno;
            this.Tipo = tipo;
            this.Instituicao = Instituicao; 
            this.AnoFormacao = AnoFormacao;
        }
        public static TipoAtividade Parse(string t)
        {
            throw new NotImplementedException();
        }
    }
}
