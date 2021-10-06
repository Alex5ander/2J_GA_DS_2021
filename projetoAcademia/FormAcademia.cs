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
            CriarBanco();
            BoaForma = new Academia();
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

        private void CriarBanco()
        {
            Conexao servidor = new Conexao();
            string caminho = Environment.CurrentDirectory + "\\academia.sqlite";
            servidor.CriarBanco(caminho);
        }
    }
}
