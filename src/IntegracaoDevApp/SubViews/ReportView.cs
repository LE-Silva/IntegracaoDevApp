using dpLibrary05.Infrastructure.UserControls;
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
    public partial class ReportView : ucSymGen_ReportDialog
    {
        public ReportView()
        {
            InitializeComponent();
        }

        private void OnConfiguration()
        {
            this.BeforeLoadReport += OnBeforeLoadReport;
        }
        private void OnBeforeLoadReport(object sender, BeforeLoadReportEventArgs e)
        {
            try
            {
                var parametro = chkExibirItens.Checked;
                e.Parameter.Items.Add(nameof(parametro), parametro);
            }
            catch (Exception ex)
            {
                e.CancelMessage = ex.Message;
                e.Cancel = true;
                e.CancelReason = ReportStateEnum.Err;
                return;
            }
        }
    }
}
