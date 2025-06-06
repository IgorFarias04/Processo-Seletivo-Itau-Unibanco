namespace ControleInvestimentos
{
    partial class FormOperacoes
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
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbAtivos = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbTipoOperacao = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtPrecoUnitario = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvOperacoes = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAtivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecoUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorretagem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalInvestido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(207, 24);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(199, 24);
            this.cmbUsuarios.TabIndex = 0;
            this.cmbUsuarios.Text = "Selecione...";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ativo:";
            // 
            // cmbAtivos
            // 
            this.cmbAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAtivos.FormattingEnabled = true;
            this.cmbAtivos.Items.AddRange(new object[] {
            "PETR4",
            "VALE3",
            "MXRF11"});
            this.cmbAtivos.Location = new System.Drawing.Point(207, 79);
            this.cmbAtivos.Name = "cmbAtivos";
            this.cmbAtivos.Size = new System.Drawing.Size(199, 24);
            this.cmbAtivos.TabIndex = 2;
            this.cmbAtivos.Text = "Selecione...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(441, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo de Operação:";
            // 
            // cmbTipoOperacao
            // 
            this.cmbTipoOperacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoOperacao.FormattingEnabled = true;
            this.cmbTipoOperacao.Items.AddRange(new object[] {
            "COMPRA",
            "VENDA"});
            this.cmbTipoOperacao.Location = new System.Drawing.Point(581, 25);
            this.cmbTipoOperacao.Name = "cmbTipoOperacao";
            this.cmbTipoOperacao.Size = new System.Drawing.Size(199, 24);
            this.cmbTipoOperacao.TabIndex = 4;
            this.cmbTipoOperacao.Text = "Selecione...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(488, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(469, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Preço Unitário:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(581, 83);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(199, 20);
            this.txtQuantidade.TabIndex = 10;
            this.txtQuantidade.UseWaitCursor = true;
            // 
            // txtPrecoUnitario
            // 
            this.txtPrecoUnitario.Location = new System.Drawing.Point(581, 138);
            this.txtPrecoUnitario.Name = "txtPrecoUnitario";
            this.txtPrecoUnitario.Size = new System.Drawing.Size(199, 20);
            this.txtPrecoUnitario.TabIndex = 11;
            this.txtPrecoUnitario.UseWaitCursor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(207, 124);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(199, 48);
            this.btnRegistrar.TabIndex = 12;
            this.btnRegistrar.Text = "Registrar Operação";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dgvOperacoes
            // 
            this.dgvOperacoes.AllowUserToAddRows = false;
            this.dgvOperacoes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colUsuario,
            this.colAtivo,
            this.colTipo,
            this.colQuantidade,
            this.colPrecoUnitario,
            this.colCorretagem,
            this.colTotalInvestido,
            this.colPL});
            this.dgvOperacoes.Location = new System.Drawing.Point(34, 191);
            this.dgvOperacoes.Name = "dgvOperacoes";
            this.dgvOperacoes.ReadOnly = true;
            this.dgvOperacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperacoes.Size = new System.Drawing.Size(936, 268);
            this.dgvOperacoes.TabIndex = 13;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.HeaderText = "Nome";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            // 
            // colAtivo
            // 
            this.colAtivo.HeaderText = "Ativo";
            this.colAtivo.Name = "colAtivo";
            this.colAtivo.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.HeaderText = "TipoOperacao";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colQuantidade
            // 
            this.colQuantidade.HeaderText = "Quantidade";
            this.colQuantidade.Name = "colQuantidade";
            this.colQuantidade.ReadOnly = true;
            // 
            // colPrecoUnitario
            // 
            this.colPrecoUnitario.HeaderText = "PrecoUnitario";
            this.colPrecoUnitario.Name = "colPrecoUnitario";
            this.colPrecoUnitario.ReadOnly = true;
            // 
            // colCorretagem
            // 
            this.colCorretagem.HeaderText = "Corretagem";
            this.colCorretagem.Name = "colCorretagem";
            this.colCorretagem.ReadOnly = true;
            // 
            // colTotalInvestido
            // 
            this.colTotalInvestido.HeaderText = "TotalInvestido";
            this.colTotalInvestido.Name = "colTotalInvestido";
            this.colTotalInvestido.ReadOnly = true;
            // 
            // colPL
            // 
            this.colPL.HeaderText = "PL";
            this.colPL.Name = "colPL";
            this.colPL.ReadOnly = true;
            // 
            // FormOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 487);
            this.Controls.Add(this.dgvOperacoes);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtPrecoUnitario);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbTipoOperacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbAtivos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUsuarios);
            this.Name = "FormOperacoes";
            this.Text = "FormOperacoes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperacoes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbAtivos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbTipoOperacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.TextBox txtPrecoUnitario;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvOperacoes;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecoUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorretagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalInvestido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPL;
    }
}