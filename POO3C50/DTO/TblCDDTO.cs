using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3C50.DTO
{
    class TblCDDTO
    {
        private int idCD;
        private String nomeCD, precoVenda, dtLancamento;

        public int IdCD { get => idCD; set => idCD = value; }

        public string NomeCD
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeCD = value;
                }
                else
                {
                    throw new Exception("O campo "+"Nome"+" é obrigatório.");
                }
            }
            get { return this.nomeCD; }
        }

        public string PrecoVenda
        {
            set
            {
                if (value != string.Empty)
                {
                    this.precoVenda = value;
                }
                else
                {
                    throw new Exception("O campo Preço é obrigatório.");
                }
            }
            get { return this.precoVenda; }
        }

        public string DtLancamento { get => dtLancamento; set => dtLancamento = value; }
    }
}

