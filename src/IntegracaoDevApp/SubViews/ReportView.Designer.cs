namespace IntegracaoDevApp.SubViews
{
    partial class ReportView
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
            this.chkExibirItens = new System.Windows.Forms.CheckBox();
            this.pnSystemParameters.SuspendLayout();
            this.tpSystemParameters.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSystemParameters
            // 
            this.pnSystemParameters.Controls.Add(this.chkExibirItens);
            // 
            // chkExibirItens
            // 
            this.chkExibirItens.AutoSize = true;
            this.chkExibirItens.Location = new System.Drawing.Point(-35, 42);
            this.chkExibirItens.Name = "chkExibirItens";
            this.chkExibirItens.Size = new System.Drawing.Size(80, 17);
            this.chkExibirItens.TabIndex = 0;
            this.chkExibirItens.Text = "checkBox1";
            this.chkExibirItens.UseVisualStyleBackColor = true;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "ReportView";
            this.pnSystemParameters.ResumeLayout(false);
            this.pnSystemParameters.PerformLayout();
            this.tpSystemParameters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkExibirItens;
    }
}
