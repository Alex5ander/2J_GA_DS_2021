using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAcademia
{
    class Academia
    {
        public BindingList<Aluno> Alunos { get; set; }
        public Academia()
        {
            Alunos = new BindingList<Aluno>();
        }
        public int totalAlunos()
        {
            return Alunos.Count();
        }
    }
}
