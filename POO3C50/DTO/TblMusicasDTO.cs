using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3C50.DTO
{
    class TblMusicasDTO
    {
        private int idMusica, idGravadora, idCD;
        private String nome, nomeAutor;

        public int IdMusica { get => idMusica; set => idMusica = value; }

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
                    throw new Exception("O campo "+ "Nome" +" é obrigatório.");
                }
            }
            get { return this.nome; }
        }

        public string NomeAutor
        {
            set
            {
                if (value != string.Empty)
                {
                    this.nomeAutor = value;
                }
                else
                {
                    throw new Exception("O campo do " + "Nome do Autor" + " é obrigatório.");
                }
            }
            get { return this.nomeAutor; }
        }

        public int IdGravadora { get => idGravadora; set => idGravadora = value; }
        public int IdCD { get => idCD; set => idCD = value; }
    }
}

