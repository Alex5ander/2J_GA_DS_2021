using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoAcademia
{
    public partial class FormAcademia : Form
    {
        public FormAcademia()
        {
            InitializeComponent();
        }
        Academia BoaForma;

        private void FormAcademia_Load(object sender, EventArgs e)
        {
            BoaForma = new Academia();
            BoaForma.Alunos.Add(new Aluno(1, "JOÃO", 23, 68, 1.72));
            BoaForma.Alunos.Add(new Aluno(2, "MARIA", 25, 78, 1.62));
            BoaForma.Alunos.Add(new Aluno(3, "JOSÉ", 27, 72, 1.80));
            bs.DataSource = BoaForma.Alunos;
            dgvAlunos.DataSource = bs;
            dgvAlunos.Columns["Altura"].DefaultCellStyle.Format = "N2";
            dgvAlunos.GridColor = Color.FromArgb(168, 202, 232);

            for (int i = 0; i < dgvAlunos.Rows.Count; i++)
            {
                DataGridViewRow row = dgvAlunos.Rows[i];
                row.DefaultCellStyle.BackColor = i % 2 == 0 ? Color.FromArgb(189, 215, 238) : Color.FromArgb(221, 235, 247);
            }
            dgvAlunos.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(48, 84, 150);
            dgvAlunos.AutoResizeColumns();
        }
    }
}
