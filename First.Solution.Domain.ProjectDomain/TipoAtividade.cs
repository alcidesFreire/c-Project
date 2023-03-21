using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First.Solution.Domain.ProjectDomain
{
    public class TipoAtividade
    {
        public int TipoAtividadeID { get; set; }
        public string Descricao { get; set; }

        public TipoAtividade(int TipoAtividadeID, string Descricao) 
        {
            this.TipoAtividadeID = TipoAtividadeID;
            this.Descricao = Descricao;
        }
        public static TipoAtividade Parse(string t) 
        {
            throw new NotImplementedException();
        }
    }
}
