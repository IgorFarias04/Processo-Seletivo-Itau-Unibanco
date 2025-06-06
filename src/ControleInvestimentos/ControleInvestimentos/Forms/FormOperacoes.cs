using System;
using ControleInvestimentos.Data;
using ControleInvestimentos.Modelos;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace ControleInvestimentos
{
    public partial class FormOperacoes : Form
    {
        public FormOperacoes()
        {
            InitializeComponent();
            this.Load += FormOperacoes_Load;
        }
        private void FormOperacoes_Load(object sender, EventArgs e)
        {
            //using (var db = new AppDbContext())
            //{
            //    var usuarios = db.Usuarios.ToList();

            //    cmbUsuarios.DataSource = usuarios;
            //    cmbUsuarios.DisplayMember = "Nome";
            //    cmbUsuarios.ValueMember = "UsuarioId";
            //}

            //// Preencher tipo de operação
            //cmbTipoOperacao.Items.Clear();
            //cmbTipoOperacao.Items.Add("COMPRA");
            //cmbTipoOperacao.Items.Add("VENDA");
        }
    }
}
