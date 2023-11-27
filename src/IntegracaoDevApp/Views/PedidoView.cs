using IntegracaoDevApp.Application.Services;
using IntegracaoDevApp.Domain.Entities;
using IntegracaoDevApp.Domain.Entities.PedidoItem;
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
            btnCancelar.Click += BtnCancelar_Click;
            btnSalvar.Click += btnSalvar_Click;
            btnExcluir.Click += btnExcluir_Click;
            btnFechar.Click += btnFechar_Click;
            btnPrimeiroPedido.Click += BtnPrimeiroPedido_Click;
            btnUltimoPedido.Click += BtnUltimoPedido_Click;
            btnProximo.Click += BtnProximo_Click;
            btnAnterior.Click += BtnAnterior_Click;

            txtNumPedido.KeyDown += txtNumPedido_KeyDown;
            txtCdCliente.KeyDown += buscaCliente;
            txtNomeCliente.KeyDown += buscaCliente;
        }

        private void BtnAnterior_Click(object sender, EventArgs e)
        {
            _pedidoAtual = _pedidoAppService.GetAnteriorPedido(txtNumPedido.Text);
            if (_pedidoAtual != null)
            {
                pedidoItemView1.deixaCamposEmBranco();
                preencheCamposComDadosDoPedido();
                verificaPedidoFechado();
            }
        }
        private void BtnProximo_Click(object sender, EventArgs e)
        {
            _pedidoAtual = _pedidoAppService.GetProximoPedido(txtNumPedido.Text);
            if (_pedidoAtual != null)
            {
                pedidoItemView1.deixaCamposEmBranco();
                preencheCamposComDadosDoPedido();
                verificaPedidoFechado();
            }
        }
        void txtNumPedido_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var janelaPequisaPedido = new PesquisaPedido();
                janelaPequisaPedido.ShowDialog();
                _pedidoAtual = janelaPequisaPedido._pedidoAtual;
                if (_pedidoAtual != null)
                {
                    pedidoItemView1.deixaCamposEmBranco();
                    preencheCamposComDadosDoPedido();
                    verificaPedidoFechado();
                }
            }
            
        }
        void buscaCliente(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var janelaPesquisaCliente = new PesquisaCliente();
                janelaPesquisaCliente.ShowDialog();
                _clienteSelecionado = janelaPesquisaCliente._clienteSelecionado;
                if (!_clienteSelecionado.StAtivo)
                {
                    MessageBox.Show("Pedido não pode ter cliente inativo");
                    return;
                }
                txtCdCliente.Text = _clienteSelecionado.CdCliente;
                txtNomeCliente.Text = _clienteSelecionado.Nome;
            }
            
        }
        void btnAdicionarPedido_Click(object sender, EventArgs e)
        {
            btnCancelar.Enabled = true;
            btnSalvar.Enabled = true;
            btnAdicionarPedido.Enabled = false;
            pedidoItemView1.deixaCamposEmBranco();
            alterarStatusCampos();
            deixaCamposEmBranco();
        }
        void BtnCancelar_Click(object sender, EventArgs e)
        {
            alterarStatusCampos();
            deixaCamposEmBranco();
            btnCancelar.Enabled = false;
            btnSalvar.Enabled = false;
            btnAdicionarPedido.Enabled = true;
            pedidoItemView1.Enabled = false;
        }
        void btnSalvar_Click(object sender, EventArgs e)
        {
            var r = _pedidoAppService.Create(new Pedido(0, txtCdCliente.Text, DateTime.Now, "A"));
            //if (!r.Success)
            //{
            //    var message = new StringBuilder();
            //    foreach (var item in r.Messages)
            //        message.AppendLine(item.ToString());
            //
            //    MessageBox.Show(message.ToString());
            //    return;
            //}

            _pedidoAtual = _pedidoAppService.GetPedidoByNumero(r.ToString());
            preencheCamposComDadosDoPedido();
            verificaPedidoFechado();

            btnCancelar.Enabled = false;
            btnExcluir.Enabled = true;
            btnFechar.Enabled = true;
            btnAdicionarPedido.Enabled = true;
            txtCdCliente.Enabled = false;
            txtNomeCliente.Enabled = false;
            txtNumPedido.Enabled = true;
        }
        void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!_pedidoAppService.IsPedidoFechado(txtNumPedido.Text))
            {
                MessageBox.Show("Não pode excluir pedido fechado!");
                return;
            }
            _pedidoAppService.Delete(txtNumPedido.Text);
            pedidoItemView1._itemAppService.DeleteTodosItensPedido(txtNumPedido.Text);            
            pedidoItemView1.Enabled = false;
            pedidoItemView1.deixaCamposEmBranco();
            pedidoItemView1.limpaGrid();
            btnAdicionarPedido.Enabled = true;
            btnCancelar.Enabled = false;
            btnExcluir.Enabled = false;
            btnFechar.Enabled = false;
            btnSalvar.Enabled = false;
            txtCdCliente.Enabled=false;
            txtNomeCliente.Enabled=false;
            txtNumPedido.Enabled = true;
            deixaCamposEmBranco();
            MessageBox.Show("Excluido com sucesso!");
        }
        void btnFechar_Click(object sender, EventArgs e)
        {
            _pedidoAppService.Fechar(txtNumPedido.Text, txtStatusPedido.Text);
            _pedidoAtual = _pedidoAppService.GetPedidoByNumero(txtNumPedido.Text);
            pedidoItemView1.deixaCamposEmBranco();
            preencheCamposComDadosDoPedido();
            verificaPedidoFechado();
        }
        void BtnUltimoPedido_Click(object sender, EventArgs e)
        {
            _pedidoAtual = _pedidoAppService.GetUltimoPedido();
            pedidoItemView1.deixaCamposEmBranco();
            preencheCamposComDadosDoPedido();
            verificaPedidoFechado();
        }
        void BtnPrimeiroPedido_Click(object sender, EventArgs e)
        {
            _pedidoAtual = _pedidoAppService.GetPrimeiroPedido();
            pedidoItemView1.deixaCamposEmBranco();
            preencheCamposComDadosDoPedido();
            verificaPedidoFechado();
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
            txtDtAbertura.Text = _pedidoAtual.DtAbertura.ToString();
            txtDtFechamento.Text = _pedidoAtual.DtFechamento.ToString();
            txtNomeCliente.Text = getNomeCliente();
            preencheItensPedido();
            btnSalvar.Enabled = false;
            btnFechar.Enabled = true;
            btnExcluir.Enabled = true;
        }
        string getNomeCliente()
        {
            var cliente = _clienteAppService.GetCliente(txtCdCliente.Text);
            var nomeCliente = cliente.Rows[0]["Nome"].ToString();

            return nomeCliente;
        }
        void preencheItensPedido()
        {
            pedidoItemView1.Enabled = true;
            pedidoItemView1._numpedido = Convert.ToInt32(txtNumPedido.Text);
            pedidoItemView1.carregarGridPedidoItem();
        }
        void verificaPedidoFechado()
        {
            if (txtStatusPedido.Text == "FECHADO")
            {
                pedidoItemView1.Enabled = false;
                return;
            }
            pedidoItemView1.Enabled = true;
        }
    }
}
