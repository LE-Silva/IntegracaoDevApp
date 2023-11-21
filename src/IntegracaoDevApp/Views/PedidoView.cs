using IntegracaoDevApp.Application.Services;
using IntegracaoDevApp.Domain.Entities;
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
        private Cliente _clienteSelecionado;
        private PedidoAppService _pedidoAppService = new PedidoAppService();
        private ClienteAppService _clienteAppService = new ClienteAppService();
        public PedidoView()
        {
            InitializeComponent();
            btnAdicionarPedido.Click += btnAdicionarPedido_Click;
            btnSalvar.Click += btnSalvar_Click;
            btnExcluir.Click += btnExcluir_Click;
            btnFechar.Click += btnFechar_Click;

            txtNumPedido.DoubleClick += txtNumPedido_DoubleClick;
            txtCdCliente.DoubleClick += buscaCliente;
            txtNomeCliente.DoubleClick += buscaCliente;
        }
        void txtNumPedido_DoubleClick(object sender, EventArgs e)
        {
            var janelaPequisaPedido = new PesquisaPedido();
            janelaPequisaPedido.ShowDialog();
            _pedidoAtual = janelaPequisaPedido._pedidoAtual;
            preencheCamposComDadosDoPedido();
        }
        void buscaCliente(object sender, EventArgs e)
        {
            var janelaPesquisaCliente = new PesquisaCliente();
            janelaPesquisaCliente.ShowDialog();
            _clienteSelecionado = janelaPesquisaCliente._clienteSelecionado;
            txtCdCliente.Text = _clienteSelecionado.CdCliente;
            txtNomeCliente.Text = _clienteSelecionado.Nome;
        }
        void btnAdicionarPedido_Click(object sender, EventArgs e)
        {
            inverteStatusBotoes();
            alterarStatusCampos();
            deixaCamposEmBranco();
        }
        void btnSalvar_Click(object sender, EventArgs e)
        {
            var r = _pedidoAppService.Create(new Pedido(0, txtCdCliente.Text, DateTime.Now, "A"));
            if (!r.Success)
            {
                var message = new StringBuilder();
                foreach (var item in r.Messages)
                    message.AppendLine(item.ToString());

                MessageBox.Show(message.ToString());
                return;
            }

            //if (_clienteAppService.Create(new Cliente(txtCodigo.Text, txtNome.Text, mtxtCPF.Text, cbTpPessoa.Text, chkCliPremium.Checked, rbtnAtivo.Checked)))
            //    MessageBox.Show("Cadastrado com Sucesso!");
            //else
            //    MessageBox.Show("Erro ao inserir o produto");
        }
        void btnExcluir_Click(object sender, EventArgs e)
        {
            _pedidoAppService.Delete(txtNumPedido.Text);
            MessageBox.Show("Excluido com sucesso!");
            alterarStatusCampos();
            inverteStatusBotoes();
            deixaCamposEmBranco();
        }
        void btnFechar_Click(object sender, EventArgs e)
        {
            _pedidoAppService.Fechar(txtNumPedido.Text, txtStatusPedido.Text);
        }
        void alterarStatusCampos()
        {
            txtNumPedido.Enabled = !txtNumPedido.Enabled;
            txtCdCliente.Enabled = !txtCdCliente.Enabled;
            txtNomeCliente.Enabled = !txtNomeCliente.Enabled;
        }
        void deixaCamposEmBranco()
        {
            txtNumPedido.Text = string.Empty;
            txtCdCliente.Text = string.Empty;
            txtStatusPedido.Text = string.Empty;
            txtNomeCliente.Text= string.Empty;
        }
        void preencheCamposComDadosDoPedido()
        {
            txtNumPedido.Text = _pedidoAtual.NumPedido.ToString();
            txtCdCliente.Text = _pedidoAtual.CdCliente;
            txtStatusPedido.Text = _pedidoAtual.Status;
            dtpDtAbertura.Value = _pedidoAtual.DtAbertura;
            //dtpDtFechamento.Value = _pedidoAtual.DtFechamento;
            txtNomeCliente.Text = getNomeCliente();
        }
        string getNomeCliente()
        {
            var cliente = _clienteAppService.GetCliente(txtCdCliente.Text);
            var nomeCliente = cliente.Rows[0]["Nome"].ToString();

            return nomeCliente;
        }
        void inverteStatusBotoes()
        {
            btnAdicionarPedido.Enabled = !btnAdicionarPedido.Enabled;
            btnCancelar.Enabled = !btnCancelar.Enabled;
            btnExcluir.Enabled = !btnExcluir.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
        }
    }
}
