namespace IntegracaoDevApp.Views
{
    partial class PedidoWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PedidoWindow));
            this.bnPedidos = new System.Windows.Forms.BindingNavigator(this.components);
            this.bnPedidoCreate = new System.Windows.Forms.ToolStripButton();
            this.bnPedidoDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bnPedidoSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bnDeletePedido = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cdCliente = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bnPedidos)).BeginInit();
            this.bnPedidos.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnPedidos
            // 
            this.bnPedidos.AddNewItem = this.bnPedidoCreate;
            this.bnPedidos.CountItem = null;
            this.bnPedidos.DeleteItem = this.bnPedidoDeleteItem;
            this.bnPedidos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bnPedidoCreate,
            this.bnPedidoSaveItem,
            this.bnPedidoDeleteItem,
            this.bnDeletePedido});
            this.bnPedidos.Location = new System.Drawing.Point(0, 0);
            this.bnPedidos.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnPedidos.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnPedidos.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnPedidos.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnPedidos.Name = "bnPedidos";
            this.bnPedidos.PositionItem = this.bindingNavigatorPositionItem;
            this.bnPedidos.Size = new System.Drawing.Size(914, 25);
            this.bnPedidos.TabIndex = 0;
            this.bnPedidos.Text = "Navegacao";
            // 
            // bnPedidoCreate
            // 
            this.bnPedidoCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnPedidoCreate.Image = ((System.Drawing.Image)(resources.GetObject("bnPedidoCreate.Image")));
            this.bnPedidoCreate.Name = "bnPedidoCreate";
            this.bnPedidoCreate.RightToLeftAutoMirrorImage = true;
            this.bnPedidoCreate.Size = new System.Drawing.Size(23, 22);
            this.bnPedidoCreate.Text = "Adicionar novo";
            // 
            // bnPedidoDeleteItem
            // 
            this.bnPedidoDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnPedidoDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bnPedidoDeleteItem.Image")));
            this.bnPedidoDeleteItem.Name = "bnPedidoDeleteItem";
            this.bnPedidoDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bnPedidoDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bnPedidoDeleteItem.Text = "Excluir";
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
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
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
            // bnPedidoSaveItem
            // 
            this.bnPedidoSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnPedidoSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bnPedidoSaveItem.Image")));
            this.bnPedidoSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnPedidoSaveItem.Name = "bnPedidoSaveItem";
            this.bnPedidoSaveItem.Size = new System.Drawing.Size(23, 22);
            this.bnPedidoSaveItem.Text = "toolStripButton1";
            // 
            // bnDeletePedido
            // 
            this.bnDeletePedido.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bnDeletePedido.Image = ((System.Drawing.Image)(resources.GetObject("bnDeletePedido.Image")));
            this.bnDeletePedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bnDeletePedido.Name = "bnDeletePedido";
            this.bnDeletePedido.Size = new System.Drawing.Size(23, 22);
            this.bnDeletePedido.Text = "Excluir";
            this.bnDeletePedido.ToolTipText = "Excluir";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.962264F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.03773F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 690F));
            this.tableLayoutPanel1.Controls.Add(this.cdCliente, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.360444F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.63956F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(902, 541);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // cdCliente
            // 
            this.cdCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cdCliente.Location = new System.Drawing.Point(22, 3);
            this.cdCliente.Name = "cdCliente";
            this.cdCliente.Size = new System.Drawing.Size(124, 26);
            this.cdCliente.TabIndex = 0;
            // 
            // PedidoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 595);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.bnPedidos);
            this.Name = "PedidoWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.bnPedidos)).EndInit();
            this.bnPedidos.ResumeLayout(false);
            this.bnPedidos.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnPedidos;
        private System.Windows.Forms.ToolStripButton bnPedidoCreate;
        private System.Windows.Forms.ToolStripButton bnPedidoDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bnPedidoSaveItem;
        private System.Windows.Forms.ToolStripButton bnDeletePedido;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox cdCliente;
    }
}