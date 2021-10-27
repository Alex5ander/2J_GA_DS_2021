namespace projetoAcademia
{
    partial class FormPesquisa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisa));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.rbInicio = new System.Windows.Forms.RadioButton();
            this.rbMeio = new System.Windows.Forms.RadioButton();
            this.rbFim = new System.Windows.Forms.RadioButton();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(12, 12);
            this.txtNome.MaxLength = 45;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(460, 20);
            this.txtNome.TabIndex = 0;
            this.txtNome.Tag = "";
            // 
            // rbInicio
            // 
            this.rbInicio.AutoSize = true;
            this.rbInicio.Location = new System.Drawing.Point(12, 42);
            this.rbInicio.Name = "rbInicio";
            this.rbInicio.Size = new System.Drawing.Size(50, 17);
            this.rbInicio.TabIndex = 1;
            this.rbInicio.TabStop = true;
            this.rbInicio.Text = "Inicio";
            this.rbInicio.UseVisualStyleBackColor = true;
            // 
            // rbMeio
            // 
            this.rbMeio.AutoSize = true;
            this.rbMeio.Location = new System.Drawing.Point(12, 65);
            this.rbMeio.Name = "rbMeio";
            this.rbMeio.Size = new System.Drawing.Size(48, 17);
            this.rbMeio.TabIndex = 1;
            this.rbMeio.TabStop = true;
            this.rbMeio.Text = "Meio";
            this.rbMeio.UseVisualStyleBackColor = true;
            // 
            // rbFim
            // 
            this.rbFim.AutoSize = true;
            this.rbFim.Location = new System.Drawing.Point(12, 88);
            this.rbFim.Name = "rbFim";
            this.rbFim.Size = new System.Drawing.Size(41, 17);
            this.rbFim.TabIndex = 1;
            this.rbFim.TabStop = true;
            this.rbFim.Text = "Fim";
            this.rbFim.UseVisualStyleBackColor = true;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(12, 111);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(460, 103);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvLista
            // 
            this.dgvLista.AllowUserToAddRows = false;
            this.dgvLista.AllowUserToDeleteRows = false;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLista.Location = new System.Drawing.Point(12, 220);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.ReadOnly = true;
            this.dgvLista.Size = new System.Drawing.Size(460, 229);
            this.dgvLista.TabIndex = 3;
            // 
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.rbFim);
            this.Controls.Add(this.rbMeio);
            this.Controls.Add(this.rbInicio);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormPesquisa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de pesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.RadioButton rbInicio;
        private System.Windows.Forms.RadioButton rbMeio;
        private System.Windows.Forms.RadioButton rbFim;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvLista;

    }
}