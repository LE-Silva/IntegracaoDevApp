namespace IntegracaoDevApp.SubViews
{
    partial class PedidoItemView
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoItemView));
            this.btnExcluirItem = new System.Windows.Forms.ToolStripButton();
            this.tsPedidoItem = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.gbItens = new System.Windows.Forms.GroupBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblQtd = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblCdProd = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.txtDescProd = new System.Windows.Forms.TextBox();
            this.txtCdProduto = new System.Windows.Forms.TextBox();
            this.dgvPedidoItens = new System.Windows.Forms.DataGridView();
            this.tsPedidoItem.SuspendLayout();
            this.gbItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoItens)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcluirItem
            // 
            this.btnExcluirItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluirItem.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirItem.Image")));
            this.btnExcluirItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluirItem.Name = "btnExcluirItem";
            this.btnExcluirItem.Size = new System.Drawing.Size(23, 22);
            this.btnExcluirItem.Text = "Excluir";
            // 
            // tsPedidoItem
            // 
            this.tsPedidoItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.btnExcluirItem});
            this.tsPedidoItem.Location = new System.Drawing.Point(0, 0);
            this.tsPedidoItem.Name = "tsPedidoItem";
            this.tsPedidoItem.Size = new System.Drawing.Size(971, 25);
            this.tsPedidoItem.TabIndex = 2;
            this.tsPedidoItem.Text = "toolStrip1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(23, 22);
            this.btnSalvar.Text = "Salvar";
            // 
            // gbItens
            // 
            this.gbItens.Controls.Add(this.lblValor);
            this.gbItens.Controls.Add(this.lblQtd);
            this.gbItens.Controls.Add(this.lblDesc);
            this.gbItens.Controls.Add(this.lblCdProd);
            this.gbItens.Controls.Add(this.txtValor);
            this.gbItens.Controls.Add(this.txtQtd);
            this.gbItens.Controls.Add(this.txtDescProd);
            this.gbItens.Controls.Add(this.txtCdProduto);
            this.gbItens.Controls.Add(this.dgvPedidoItens);
            this.gbItens.Location = new System.Drawing.Point(3, 28);
            this.gbItens.Name = "gbItens";
            this.gbItens.Size = new System.Drawing.Size(965, 382);
            this.gbItens.TabIndex = 11;
            this.gbItens.TabStop = false;
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(839, 16);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 19;
            this.lblValor.Text = "Valor";
            // 
            // lblQtd
            // 
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(733, 16);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(62, 13);
            this.lblQtd.TabIndex = 18;
            this.lblQtd.Text = "Quantidade";
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Location = new System.Drawing.Point(119, 16);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(55, 13);
            this.lblDesc.TabIndex = 17;
            this.lblDesc.Text = "Descrição";
            // 
            // lblCdProd
            // 
            this.lblCdProd.AutoSize = true;
            this.lblCdProd.Location = new System.Drawing.Point(16, 16);
            this.lblCdProd.Name = "lblCdProd";
            this.lblCdProd.Size = new System.Drawing.Size(95, 13);
            this.lblCdProd.TabIndex = 16;
            this.lblCdProd.Text = "Código do Produto";
            // 
            // txtValor
            // 
            this.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(842, 35);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 25);
            this.txtValor.TabIndex = 15;
            // 
            // txtQtd
            // 
            this.txtQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQtd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQtd.Location = new System.Drawing.Point(736, 35);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(100, 25);
            this.txtQtd.TabIndex = 14;
            // 
            // txtDescProd
            // 
            this.txtDescProd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescProd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescProd.Location = new System.Drawing.Point(122, 35);
            this.txtDescProd.Name = "txtDescProd";
            this.txtDescProd.Size = new System.Drawing.Size(608, 25);
            this.txtDescProd.TabIndex = 13;
            // 
            // txtCdProduto
            // 
            this.txtCdProduto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCdProduto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCdProduto.Location = new System.Drawing.Point(16, 35);
            this.txtCdProduto.Name = "txtCdProduto";
            this.txtCdProduto.Size = new System.Drawing.Size(100, 25);
            this.txtCdProduto.TabIndex = 12;
            // 
            // dgvPedidoItens
            // 
            this.dgvPedidoItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoItens.Location = new System.Drawing.Point(6, 66);
            this.dgvPedidoItens.Name = "dgvPedidoItens";
            this.dgvPedidoItens.Size = new System.Drawing.Size(953, 313);
            this.dgvPedidoItens.TabIndex = 11;
            // 
            // PedidoItemView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbItens);
            this.Controls.Add(this.tsPedidoItem);
            this.Name = "PedidoItemView";
            this.Size = new System.Drawing.Size(971, 413);
            this.tsPedidoItem.ResumeLayout(false);
            this.tsPedidoItem.PerformLayout();
            this.gbItens.ResumeLayout(false);
            this.gbItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton btnExcluirItem;
        private System.Windows.Forms.ToolStrip tsPedidoItem;
        private System.Windows.Forms.GroupBox gbItens;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblCdProd;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.TextBox txtDescProd;
        private System.Windows.Forms.TextBox txtCdProduto;
        private System.Windows.Forms.DataGridView dgvPedidoItens;
        private System.Windows.Forms.ToolStripButton btnSalvar;
    }
}
