using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
            BoaForma.Alunos = tabela.pegarlista();
            bs.DataSource = BoaForma.Alunos;
            dgvAlunos.DataSource = bs;
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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            FormPesquisa formpesquisa = new FormPesquisa();
            formpesquisa.ShowDialog();
            if (formpesquisa.Registro != null)
            {
                Aluno reg = BoaForma.Alunos.First(i => i.Codigo == formpesquisa.Registro.Codigo);
                bs.Position = bs.IndexOf(reg);
                Editar_Click(sender, e);
            }
        }

        private void bs_PositionChanged(object sender, EventArgs e)
        {
            Aluno Registro = (Aluno)bs.Current;
            string caminho = Environment.CurrentDirectory + "\\fotos\\" + Registro.Codigo.ToString() + ".jpeg";
            if (File.Exists(caminho))
            {
                pbFoto.Image = Image.FromFile(caminho);
            }
        }
    }
}
