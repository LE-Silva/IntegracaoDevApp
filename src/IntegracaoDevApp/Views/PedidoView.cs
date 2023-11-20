using IntegracaoDevApp.Application.Services;
using IntegracaoDevApp.Domain.Entities.Pedido;
using IntegracaoDevApp.SubViews;
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
        private ClienteAppService _clienteAppService = new ClienteAppService();
        public PedidoView()
        {
            InitializeComponent();
            _pedidoBindingSource.DataSource = _pedidoAppService.GetAllPedidos();
            bindingNavigator1.BindingSource = _pedidoBindingSource;
            txtNumPedido.DoubleClick += txtNumPedido_DoubleClick;
        }

        void preencheCamposComDadosDoPedido()
        {
            txtNumPedido.Text = _pedidoAtual.NumPedido.ToString();
            txtCdCliente.Text = _pedidoAtual.CdCliente;
            txtStatusPedido.Text = _pedidoAtual.Status;
            dtpDtAbertura.Value = _pedidoAtual.DtAbertura;
            dtpDtFechamento.Value = _pedidoAtual.DtFechamento;
            txtNomeCliente.Text = getNomeCliente();
        }
        void txtNumPedido_DoubleClick(object sender, EventArgs e)
        {
            var janelaPequisaPedido = new PesquisaPedido();
            janelaPequisaPedido.ShowDialog();
            _pedidoAtual = janelaPequisaPedido._pedidoAtual;
            preencheCamposComDadosDoPedido();
        }

        string getNomeCliente()
        {
            var cliente = _clienteAppService.GetCliente(txtCdCliente.Text);
            var nomeCliente = cliente.Rows[0]["Nome"].ToString();

            return nomeCliente;
        }
    }
}
