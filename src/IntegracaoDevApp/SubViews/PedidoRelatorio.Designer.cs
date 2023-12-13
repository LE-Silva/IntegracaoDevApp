namespace IntegracaoDevApp.SubViews
{
    partial class IntegracaoDevApp_RelatorioView
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
            this.chkExibeItens = new System.Windows.Forms.CheckBox();
            this.pnSystemParameters.SuspendLayout();
            this.tpSystemParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSystemParameters
            // 
            this.pnSystemParameters.Controls.Add(this.chkExibeItens);
            this.pnSystemParameters.Size = new System.Drawing.Size(794, 358);
            // 
            // tpSystemParameters
            // 
            this.tpSystemParameters.Size = new System.Drawing.Size(794, 358);
            // 
            // chkExibeItens
            // 
            this.chkExibeItens.AutoSize = true;
            this.chkExibeItens.Location = new System.Drawing.Point(31, 84);
            this.chkExibeItens.Name = "chkExibeItens";
            this.chkExibeItens.Size = new System.Drawing.Size(128, 17);
            this.chkExibeItens.TabIndex = 0;
            this.chkExibeItens.Text = "Exibir Itens do Pedido";
            this.chkExibeItens.UseVisualStyleBackColor = true;
            // 
            // IntegracaoDevApp_RelatorioView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "IntegracaoDevApp_RelatorioView";
            this.Size = new System.Drawing.Size(800, 450);
            this.pnSystemParameters.ResumeLayout(false);
            this.pnSystemParameters.PerformLayout();
            this.tpSystemParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkExibeItens;
    }
}