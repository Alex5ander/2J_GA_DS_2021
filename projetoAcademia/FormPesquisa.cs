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
    public partial class FormPesquisa : Form
    {
        public FormPesquisa()
        {
            InitializeComponent();
        }

        internal Aluno Registro { get; set; }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            AlunoDB tabela = new AlunoDB();

            string tipo = "";

            if (rbInicio.Checked)
            {
                tipo = "I";
            }
            else if (rbMeio.Checked)
            {
                tipo = "M";
            }
            else if(rbFim.Checked)
            {
                tipo = "F";
            }
            dgvLista.DataSource = tabela.procurar(txtNome.Text, tipo);
            dgvLista.AutoResizeColumns();
        }

        private void btnAbrirRegistro_Click(object sender, EventArgs e)
        {
            if (Registro != null)
            {
                txtNome.Text = Registro.Nome;
            }
        }
    }
}
