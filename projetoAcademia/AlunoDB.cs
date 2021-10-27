using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.ComponentModel;

namespace projetoAcademia
{
    class AlunoDB
    {
        public void inserir(Aluno reg)
        {
           Conexao servidor = new Conexao();
           using (var banco = new SQLiteCommand(servidor.Open()))
           {
               string SQL = string.Format("INSERT INTO ALUNO VALUES ({0}, '{1}', {2}, {3}, {4})", 
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
                reg.Codigo, reg.Nome, reg.Idade, reg.Peso, reg.Altura);
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
        public BindingList<Aluno> pegarlista()
        {
            Conexao servidor = new Conexao();
            using (var banco = new SQLiteCommand(servidor.Open()))
            {
                string SQL = string.Format("SELECT * FROM ALUNO");
                banco.CommandText = SQL;
                SQLiteDataReader dr = banco.ExecuteReader();
                BindingList<Aluno> lista = new System.ComponentModel.BindingList<Aluno>();
                while (dr.Read())
                {
                    Aluno reg = new Aluno()
                    {
                        Codigo = dr.GetInt64(0),
                        Nome = dr.GetString(1),
                        Idade = dr.GetInt16(2),
                        Peso = dr.GetDouble(3),
                        Altura = dr.GetDouble(4)
                    };
                    lista.Add(reg);
                }

                dr.Close();
                return lista;
            }
        }

        public BindingList<Aluno> procurar(string texto, string tipo)
        {
            Conexao servidor = new Conexao();
            using (var banco = new SQLiteCommand(servidor.Open()))
            {

                string SQL = "";

                
                if (tipo == "I")
                {
                    SQL = string.Format("SELECT * FROM ALUNO WHERE NOME LIKE '{0}%'", texto);
                }
                else if (tipo == "M")
                {
                    SQL = string.Format("SELECT * FROM ALUNO WHERE NOME LIKE '%{0}%' ", texto);
                }
                else if(tipo == "F")
                {
                    SQL = string.Format("SELECT * FROM ALUNO WHERE NOME LIKE '%{0}' ", texto);
                }

                banco.CommandText = SQL;

                SQLiteDataReader dr = banco.ExecuteReader();
                BindingList<Aluno> lista = new System.ComponentModel.BindingList<Aluno>();
                while (dr.Read())
                {
                    Aluno reg = new Aluno()
                    {
                        Codigo = dr.GetInt64(0),
                        Nome = dr.GetString(1),
                        Idade = dr.GetInt16(2),
                        Peso = dr.GetDouble(3),
                        Altura = dr.GetDouble(4)
                    };
                    lista.Add(reg);
                }

                dr.Close();
                return lista;
            }
        }
    }
}
