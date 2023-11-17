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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoView));
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bnNumPedido = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtpDtFechamento = new System.Windows.Forms.DateTimePicker();
            this.dtpDtAbertura = new System.Windows.Forms.DateTimePicker();
            this.lblDtFechamento = new System.Windows.Forms.Label();
            this.lblDtAbertura = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblClienteNome = new System.Windows.Forms.Label();
            this.txtCdCliente = new System.Windows.Forms.TextBox();
            this.lblcdCliente = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.txtStatusPedido = new System.Windows.Forms.TextBox();
            this.tbPedidoItens = new System.Windows.Forms.TabControl();
            this.tpItens = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvPedidoItens = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbPedidoItens.SuspendLayout();
            this.tpItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoItens)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bnNumPedido,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bnNumPedido;
            this.bindingNavigator1.Size = new System.Drawing.Size(868, 25);
            this.bindingNavigator1.TabIndex = 0;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bnNumPedido
            // 
            this.bnNumPedido.AccessibleName = "Posição";
            this.bnNumPedido.AutoSize = false;
            this.bnNumPedido.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bnNumPedido.Name = "bnNumPedido";
            this.bnNumPedido.Size = new System.Drawing.Size(50, 23);
            this.bnNumPedido.Text = "0";
            this.bnNumPedido.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 135F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.07663F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 112F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.Controls.Add(this.dtpDtFechamento, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpDtAbertura, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDtFechamento, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDtAbertura, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblStatus, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblClienteNome, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCdCliente, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblcdCliente, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNomeCliente, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtStatusPedido, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbPedidoItens, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.30855F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 429F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(844, 506);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // dtpDtFechamento
            // 
            this.dtpDtFechamento.Enabled = false;
            this.dtpDtFechamento.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpDtFechamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtFechamento.Location = new System.Drawing.Point(728, 21);
            this.dtpDtFechamento.Name = "dtpDtFechamento";
            this.dtpDtFechamento.Size = new System.Drawing.Size(105, 26);
            this.dtpDtFechamento.TabIndex = 32;
            this.dtpDtFechamento.Value = new System.DateTime(2023, 10, 14, 22, 8, 39, 0);
            // 
            // dtpDtAbertura
            // 
            this.dtpDtAbertura.Enabled = false;
            this.dtpDtAbertura.Font = new System.Drawing.Font("Arial Narrow", 12F);
            this.dtpDtAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtAbertura.Location = new System.Drawing.Point(616, 21);
            this.dtpDtAbertura.Name = "dtpDtAbertura";
            this.dtpDtAbertura.Size = new System.Drawing.Size(105, 26);
            this.dtpDtAbertura.TabIndex = 31;
            this.dtpDtAbertura.Value = new System.DateTime(2023, 10, 14, 22, 8, 39, 0);
            // 
            // lblDtFechamento
            // 
            this.lblDtFechamento.AutoSize = true;
            this.lblDtFechamento.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDtFechamento.Location = new System.Drawing.Point(728, 0);
            this.lblDtFechamento.Name = "lblDtFechamento";
            this.lblDtFechamento.Size = new System.Drawing.Size(79, 16);
            this.lblDtFechamento.TabIndex = 30;
            this.lblDtFechamento.Text = "Fechamento";
            // 
            // lblDtAbertura
            // 
            this.lblDtAbertura.AutoSize = true;
            this.lblDtAbertura.Font = new System.Drawing.Font("Arial", 9.75F);
            this.lblDtAbertura.Location = new System.Drawing.Point(616, 0);
            this.lblDtAbertura.Name = "lblDtAbertura";
            this.lblDtAbertura.Size = new System.Drawing.Size(56, 16);
            this.lblDtAbertura.TabIndex = 29;
            this.lblDtAbertura.Text = "Abertura";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(511, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 16);
            this.lblStatus.TabIndex = 27;
            this.lblStatus.Text = "Status";
            // 
            // lblClienteNome
            // 
            this.lblClienteNome.AutoSize = true;
            this.lblClienteNome.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClienteNome.Location = new System.Drawing.Point(138, 0);
            this.lblClienteNome.Name = "lblClienteNome";
            this.lblClienteNome.Size = new System.Drawing.Size(109, 16);
            this.lblClienteNome.TabIndex = 2;
            this.lblClienteNome.Text = "Código do Cliente";
            // 
            // txtCdCliente
            // 
            this.txtCdCliente.Enabled = false;
            this.txtCdCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCdCliente.Location = new System.Drawing.Point(3, 21);
            this.txtCdCliente.Name = "txtCdCliente";
            this.txtCdCliente.Size = new System.Drawing.Size(129, 26);
            this.txtCdCliente.TabIndex = 0;
            // 
            // lblcdCliente
            // 
            this.lblcdCliente.AutoSize = true;
            this.lblcdCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcdCliente.Location = new System.Drawing.Point(3, 0);
            this.lblcdCliente.Name = "lblcdCliente";
            this.lblcdCliente.Size = new System.Drawing.Size(109, 16);
            this.lblcdCliente.TabIndex = 1;
            this.lblcdCliente.Text = "Código do Cliente";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.Location = new System.Drawing.Point(138, 21);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(366, 26);
            this.txtNomeCliente.TabIndex = 3;
            // 
            // txtStatusPedido
            // 
            this.txtStatusPedido.Enabled = false;
            this.txtStatusPedido.Font = new System.Drawing.Font("Arial", 12F);
            this.txtStatusPedido.Location = new System.Drawing.Point(511, 21);
            this.txtStatusPedido.Name = "txtStatusPedido";
            this.txtStatusPedido.Size = new System.Drawing.Size(99, 26);
            this.txtStatusPedido.TabIndex = 26;
            // 
            // tbPedidoItens
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbPedidoItens, 5);
            this.tbPedidoItens.Controls.Add(this.tpItens);
            this.tbPedidoItens.Controls.Add(this.tabPage2);
            this.tbPedidoItens.Enabled = false;
            this.tbPedidoItens.Location = new System.Drawing.Point(3, 60);
            this.tbPedidoItens.Name = "tbPedidoItens";
            this.tbPedidoItens.SelectedIndex = 0;
            this.tbPedidoItens.Size = new System.Drawing.Size(838, 423);
            this.tbPedidoItens.TabIndex = 33;
            // 
            // tpItens
            // 
            this.tpItens.Controls.Add(this.toolStrip1);
            this.tpItens.Controls.Add(this.dgvPedidoItens);
            this.tpItens.Location = new System.Drawing.Point(4, 22);
            this.tpItens.Name = "tpItens";
            this.tpItens.Padding = new System.Windows.Forms.Padding(3);
            this.tpItens.Size = new System.Drawing.Size(830, 397);
            this.tpItens.TabIndex = 0;
            this.tpItens.Text = "Itens";
            this.tpItens.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(3, 3);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(824, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvPedidoItens
            // 
            this.dgvPedidoItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedidoItens.Location = new System.Drawing.Point(3, 3);
            this.dgvPedidoItens.Name = "dgvPedidoItens";
            this.dgvPedidoItens.Size = new System.Drawing.Size(824, 391);
            this.dgvPedidoItens.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(830, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Totais";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // PedidoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 556);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PedidoView";
            this.Text = "PedidoView";
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tbPedidoItens.ResumeLayout(false);
            this.tpItens.ResumeLayout(false);
            this.tpItens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedidoItens)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bnNumPedido;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtCdCliente;
        private System.Windows.Forms.Label lblcdCliente;
        private System.Windows.Forms.Label lblClienteNome;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtStatusPedido;
        private System.Windows.Forms.DateTimePicker dtpDtFechamento;
        private System.Windows.Forms.DateTimePicker dtpDtAbertura;
        private System.Windows.Forms.Label lblDtFechamento;
        private System.Windows.Forms.Label lblDtAbertura;
        private System.Windows.Forms.TabControl tbPedidoItens;
        private System.Windows.Forms.TabPage tpItens;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgvPedidoItens;
    }
}