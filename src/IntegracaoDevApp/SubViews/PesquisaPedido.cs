using IntegracaoDevApp.Application.Services;
using IntegracaoDevApp.Domain.Entities;
using IntegracaoDevApp.Domain.Entities.Pedido;
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
    public partial class PesquisaPedido : Form
    {
        DataTable _dataTablePedido = new DataTable();
        PedidoAppService _pedidoAppService = new PedidoAppService();
        public Pedido _pedidoAtual;
        public PesquisaPedido()
        {
            InitializeComponent();

            dgvPedidos.DoubleClick += dgvPedidos_DoubleClick;

            carregarGridPedidos();
        }

        public void dgvPedidos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPedidos.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvPedidos.SelectedRows[0];
                _pedidoAtual = new Pedido(
                    Convert.ToInt32(selectedRow.Cells["Numpedido"].Value),
                    Convert.ToString(selectedRow.Cells["CdCliente"].Value),
                    Convert.ToDateTime(selectedRow.Cells["DtAbertura"].Value),
                    //Convert.ToDateTime(selectedRow.Cells["DtFechamento"].Value),
                    Convert.ToString(selectedRow.Cells["Status"].Value)
                    );
            }

            this.Close();
        }

        public void carregarGridPedidos()
        {
            _dataTablePedido = _pedidoAppService.GetAllPedidos();
            dgvPedidos.DataSource = _dataTablePedido;
            dgvPedidos.Refresh();
        }
    }
}
