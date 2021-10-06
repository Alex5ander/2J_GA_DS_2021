using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace projetoAcademia
{
    class AlunoDB
    {
        public void inserir(Aluno reg)
        {
           Conexao servidor = new Conexao();
           using (var banco = new SQLiteCommand(servidor.Open()))
           {
               string SQL = string.Format("INTER INTO ALUNO VALUES ({0}, '{1}', {2}, {3}, {4})", 
               reg.Codigo, reg.Nome, reg.Idade, reg.Peso, reg.Altura.ToString().Replace(',', '.'));
               banco.CommandText = SQL;
               banco.ExecuteNonQuery();
           }
        }
        public void editar(Aluno reg)
        {
            Conexao servidor = new Conexao();
            using (var banco = new SQLiteCommand(servidor.Open()))
            {
                string SQL = string.Format("UPDATE ALUNO SET NOME = '{1}', IDADE = {2}, PESO = {3}, ALTURA = {4} WHERE CODIGO = {0}",
                reg.Codigo, reg.Nome, reg.Idade, reg.Peso, reg.Altura.ToString().Replace(',', '.'));
                banco.CommandText = SQL;
                banco.ExecuteNonQuery();
            }
        }
        public void excluir(Aluno reg)
        {
            Conexao servidor = new Conexao();
            using (var banco = new SQLiteCommand(servidor.Open()))
            {
                string SQL = string.Format("DELETE FROM ALUNO WHERE CODIGO = {0}", reg.Codigo);
                banco.CommandText = SQL;
                banco.ExecuteNonQuery();
            }
        }
        public void consultar(Aluno reg)
        {
            Conexao servidor = new Conexao();
            using (var banco = new SQLiteCommand(servidor.Open()))
            {
                string SQL = string.Format("SELECT * FROM ALUNO");
                banco.CommandText = SQL;
                banco.ExecuteNonQuery();
            }
        } 
    }
}
