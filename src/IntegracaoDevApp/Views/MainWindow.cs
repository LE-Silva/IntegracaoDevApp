using IntegracaoDevApp.Domain.Entities;
using IntegracaoDevApp.Views;
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

namespace IntegracaoDevApp
{
    public partial class MainWindow : Form
    {
        Usuario Usuario { get; set; }
        public MainWindow(Usuario usuarioLogado)
        {
            InitializeComponent();
            Usuario = usuarioLogado;

            cadastrarClientesToolStripMenuItem.Click += cadastrarClientesToolStripMenuItem_Click;
            cadastrarProdutosToolStripMenuItem.Click += cadastrarProdutosToolStripMenuItem_Click;
            pedidoToolStripMenuItem.Click += pedidoToolStripMenuItem_Click;
            relatorioToolStripMenuItem.Click += RelatorioToolStripMenuItem_Click;

            tslBd.Text = "SPT_LEJ_DbNutAg";
            tslUser.Text = usuarioLogado.Username;
        }

        private void RelatorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dataplace.Core.win.Views.Managers.ViewManager.ShowViewOnForm<IntegracaoDevApp_RelatorioView>(captionForm: "Relatório");
        }

        void cadastrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroCliente = new ClienteWindow();
            cadastroCliente.usuarioLogado = Usuario;
            cadastroCliente.MdiParent = this;
            cadastroCliente.Show();
        }

        void cadastrarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroProduto = new ProdutoWindow();
            cadastroProduto.usuarioLogado = Usuario;
            cadastroProduto.MdiParent = this;
            cadastroProduto.Show();
        }

        void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lancamentoPedido = new PedidoView();
            lancamentoPedido.MdiParent = this;
            lancamentoPedido.Show();
        }
    }
}
