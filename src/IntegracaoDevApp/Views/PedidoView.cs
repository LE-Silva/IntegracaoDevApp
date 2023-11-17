using IntegracaoDevApp.Application.Services;
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

namespace IntegracaoDevApp.Views
{
    public partial class PedidoView : Form
    {
        private Pedido _pedidoAtual;
        private BindingSource _pedidoBindingSource = new BindingSource();
        private PedidoAppService _pedidoAppService = new PedidoAppService();
        public PedidoView()
        {
            InitializeComponent();
            _pedidoBindingSource.DataSource = _pedidoAppService.GetAllPedidos();
            bindingNavigator1.BindingSource = _pedidoBindingSource;
            bnNumPedido.LostFocus += bnNumPedido_LostFocus;
        }

        void carregarGridItens(int numpedido)
        {
            dgvPedidoItens.Refresh();
        }

        void bnNumPedido_LostFocus(object sender, EventArgs e)
        {
            if (!verificaSePedidoExiste())
                MessageBox.Show("Pedido não existe");
            else
                preencheCamposComDadosDoPedido();
        }

        void preencheCamposComDadosDoPedido()
        {
            txtCdCliente.Text = _pedidoAtual.CdCliente;
            txtStatusPedido.Text = _pedidoAtual.Status;
            dtpDtAbertura.Value = _pedidoAtual.DtAbertura;
            dtpDtFechamento.Value = _pedidoAtual.DtFechamento;
        }

        bool verificaSePedidoExiste()
        {
            _pedidoAtual = _pedidoAppService.GetPedidoByNumero(bnNumPedido.Text);
            if (_pedidoAtual == null)
                return false;
            return true;
        }

        void refresh()
        {
            _pedidoBindingSource.DataSource = _pedidoAtual;
            bindingNavigator1.BindingSource = _pedidoBindingSource;
            bnNumPedido.LostFocus += bnNumPedido_LostFocus;
        }
    }
}
