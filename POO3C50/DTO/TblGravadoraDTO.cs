using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3C50.DTO
{
    class TblGravadoraDTO
    {
        private int idGravadora;
        private String nome;

        public int IdGravadora { get => idGravadora; set => idGravadora = value; }

        public string Nome
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O campo "+"Nome" +"é obrigatório.");
                }
            }
            get { return this.nome; }
        }
    }
}

