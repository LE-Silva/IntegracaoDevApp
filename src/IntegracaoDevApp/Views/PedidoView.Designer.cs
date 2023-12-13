using System;

namespace IntegracaoDevApp.Views
{
    partial class PedidoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoView));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDtAbertura = new System.Windows.Forms.Label();
            this.txtStatusPedido = new System.Windows.Forms.TextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lblClienteNome = new System.Windows.Forms.Label();
            this.txtCdCliente = new System.Windows.Forms.TextBox();
            this.lblcdCliente = new System.Windows.Forms.Label();
            this.lblNumPedido = new System.Windows.Forms.Label();
            this.txtNumPedido = new System.Windows.Forms.TextBox();
            this.pedidoItemView1 = new IntegracaoDevApp.SubViews.PedidoItemView();
            this.txtDtFechamento = new System.Windows.Forms.MaskedTextBox();
            this.txtDtAbertura = new System.Windows.Forms.MaskedTextBox();
            this.lblFechamento = new System.Windows.Forms.Label();
            this.tsPedido = new System.Windows.Forms.ToolStrip();
            this.btnPrimeiroPedido = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimoPedido = new System.Windows.Forms.ToolStripButton();
            this.tssPedido = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdicionarPedido = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
            this.btnImprimir = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tsPedido.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 6;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.07663F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 375F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel1.Controls.Add(this.lblDtAbertura, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtStatusPedido, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNomeCliente, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblClienteNome, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCdCliente, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblcdCliente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNumPedido, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumPedido, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.pedidoItemView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtDtFechamento, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtDtAbertura, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblFechamento, 5, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.30855F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(971, 506);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // lblDtAbertura
            // 
            this.lblDtAbertura.AutoSize = true;
            this.lblDtAbertura.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDtAbertura.Location = new System.Drawing.Point(760, 0);
            this.lblDtAbertura.Name = "lblDtAbertura";
            this.lblDtAbertura.Size = new System.Drawing.Size(56, 16);
            this.lblDtAbertura.TabIndex = 29;
            this.lblDtAbertura.Text = "Abertura";
            // 
            // txtStatusPedido
            // 
            this.txtStatusPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStatusPedido.Enabled = false;
            this.txtStatusPedido.Font = new System.Drawing.Font("Arial", 12F);
            this.txtStatusPedido.Location = new System.Drawing.Point(650, 21);
            this.txtStatusPedido.Name = "txtStatusPedido";
            this.txtStatusPedido.Size = new System.Drawing.Size(99, 26);
            this.txtStatusPedido.TabIndex = 26;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(650, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 16);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Status";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(275, 21);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(366, 26);
            this.txtNomeCliente.TabIndex = 3;
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.AutoSize = true;
            this.lblClienteNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNome.Location = new System.Drawing.Point(275, 0);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(41, 16);
            this.lblClienteNome.TabIndex = 2;
            this.lblClienteNome.Text = "Nome";
            // 
            // txtCdCliente
            // 
            this.txtCdCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdCliente.Enabled = false;
            this.txtCdCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCdCliente.Location = new System.Drawing.Point(138, 21);
            this.txtCdCliente.Name = "txtCdCliente";
            this.txtCdCliente.Size = new System.Drawing.Size(129, 26);
            this.txtCdCliente.TabIndex = 0;
            // 
            // lblcdCliente
            // 
            this.lblcdCliente.AutoSize = true;
            this.lblcdCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcdCliente.Location = new System.Drawing.Point(138, 0);
            this.lblcdCliente.Name = "lblcdCliente";
            this.lblcdCliente.Size = new System.Drawing.Size(109, 16);
            this.lblcdCliente.TabIndex = 1;
            this.lblcdCliente.Text = "Código do Cliente";
            // 
            // lblNumPedido
            // 
            this.lblNumPedido.AutoSize = true;
            this.lblNumPedido.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPedido.Location = new System.Drawing.Point(3, 0);
            this.lblNumPedido.Name = "lblNumPedido";
            this.lblNumPedido.Size = new System.Drawing.Size(47, 16);
            this.lblNumPedido.TabIndex = 34;
            this.lblNumPedido.Text = "Pedido";
            // 
            // txtNumPedido
            // 
            this.txtNumPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumPedido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumPedido.Location = new System.Drawing.Point(3, 21);
            this.txtNumPedido.Name = "txtNumPedido";
            this.txtNumPedido.Size = new System.Drawing.Size(129, 26);
            this.txtNumPedido.TabIndex = 35;
            // 
            // pedidoItemView1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.pedidoItemView1, 6);
            this.pedidoItemView1.Enabled = false;
            this.pedidoItemView1.Location = new System.Drawing.Point(3, 60);
            this.pedidoItemView1.Name = "pedidoItemView1";
            this.pedidoItemView1.Size = new System.Drawing.Size(965, 407);
            this.pedidoItemView1.TabIndex = 36;
            // 
            // txtDtFechamento
            // 
            this.txtDtFechamento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDtFechamento.Enabled = false;
            this.txtDtFechamento.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDtFechamento.Location = new System.Drawing.Point(859, 21);
            this.txtDtFechamento.Mask = "00/00/0000";
            this.txtDtFechamento.Name = "txtDtFechamento";
            this.txtDtFechamento.Size = new System.Drawing.Size(99, 26);
            this.txtDtFechamento.TabIndex = 37;
            this.txtDtFechamento.ValidatingType = typeof(System.DateTime);
            // 
            // txtDtAbertura
            // 
            this.txtDtAbertura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDtAbertura.Enabled = false;
            this.txtDtAbertura.Font = new System.Drawing.Font("Arial", 12F);
            this.txtDtAbertura.Location = new System.Drawing.Point(760, 21);
            this.txtDtAbertura.Mask = "00/00/0000";
            this.txtDtAbertura.Name = "txtDtAbertura";
            this.txtDtAbertura.Size = new System.Drawing.Size(93, 26);
            this.txtDtAbertura.TabIndex = 38;
            this.txtDtAbertura.ValidatingType = typeof(System.DateTime);
            // 
            // lblFechamento
            // 
            this.lblFechamento.AutoSize = true;
            this.lblFechamento.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblFechamento.Location = new System.Drawing.Point(859, 0);
            this.lblFechamento.Name = "lblFechamento";
            this.lblFechamento.Size = new System.Drawing.Size(79, 16);
            this.lblFechamento.TabIndex = 39;
            this.lblFechamento.Text = "Fechamento";
            // 
            // tsPedido
            // 
            this.tsPedido.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnPrimeiroPedido,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimoPedido,
            this.tssPedido,
            this.btnAdicionarPedido,
            this.btnCancelar,
            this.btnSalvar,
            this.btnExcluir,
            this.btnFechar,
            this.btnImprimir});
            this.tsPedido.Location = new System.Drawing.Point(0, 0);
            this.tsPedido.Name = "tsPedido";
            this.tsPedido.Size = new System.Drawing.Size(995, 25);
            this.tsPedido.TabIndex = 4;
            this.tsPedido.Text = "toolStrip2";
            // 
            // btnPrimeiroPedido
            // 
            this.btnPrimeiroPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPrimeiroPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnPrimeiroPedido.Image")));
            this.btnPrimeiroPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrimeiroPedido.Name = "btnPrimeiroPedido";
            this.btnPrimeiroPedido.Size = new System.Drawing.Size(23, 22);
<<<<<<< HEAD
            this.btnPrimeiroPedido.Text = "toolStripButton1";
=======
            this.btnPrimeiroPedido.Text = "Primeiro";
>>>>>>> f7f14e570a215d98ff7ef34e5505076c7016496b
            // 
            // btnAnterior
            // 
            this.btnAnterior.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(23, 22);
<<<<<<< HEAD
            this.btnAnterior.Text = "toolStripButton1";
=======
            this.btnAnterior.Text = "Anterior";
>>>>>>> f7f14e570a215d98ff7ef34e5505076c7016496b
            // 
            // btnProximo
            // 
            this.btnProximo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(23, 22);
<<<<<<< HEAD
            this.btnProximo.Text = "toolStripButton1";
=======
            this.btnProximo.Text = "Proximo";
>>>>>>> f7f14e570a215d98ff7ef34e5505076c7016496b
            // 
            // btnUltimoPedido
            // 
            this.btnUltimoPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUltimoPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimoPedido.Image")));
            this.btnUltimoPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimoPedido.Name = "btnUltimoPedido";
            this.btnUltimoPedido.Size = new System.Drawing.Size(23, 22);
<<<<<<< HEAD
            this.btnUltimoPedido.Text = "toolStripButton1";
=======
            this.btnUltimoPedido.Text = "Ultimo";
>>>>>>> f7f14e570a215d98ff7ef34e5505076c7016496b
            // 
            // tssPedido
            // 
            this.tssPedido.Name = "tssPedido";
            this.tssPedido.Size = new System.Drawing.Size(6, 25);
            // 
            // btnAdicionarPedido
            // 
            this.btnAdicionarPedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdicionarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnAdicionarPedido.Image")));
            this.btnAdicionarPedido.Name = "btnAdicionarPedido";
            this.btnAdicionarPedido.RightToLeftAutoMirrorImage = true;
            this.btnAdicionarPedido.Size = new System.Drawing.Size(23, 22);
            this.btnAdicionarPedido.Text = "Adicionar";
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.RightToLeftAutoMirrorImage = true;
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            // 
            // btnFechar
            // 
            this.btnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFechar.Enabled = false;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(23, 22);
            this.btnFechar.Text = "Fechar";
            // 
            // btnImprimir
            // 
            this.btnImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImprimir.Enabled = false;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(23, 22);
            this.btnImprimir.Text = "Imprimir";
            // 
            // PedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 556);
            this.Controls.Add(this.tsPedido);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PedidoView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tsPedido.ResumeLayout(false);
            this.tsPedido.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCdCliente;
        private System.Windows.Forms.Label lblcdCliente;
        private System.Windows.Forms.Label lblClienteNome;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatusPedido;
        private System.Windows.Forms.Label lblDtAbertura;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.ToolStrip tsPedido;
        private SubViews.PedidoItemView pedidoItemView1;
        private System.Windows.Forms.MaskedTextBox txtDtFechamento;
        private System.Windows.Forms.MaskedTextBox txtDtAbertura;
        private System.Windows.Forms.Label lblFechamento;
        private System.Windows.Forms.ToolStripSeparator tssPedido;
        private System.Windows.Forms.ToolStripButton btnAdicionarPedido;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnFechar;
        private System.Windows.Forms.ToolStripButton btnPrimeiroPedido;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripButton btnUltimoPedido;
        private System.Windows.Forms.ToolStripButton btnImprimir;
    }
}