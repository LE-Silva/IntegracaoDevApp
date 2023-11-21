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
    public partial class PesquisaCliente : Form
    {
        DataTable _dataTableClientes = new DataTable();
        ClienteAppService _clienteAppService = new ClienteAppService();
        public Cliente _clienteSelecionado;
        public PesquisaCliente()
        {
            InitializeComponent();

            dgvClientes.DoubleClick += dgvClientes_DoubleClick;

            carregarGridClientes();
        }

        void dgvClientes_DoubleClick(object sender, EventArgs e)
        {
            if (dgvClientes.SelectedRows.Count == 1)
            {
                DataGridViewRow selectedRow = dgvClientes.SelectedRows[0];
                _clienteSelecionado = new Cliente(
                    Convert.ToString(selectedRow.Cells["CdCliente"].Value),
                    Convert.ToString(selectedRow.Cells["Nome"].Value),
                    Convert.ToString(selectedRow.Cells["Cpf"].Value),
                    Convert.ToString(selectedRow.Cells["TpPessoa"].Value),
                    getIsActiveBool(Convert.ToInt32(selectedRow.Cells["StClientePremium"].Value)),
                    getIsActiveBool(Convert.ToInt32(selectedRow.Cells["StAtivo"].Value))
                    );
            }
            this.Close();
        }

        bool getIsActiveBool(int isActiveBit)
        {
            if (isActiveBit == 0)
                return false;
            return true;
        }

        void carregarGridClientes()
        {
            _dataTableClientes = _clienteAppService.GetAllClientes();
            dgvClientes.DataSource = _dataTableClientes;
            dgvClientes.Refresh();
        }
    }
}
