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
    class tblGravadoraBLL
    {
        private DALMysql DaoBanco = new DALMysql();

        public DataTable ListarTodasAsGravadoras()
        {
            string sql = string.Format($@"select * from tbl_gravadora");
            return DaoBanco.executarConsulta(sql);
        }
        public void AlterarGravadora(TblGravadoraDTO dtoGravadora)
        {
            string sql = string.Format($@"UPDATE tbl_gravadora set nome = '{dtoGravadora.Nome}'                                                                                                                             
                                                                   where idGravadora = '{dtoGravadora.IdGravadora}';");
            DaoBanco.executarComando(sql);

        }
        public void InserirGravadora(TblGravadoraDTO objGravadora)
        {
            string sql = string.Format($@"INSERT INTO tbl_gravadora VALUES (NULL,'{objGravadora.Nome}');");
            DaoBanco.executarComando(sql);


        }
        public void ExcluirGravadora(TblGravadoraDTO objGravadora)
        {
            string sql = string.Format($@"DELETE FROM tbl_gravadora where idGravadora = {objGravadora.IdGravadora};");
            DaoBanco.executarComando(sql);
        }        
    }
}
