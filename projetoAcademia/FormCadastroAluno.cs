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
    public partial class FormCadastroAluno : Form
    {
        internal Aluno Registro { get; set; }
        public FormCadastroAluno()
        {
            if (Registro != null)
            {
                txtNumeroMatricula.Text = Registro.Codigo.ToString();
                txtNomeAluno.Text = Registro.Nome;
                txtPesoAluno.Text = Registro.Peso.ToString();
                txtIdadeAluno.Text = Registro.Idade.ToString();
                txtAlturaAluno.Text = Registro.Altura.ToString();

                string caminho = Environment.CurrentDirectory + "\\fotos\\" + Registro.Codigo.ToString() + ".jpeg";
                opF.ShowDialog();
                if (File.Exists(caminho))
                {
                    pbFoto.Image = Image.FromFile(caminho);
                }
            }
            InitializeComponent();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (Validar() == false) return;
            if(Registro == null) novo();
            else editar();
            this.Dispose();
        }

        private void novo()
        {
            AlunoDB tabela = new AlunoDB();
            Registro = new Aluno()
            {
                Codigo = Int64.Parse(txtNumeroMatricula.Text),
                Nome = txtNomeAluno.Text.ToUpper(),
                Idade = Int16.Parse(txtIdadeAluno.Text),
                Peso = Double.Parse(txtPesoAluno.Text),
                Altura = Double.Parse(txtAlturaAluno.Text),
            };
            tabela.inserir(Registro);
            MessageBox.Show("Mátricula efetuada com sucesso!");
        }

        private void editar()
        {
            AlunoDB tabela = new AlunoDB();
            Registro = new Aluno()
            {
                Codigo = Registro.Codigo,
                Nome = txtNomeAluno.Text.ToUpper(),
                Idade = Int16.Parse(txtIdadeAluno.Text),
                Peso = Convert.ToDouble(txtPesoAluno.Text),
                Altura = Convert.ToDouble(txtAlturaAluno.Text),
            };
            tabela.editar(Registro);
            MessageBox.Show("Mátricula alterada");
        }

        private bool Validar()
        {
            if(txtNumeroMatricula.Text.Trim().Equals("")) {
                ep.SetError(txtNumeroMatricula, "Matricula inválida");
                return false; 
            }
            ep.SetError(txtNumeroMatricula, "");
            return true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Registro = null;
            this.Dispose();
        }

        private void FormCadastroAluno_Load(object sender, EventArgs e)
        {
            if (Registro != null)
            {
                txtNumeroMatricula.Text = Registro.Codigo.ToString();
                txtNomeAluno.Text = Registro.Nome.ToUpper();
                txtIdadeAluno.Text = Registro.Idade.ToString();
                txtPesoAluno.Text = Registro.Peso.ToString();
                txtAlturaAluno.Text = Registro.Altura.ToString();
                txtNumeroMatricula.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Registro != null)
            {
                string caminho = Environment.CurrentDirectory + "\\fotos\\" + Registro.Codigo.ToString() + ".jpeg";
                opF.ShowDialog();
                if (File.Exists(caminho))
                {
                    pbFoto.Image = null;
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    File.Copy(opF.FileName, caminho);
                    pbFoto.Image = Image.FromFile(caminho);
                }
            }
        }
    }
}
