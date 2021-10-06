using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace projetoAcademia
{
    class Conexao
    {
        public SQLiteConnection Con { get; set; }
        public SQLiteConnection open()
        {
            string caminho = Environment.CurrentDirectory + "\\academia.sqlite";
            string sql = string.Format("Data Source = {0}, version=3", caminho);
            Con = new SQLiteConnection(sql);
            Con.Open();
            return Con;
        }
    }
}
