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
            this.dtpDtFechamento = new System.Windows.Forms.DateTimePicker();
            this.lblDtFechamento = new System.Windows.Forms.Label();
            this.dtpDtAbertura = new System.Windows.Forms.DateTimePicker();
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
            this.tsPedido = new System.Windows.Forms.ToolStrip();
            this.btnAdicionarPedido = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.btnFechar = new System.Windows.Forms.ToolStripButton();
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
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Controls.Add(this.dtpDtFechamento, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDtFechamento, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpDtAbertura, 4, 1);
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
            // dtpDtFechamento
            // 
            this.dtpDtFechamento.Enabled = false;
            this.dtpDtFechamento.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpDtFechamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtFechamento.Location = new System.Drawing.Point(872, 21);
            this.dtpDtFechamento.Name = "dtpDtFechamento";
            this.dtpDtFechamento.Size = new System.Drawing.Size(92, 26);
            this.dtpDtFechamento.TabIndex = 32;
            this.dtpDtFechamento.Value = new System.DateTime(2023, 10, 14, 22, 8, 39, 0);
            // 
            // lblDtFechamento
            // 
            this.lblDtFechamento.AutoSize = true;
            this.lblDtFechamento.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDtFechamento.Location = new System.Drawing.Point(872, 0);
            this.lblDtFechamento.Name = "lblDtFechamento";
            this.lblDtFechamento.Size = new System.Drawing.Size(79, 16);
            this.lblDtFechamento.TabIndex = 30;
            this.lblDtFechamento.Text = "Fechamento";
            // 
            // dtpDtAbertura
            // 
            this.dtpDtAbertura.Enabled = false;
            this.dtpDtAbertura.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpDtAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtAbertura.Location = new System.Drawing.Point(760, 21);
            this.dtpDtAbertura.Name = "dtpDtAbertura";
            this.dtpDtAbertura.Size = new System.Drawing.Size(105, 26);
            this.dtpDtAbertura.TabIndex = 31;
            this.dtpDtAbertura.Value = new System.DateTime(2023, 10, 14, 22, 8, 39, 0);
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
            // tsPedido
            // 
            this.tsPedido.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdicionarPedido,
            this.btnCancelar,
            this.btnSalvar,
            this.btnExcluir,
            this.btnFechar});
            this.tsPedido.Location = new System.Drawing.Point(0, 0);
            this.tsPedido.Name = "tsPedido";
            this.tsPedido.Size = new System.Drawing.Size(995, 25);
            this.tsPedido.TabIndex = 4;
            this.tsPedido.Text = "toolStrip2";
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
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
            // 
            // btnFechar
            // 
            this.btnFechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(23, 22);
            this.btnFechar.Text = "Fechar";
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
        private System.Windows.Forms.DateTimePicker dtpDtAbertura;
        private System.Windows.Forms.Label lblDtFechamento;
        private System.Windows.Forms.Label lblDtAbertura;
        private System.Windows.Forms.DateTimePicker dtpDtFechamento;
        private System.Windows.Forms.Label lblNumPedido;
        private System.Windows.Forms.TextBox txtNumPedido;
        private System.Windows.Forms.ToolStrip tsPedido;
        private System.Windows.Forms.ToolStripButton btnAdicionarPedido;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripButton btnFechar;
        private SubViews.PedidoItemView pedidoItemView1;
    }
}