using IntegracaoDevApp.Application.Services;
using IntegracaoDevApp.Data.Repositories;
using IntegracaoDevApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegracaoDevApp
{
    public partial class ProdutoWindow : Form
    {
        DataTable _dataTableProduto = new DataTable();
        ProdutoAppService _produtoAppService;
        public Usuario usuarioLogado;
        public ProdutoWindow()
        {
            InitializeComponent();

            _produtoAppService = new ProdutoAppService();

            btnAdicionar.Click += btnAdicionar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnSalvar.Click += btnSalvar_Click;
            btnExcluir.Click += btnExcluir_Click;

            txtCodigo.EnabledChanged += txtCodigo_EnabledChanged;
            txtDescricao.EnabledChanged += txtDescricao_EnabledChanged;
            txtValor.EnabledChanged += txtValor_EnabledChanged;
            chkAtivo.EnabledChanged += chkAtivo_EnabledChanged;
            dtpDtValidade.EnabledChanged += dtpDtValidade_EnabledChanged;

            dgvProdutos.DoubleClick += dgvProdutos_DoubleClick;

            carregarGridProdutos();
        }

        #region cliques

        void btnAdicionar_Click(object sender, EventArgs e)
        {
            alterarStatusCampos();
            txtCodigo.Focus();
        }
        void btnCancelar_Click(object sender, EventArgs e)
        {
            alterarStatusCampos();
        }
        void btnSalvar_Click(object sender, EventArgs e)
        {
            var produto = _produtoAppService.GetById(txtCodigo.Text);
            if (produto.Rows.Count > 0)
                atualizaProduto();
            else
                insereProduto();

            carregarGridProdutos();
        }
        void btnExcluir_Click(object sender, EventArgs e)
        {
            _produtoAppService.Delete(txtCodigo.Text);
            carregarGridProdutos();
            MessageBox.Show("Excluido com sucesso!");
        }
        void txtCodigo_EnabledChanged(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
        }
        void txtDescricao_EnabledChanged(object sender, EventArgs e)
        {
            txtDescricao.Text = "";
        }
        void txtValor_EnabledChanged(object sender, EventArgs e)
        {
            txtValor.Text = "";
        }
        void chkAtivo_EnabledChanged(object sender, EventArgs e)
        {
            chkAtivo.Checked = false;
        }
        void dtpDtValidade_EnabledChanged(object sender, EventArgs e)
        {
            dtpDtValidade.Value = DateTime.Now;
        }
        void dgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 1)
            {
                alterarStatusCampos();
                DataGridViewRow selectedRow = dgvProdutos.SelectedRows[0];
                txtCodigo.Text = selectedRow.Cells["CdProduto"].Value.ToString();
                txtDescricao.Text = selectedRow.Cells["Descricao"].Value.ToString();
                txtValor.Text = selectedRow.Cells["Preco"].Value.ToString();
                chkAtivo.Checked = getIsActiveBool(selectedRow.Cells["IsActive"].Value.ToString());
                dtpDtValidade.Value = Convert.ToDateTime(selectedRow.Cells["DtValidade"].Value);
                tcProduto.SelectedIndex = 0;
            }
        }

        #endregion
        void alterarStatusCampos()
        {
            //limparCampos();
            btnAdicionar.Enabled = !btnAdicionar.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
            btnExcluir.Enabled = !btnExcluir.Enabled;
            txtCodigo.Enabled = !txtCodigo.Enabled;
            txtDescricao.Enabled = !txtDescricao.Enabled;
            btnCancelar.Enabled = !btnCancelar.Enabled;
            chkAtivo.Enabled = !chkAtivo.Enabled;
            txtValor.Enabled = !txtValor.Enabled;
            dtpDtValidade.Enabled = !dtpDtValidade.Enabled;
        }
        bool getIsActiveBool(string isActiveChar)
        {
            if (isActiveChar == "N")
                return false;
            return true;
        }
        void atualizaProduto()
        {
            if (Decimal.TryParse(txtValor.Text, out decimal parcedValue))
            {
                var r = _produtoAppService.Update(new Produto(txtCodigo.Text, txtDescricao.Text, chkAtivo.Checked, dtpDtValidade.Value, parcedValue));
                if (!r.Success)
                {
                    var message = new StringBuilder();
                    foreach (var item in r.Messages)
                        message.AppendLine(item.ToString());

                    MessageBox.Show(message.ToString());
                    return;
                }

                _dataTableProduto = _produtoAppService.GetAll();
                dgvProdutos.Refresh();
            }
            else
            {
                MessageBox.Show("Valor do produto inválido");
            }
        }
        void insereProduto()
        {
            if (Decimal.TryParse(txtValor.Text, out decimal parcedValue))
            {
                var r = _produtoAppService.Create(new Produto(txtCodigo.Text, txtDescricao.Text, true, dtpDtValidade.Value, parcedValue));
                if (!r.Success)
                {
                    var message = new StringBuilder();
                    foreach (var item in r.Messages)
                        message.AppendLine(item.ToString());

                    MessageBox.Show(message.ToString());
                    return;
                }

                _dataTableProduto = _produtoAppService.GetAll();
                dgvProdutos.Refresh();
            }
            else
            {
                MessageBox.Show("Valor do produto inválido");
            }
        }
        void carregarGridProdutos()
        {
            _dataTableProduto = _produtoAppService.GetAll();
            dgvProdutos.DataSource = _dataTableProduto;
            dgvProdutos.Refresh();
        }
    }
}
