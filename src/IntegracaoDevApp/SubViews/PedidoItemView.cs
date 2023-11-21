using IntegracaoDevApp.Application.Services;
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
        DataTable _dataTablePedidoItem = new DataTable();
        PedidoItemAppService _pedidoItemAppService = new PedidoItemAppService();
        public PedidoItemView()
        {
            InitializeComponent();
        }

        void carregarGridClientes()
        {
            //_dataTablePedidoItem = _pedidoItemAppService.GetTodosItensDoPedido(_numpedido);
            dgvPedidoItens.DataSource = _dataTablePedidoItem;
            dgvPedidoItens.Refresh();
        }

    }
}
