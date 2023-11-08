using IntegracaoDevApp.Application.Services;
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
    public partial class LoginWindow : Form
    {
        AuthService authService = new AuthService();
        public LoginWindow()
        {
            InitializeComponent();

            btnEntrar.Click += btnEntrar_Click;
            btnSair.Click += btnSair_Click;
            
        }

        void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void btnEntrar_Click(object sender, EventArgs e)
        {
            var user = new Usuario(txtUsername.Text, txtSenha.Text);
            if (validaDadosUsuario(user))
            {
                var mainWindow = new MainWindow(user);
                mainWindow.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Usuario ou senha inválidos!");
        }

        bool validaDadosUsuario(Usuario user)
        {
            if (authService.Login(user))
            {
                return true;
            }
            else
                limparCampos();
                return false;
        }

        void limparCampos()
        {
            txtUsername.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }
    }
}
