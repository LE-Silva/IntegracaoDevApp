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

namespace IntegracaoDevApp.Views
{
    public partial class PedidoView : Form
    {
        private DataTable _pedidos;
        private DataTable _pedidoItens;
        private PedidoAppService _pedidosAppService;
        public PedidoView()
        {
            dgvPedidoItens.DataSource = _pedidos;
            InitializeComponent();
        }

        void carregarGridItens(int numpedido)
        {
            dgvPedidoItens.DataSource = _pedidos;
            dgvPedidoItens.Refresh();
        }
    }
}
