﻿using IntegracaoDevApp.Application.Services;
using IntegracaoDevApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace IntegracaoDevApp
{
    public partial class ClienteWindow : Form
    {
        //private BindingList<Cliente> listaClientes = new BindingList<Cliente>();
        public Usuario usuarioLogado;
        private DataTable _dataTableClientes = new DataTable();
        private ClienteAppService _clienteAppService;
        private List<Cliente> listaClientes; 

        public ClienteWindow()
        {
            InitializeComponent();

            _clienteAppService = new ClienteAppService();

            //Label, Textbox, Combobox, RadioButton, Checkbox, Button
            //Codigo, Descricao, Status, CPF, TP pessoa, Cliente Premium

            var tiposPessoa = new string[] {"Masculino", "Feminino", "Juridico"};
            var listaCaracteresInvalidos = new string[] { "$", "/", "<", ">"};

            cbTpPessoa.DataSource = tiposPessoa;
            cbTpPessoa.SelectedIndex = -1;
            cbTpPessoa.SelectedIndexChanged += cbTpPessoa_SelectedIndexChanged;
            cbTpPessoa.TabStop = false;
            cbTpPessoa.EnabledChanged += cbTpPessoa_EnabledChanged;

            chkCliPremium.TabStop = false;
            chkCliPremium.EnabledChanged += chkCliPremium_EnabledChanged;

            rbtnAtivo.EnabledChanged += rbtnAtivo_EnabledChanged;
            rbtnInativo.EnabledChanged += rbtnInativo_EnabledChanged;

            btnAdicionar.Click += btnAdicionar_Click;
            btnSalvar.Click += btnSalvar_Click;
            btnCancelar.Click += btnCancelar_Click;
            btnExcluir.Click += btnExcluir_Click;

            ttCodigo.SetToolTip(txtCodigo, "Código do Cliente");
            ttCodigo.SetToolTip(txtNome, "Nome do Cliente");
            ttCodigo.SetToolTip(mtxtCPF, "CPF do Cliente");

            txtCodigo.DoubleClick += txtCodigo_DoubleClick;
            txtCodigo.GotFocus += txtCodigo_GotFocus;
            txtCodigo.EnabledChanged += txtCodigo_EnabledChanged;

            txtNome.DoubleClick += txtNome_DoubleClick;
            txtNome.GotFocus += txtNome_GotFocus;
            txtCodigo.EnabledChanged += txtNome_EnabledChanged;

            mtxtCPF.Mask = "999.999.999-99";
            mtxtCPF.DoubleClick += mtxtCPF_DoubleClick;
            mtxtCPF.GotFocus += mtxtCPF_GotFocus;
            mtxtCPF.EnabledChanged += mtxtCPF_EnabledChanged;

            //Não funcionam
            txtCodigo.KeyDown += txtCodigo_KeyDown;
            txtNome.KeyDown += txtNome_KeyDown;

            selecionarTodosToolStripMenuItem.Click += selecionarTodosToolStripMenuItem_Click;
            desmarcarTodosToolStripMenuItem.Click += desmarcarTodosToolStripMenuItem_Click;
            excluirToolStripMenuItem.Click += excluirToolStripMenuItem_Click;

            dgvClientes.DoubleClick += DgvClientes_DoubleClick;

            void btnAdicionar_Click(object sender, EventArgs e)
            {
                alterarStatusCampos();
                txtCodigo.Focus();
            }
            void btnCancelar_Click(object sender, EventArgs e)
            {
                alterarStatusCampos();
            }
            void btnSalvar_Click(object sender, EventArgs e)
            {
                var cliente = _clienteAppService.GetCliente(txtCodigo.Text);
                if (cliente.Rows.Count > 0)
                    atualizaCliente();
                else
                    insereCliente();

                //if (validaCamposEmBranco())
                //{
                //    var result = _clienteAppService.Create(new Cliente(txtCodigo.Text, txtNome.Text, mtxtCPF.Text, cbTpPessoa.Text, chkCliPremium.Checked, rbtnAtivo.Checked));
                //    //Insert();
                //    //Update();
                //    //listaClientes.Add(new Cliente(txtCodigo.Text, txtNome.Text, mtxtCPF.Text, cbTpPessoa.Text, chkCliPremium.Checked, rbtnAtivo.Checked));
                //    //alterarStatusCampos();
                //}

                carregarGridClientes();
            }
            void btnExcluir_Click(object sender, EventArgs e)
            {
                _clienteAppService.Delete(txtCodigo.Text);
                MessageBox.Show("Excluido com sucesso!");
                carregarGridClientes();
            }

            void txtCodigo_DoubleClick(object sender, EventArgs e)
            {
                txtCodigo.SelectAll();
                txtCodigo.Copy();
            }
            void txtNome_DoubleClick(object sender, EventArgs e)
            {
                txtNome.SelectAll();
                txtNome.Copy();
            }
            void mtxtCPF_DoubleClick(object sender, EventArgs e)
            {
                mtxtCPF.SelectAll();
                mtxtCPF.Copy();
            }

            void txtCodigo_KeyDown(object sender, KeyEventArgs e)
            {
                if (listaCaracteresInvalidos.Contains(e.KeyValue.ToString()))
                {
                    e.Handled = true;
                }
            }
            void txtNome_KeyDown(object sender, KeyEventArgs e)
            {
                if (listaCaracteresInvalidos.Contains(e.KeyValue.ToString()))
                {
                    e.Handled = true;
                }
            }

            void txtNome_GotFocus(object sender, EventArgs e)
            {
                txtNome.SelectAll();
            }
            void txtCodigo_GotFocus(object sender, EventArgs e)
            {
                txtCodigo.SelectAll();
            }
            void mtxtCPF_GotFocus(object sender, EventArgs e)
            {
                mtxtCPF.SelectAll();
            }

            void txtCodigo_EnabledChanged(object sender, EventArgs e)
            {
                txtCodigo.Text = string.Empty;
            }
            void txtNome_EnabledChanged(object sender, EventArgs e)
            {
                txtNome.Text = string.Empty;
            }
            void mtxtCPF_EnabledChanged(object sender, EventArgs e)
            {
                mtxtCPF.Text = string.Empty;
            }
            void chkCliPremium_EnabledChanged(object sender, EventArgs e)
            {
                chkCliPremium.Checked = false;
            }
            void cbTpPessoa_EnabledChanged(object sender, EventArgs e)
            {
                cbTpPessoa.SelectedIndex = -1;
            }
            void rbtnAtivo_EnabledChanged(object sender, EventArgs e)
            {
                rbtnAtivo.Checked = false;
            }
            void rbtnInativo_EnabledChanged(object sender, EventArgs e)
            {
                rbtnInativo.Checked = false;
            }

            void cbTpPessoa_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (cbTpPessoa.Text == "Juridico")
                {
                    mtxtCPF.Mask = "99.999.999/9999-99";
                    labelCPF.Text = "CNPJ";
                    labelClienteDescricao.Text = "Razão Social";
                }
                else
                {
                    ttCodigo.SetToolTip(mtxtCPF, "CNPJ do Cliente"); // Não funciona
                    mtxtCPF.Mask = "999.999.999-99";
                    labelCPF.Text = "CPF";
                    labelClienteDescricao.Text = "Nome";
                }
                    
            }

            void selecionarTodosToolStripMenuItem_Click(object sender, EventArgs e)
            {
                foreach(Cliente cliente in listaClientes)
                {
                    cliente.Selected = true;
                }
                dgvClientes.Refresh();
            }
            void desmarcarTodosToolStripMenuItem_Click(object sender, EventArgs e)
            {
                foreach (Cliente cliente in listaClientes)
                {
                    cliente.Selected = false;
                }
                dgvClientes.Refresh();
            }
            void excluirToolStripMenuItem_Click(Object sender, EventArgs e)
            {
                var clienteQuery =
                    from cliente in listaClientes
                    where cliente.Selected == false
                    select cliente;
                var clientesSelecionados = listaClientes.Except(clienteQuery).ToList();

                foreach (Cliente cliente in clientesSelecionados)
                {
                    listaClientes.Remove(cliente);
                }
                dgvClientes.Refresh();
            }


            carregarGridClientes();
        }

        private void DgvClientes_DoubleClick(object sender, EventArgs e)
        {
            //var cliente = (Cliente)dgvClientes.SelectedRows[0].DataBoundItem;
            //txtCodigo.Text = cliente.CdCliente.ToString();
            //txtNome.Text = cliente.Nome.ToString();

            if (dgvClientes.SelectedRows.Count == 1)
            {
                alterarStatusCampos();
                DataGridViewRow selectedRow = dgvClientes.SelectedRows[0];
                txtCodigo.Text = selectedRow.Cells["CdCliente"].Value.ToString();
                txtNome.Text = selectedRow.Cells["Nome"].Value.ToString();
                mtxtCPF.Text = selectedRow.Cells["Cpf"].Value.ToString();
                cbTpPessoa.Text = selectedRow.Cells["TpPessoa"].Value.ToString();
                chkCliPremium.Checked = getIsActiveBool(Convert.ToInt32(selectedRow.Cells["StClientePremium"].Value));
                rbtnAtivo.Checked = getIsActiveBool(Convert.ToInt32(selectedRow.Cells["StAtivo"].Value));
                tcCadastrarP.SelectedIndex = 0;
            }
        }

        void carregarGridClientes()
        {
            _dataTableClientes = _clienteAppService.GetAllClientes();
            dgvClientes.DataSource = _dataTableClientes;
            dgvClientes.Refresh();
        }

        void atualizaCliente()
        {
            if (_clienteAppService.Update(new Cliente(txtCodigo.Text, txtNome.Text, mtxtCPF.Text, cbTpPessoa.Text, chkCliPremium.Checked, rbtnAtivo.Checked)))
                MessageBox.Show("Atualizado com Sucesso!");
            else
                MessageBox.Show("Erro ao atualizar");
            _dataTableClientes = _clienteAppService.GetAllClientes();
            dgvClientes.Refresh();
        }

        void insereCliente()
        {
            if (_clienteAppService.Create(new Cliente(txtCodigo.Text, txtNome.Text, mtxtCPF.Text, cbTpPessoa.Text, chkCliPremium.Checked, rbtnAtivo.Checked)))
                MessageBox.Show("Cadastrado com Sucesso!");
            else
                MessageBox.Show("Erro ao inserir o produto");
            _dataTableClientes = _clienteAppService.GetAllClientes();
            dgvClientes.Refresh();
        }

        bool getIsActiveBool(int isActiveBit)
        {
            if (isActiveBit == 0)
                return false;
            return true;
        }

        void alterarStatusCampos()
        {
            //limparCampos();
            btnAdicionar.Enabled = !btnAdicionar.Enabled;
            btnSalvar.Enabled = !btnSalvar.Enabled;
            btnExcluir.Enabled = !btnExcluir.Enabled;
            txtCodigo.Enabled = !txtCodigo.Enabled;
            mtxtCPF.Enabled = !mtxtCPF.Enabled;
            txtNome.Enabled = !txtNome.Enabled;
            btnCancelar.Enabled = !btnCancelar.Enabled;
            cbTpPessoa.Enabled = !cbTpPessoa.Enabled;
            rbtnAtivo.Enabled = !rbtnAtivo.Enabled;
            rbtnInativo.Enabled = !rbtnInativo.Enabled;
            rbtnAtivo.Checked = !rbtnAtivo.Checked;
            chkCliPremium.Enabled = !chkCliPremium.Enabled;
        }
    }

}
