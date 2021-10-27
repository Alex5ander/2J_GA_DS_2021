using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;

namespace projetoAcademia
{
    class Conexao
    {
        public SQLiteConnection Con { get; set; }
       
        public SQLiteConnection Open()
        {
            string caminho = Environment.CurrentDirectory + "\\academia.sqlite";
            string sql = string.Format("Data Source = {0}", caminho);
            Con = new SQLiteConnection(sql);
            Con.Open();
            return Con;
        }
        public void CriarBanco(string caminho)
        {
            if (!File.Exists(caminho))
            {
                SQLiteConnection.CreateFile(caminho);
                criarTabela();
            }
        }
        public void criarTabela()
        {
            using (var banco = new SQLiteCommand(Open()))
            {
                banco.CommandText = "CREATE TABLE IF NOT EXISTS ALUNO (" +
                "CODIGO INT PRIMARY KEY,"+
                "NOME VARCHAR(45),"+
                "IDADE INT, PESO DOUBLE,"+
                "ALTURA DOUBLE)";
                banco.ExecuteNonQuery();
            }
        }
    }
}
