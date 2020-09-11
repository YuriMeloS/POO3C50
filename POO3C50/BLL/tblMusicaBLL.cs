using POO3C50.DAL;
using POO3C50.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3C50.BLL
{
    class tblMusicaBLL
    {
        private DALMysql DaoBanco = new DALMysql();     
        public DataTable ListarTodasAsMusicas()
        {
            string sql = string.Format($@"select * from tbl_musica");
            return DaoBanco.executarConsulta(sql);
        }
        public void AlterarMusica(TblMusicasDTO dtoMusica)
        {
            string sql = string.Format($@"UPDATE tbl_musica set nome = '{dtoMusica.Nome}',
                                                                nomeAutor = '{dtoMusica.NomeAutor}',
                                                                idGravadora = '{dtoMusica.IdGravadora}'                                                               
                                                                where idMusica = '{dtoMusica.IdMusica}';");
            DaoBanco.executarComando(sql);
        }
        public void InserirMusica(TblMusicasDTO ObjMusica)
        {
            string sql = string.Format($@"INSERT INTO tbl_musica VALUES (NULL,'{ObjMusica.Nome}','{ObjMusica.NomeAutor}','{ObjMusica.IdGravadora}','{ObjMusica.IdCD}');");
            DaoBanco.executarComando(sql);
        }
        public void ExcluirMusica(TblMusicasDTO objMusica)
        {
            string sql = string.Format($@"DELETE FROM tbl_musica where idMusica = {objMusica.IdMusica};");
            DaoBanco.executarComando(sql);
        }
        
    }
}
