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
            AlunoDB tabela = new AlunoDB();
            BoaForma = new Academia();
            BoaForma.Alunos = tabela.pesquisar();
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

        private void btnAdicionarAluno_Click(object sender, EventArgs e)
        {
            FormCadastroAluno ficha = new FormCadastroAluno();
            ficha.Registro = null;
            ficha.ShowDialog();

            if (ficha.Registro != null)
            {
                BoaForma.Alunos.Add(ficha.Registro);
                bs.ResetBindings(false);
                bs.MoveLast();
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            FormCadastroAluno ficha = new FormCadastroAluno();
            ficha.Registro = (Aluno) bs.Current;
            ficha.ShowDialog();
            if(ficha.Registro != null) {
                BoaForma.Editar(ficha.Registro);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Aluno Registro = (Aluno) bs.Current;
            DialogResult op;

            op = MessageBox.Show("Deseja excluir? "+ Registro.Nome, "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if(op == DialogResult.Yes) {
                AlunoDB tabela = new AlunoDB();
                tabela.excluir(Registro);
                bs.RemoveCurrent();
            }
        }
    }
}
