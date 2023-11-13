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

namespace IntegracaoDevApp.Views
{
    public partial class PedidoWindow : Form
    {
        public Usuario usuarioLogado;
        public string[] listaPedidos;
        public PedidoWindow()
        {
            InitializeComponent();
        }
    }
}
