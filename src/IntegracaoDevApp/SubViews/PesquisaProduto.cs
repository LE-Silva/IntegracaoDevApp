using IntegracaoDevApp.Application.Services;
using IntegracaoDevApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegracaoDevApp.SubViews
{
    public partial class PesquisaProduto : Form
    {
        DataTable _dataTableProdutos = new DataTable();
        ProdutoAppService produtoAppService = new ProdutoAppService();
        public Produto _produtoSelecionado;
        public PesquisaProduto()
        {
            InitializeComponent();

            dgvProdutos.DoubleClick += DgvProdutos_DoubleClick;

            carregarGridProdutos();
        }

        private void DgvProdutos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProdutos.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvProdutos.SelectedRows[0];
                _produtoSelecionado = new Produto(
                    Convert.ToString(selectedRow.Cells["CdProduto"].Value),
                    Convert.ToString(selectedRow.Cells["Descricao"].Value),
                    getIsActiveBool(Convert.ToString(selectedRow.Cells["IsActive"].Value)),
                    Convert.ToDateTime(selectedRow.Cells["DtValidade"].Value),
                    Convert.ToDecimal(selectedRow.Cells["Preco"].Value)
                    );
            }
            this.Close();
        }

        void carregarGridProdutos()
        {
            _dataTableProdutos = produtoAppService.GetAll();
            dgvProdutos.DataSource = _dataTableProdutos;
            dgvProdutos.Refresh();
        }

        bool getIsActiveBool(string isActiveChar)
        {
            if (isActiveChar == "N")
                return false;
            return true;
        }
    }
}
