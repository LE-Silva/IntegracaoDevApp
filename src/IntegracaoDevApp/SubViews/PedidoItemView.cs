using IntegracaoDevApp.Application.Services;
using IntegracaoDevApp.Domain.Entities;
using IntegracaoDevApp.Domain.Entities.PedidoItem;
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
    public partial class PedidoItemView : UserControl
    {
        public int _numpedido = 0;
        Produto _produtoSelecionado;
        int _itemAtualSeq;
        DataTable _dataTableItens = new DataTable();
        PedidoItemAppService _itemAppService = new PedidoItemAppService();
        public PedidoItemView()
        {
            InitializeComponent();
            btnSalvar.Click += btnAdicionarItem_Click;
            btnExcluirItem.Click += BtnExcluirItem_Click;

            txtCdProduto.KeyDown += TxtDescProd_KeyDown;
            txtDescProd.KeyDown += TxtDescProd_KeyDown;

            dgvPedidoItens.DoubleClick += DgvPedidoItens_DoubleClick;
        }

        private void BtnExcluirItem_Click(object sender, EventArgs e)
        {
            _itemAppService.Delete(_itemAtualSeq);
            carregarGridPedidoItem();
        }

        private void DgvPedidoItens_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPedidoItens.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvPedidoItens.SelectedRows[0];
                txtCdProduto.Text = selectedRow.Cells["CdProduto"].Value.ToString();
                txtQtd.Text = selectedRow.Cells["Quantidade"].Value.ToString();
                txtValor.Text = selectedRow.Cells["Valor"].Value.ToString();
                _itemAtualSeq = Convert.ToInt16(selectedRow.Cells["Seq"].Value);
            }
        }
        private void TxtDescProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                pesquisaProduto();
        }
        void btnAdicionarItem_Click(object sender, EventArgs e)
        {
            if (Decimal.TryParse(txtValor.Text, out decimal parcedValue) && Decimal.TryParse(txtQtd.Text, out decimal parcedQtd))
            {
                var r = _itemAppService.Create(new PedidoItem(_numpedido, txtCdProduto.Text, parcedQtd, parcedValue));
                if (!r.Success)
                {
                    var message = new StringBuilder();
                    foreach (var item in r.Messages)
                        message.AppendLine(item.ToString());

                    MessageBox.Show(message.ToString());
                    return;
                }

                if(_produtoSelecionado != null)
                    carregarGridPedidoItem();
            }
        }
        public void carregarGridPedidoItem()
        {
            if(_numpedido > 0)
            {
                _dataTableItens = _itemAppService.GetTodosItensDoPedido(_numpedido);
                dgvPedidoItens.DataSource = _dataTableItens;
                dgvPedidoItens.Columns[0].Visible = false;
                dgvPedidoItens.Columns[1].Visible = false;
                dgvPedidoItens.Refresh();
            }
        }
        void preencheCampoItem()
        {
            txtCdProduto.Text = _produtoSelecionado.CdProduto.ToString();
            txtDescProd.Text = _produtoSelecionado.Descricao;
            txtQtd.Text = "0";
            txtValor.Text = _produtoSelecionado.Valor.ToString();
        }
        void pesquisaProduto()
        {
            var janelaPesquisaProduto = new PesquisaProduto();
            janelaPesquisaProduto.ShowDialog();
            _produtoSelecionado = janelaPesquisaProduto._produtoSelecionado;
            preencheCampoItem();
        }
    }
}
