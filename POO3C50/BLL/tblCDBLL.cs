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
    class tblCDBLL
    {
        private DALMysql DaoBanco = new DALMysql();
        
        public DataTable ListarTodosOsCd()
        {
            string sql = string.Format($@"select * from tbl_cd");
            return DaoBanco.executarConsulta(sql);
        }
        public void AlterarCD(TblCDDTO dtoCd)
        {
            string sql = string.Format($@"UPDATE tbl_cd set nomeCD = '{dtoCd.NomeCD}',
                                                               precoVenda = '{dtoCd.PrecoVenda}',
                                                               dtLancamento = '{dtoCd.DtLancamento}'                                                               
                                                               where idCD = '{dtoCd.IdCD}';");
            DaoBanco.executarComando(sql);

        }

        public void InserirCD(TblCDDTO ObjCD)
        {
            string sql = string.Format($@"INSERT INTO tbl_cliente VALUES (NULL,'{ObjCD.NomeCD}',
                                                                          '{ObjCD.PrecoVenda}',
                                                                          '{ObjCD.DtLancamento}');");
            DaoBanco.executarComando(sql);


        }

        public void ExcluirCD(TblCDDTO objCD)
        {
            string sql = string.Format($@"DELETE FROM tbl_cd where idCD = {objCD.IdCD};");
            DaoBanco.executarComando(sql);
        }

        
    }
}
