using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAcademia
{
    class Aluno
    {
        public long Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public Aluno(long Codigo, string Nome, int Idade, double Peso, double Altura)
        {
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Idade = Idade;
            this.Peso = Peso;
            this.Altura = Altura;
        }
        public Aluno() : this(0, "", 15, 45, 1.50) { }
        public double IMC
        {
            get {
                return Math.Round(Peso / (Altura * Altura), 2);
            }
        }
        public string Classificacao
        {
            get {
                double indice = IMC;
                if(indice < 18.5)
                {
                    return "BAIXO PESO";
                }
                else if(indice >= 18.5 && indice < 24.9)
                {
                    return "PESO NORMAL";
                }
                else if (indice >= 24.9 && indice < 29.9)
                {
                    return "SOBREPESO";
                }
                else if (indice >= 29.9 && indice < 34.9)
                {
                    return "OBESIDADE I";
                }
                else if (indice >= 34.9 && indice < 39.9)
                {
                    return "OBESIDEDAE II";
                }
                else if (indice >= 39.9 && indice < 49.9)
                {
                    return "OBESIDADE III";
                }
                else
                {
                    return "OBESIDADE IV";
                }
            }
        }
    }
}
