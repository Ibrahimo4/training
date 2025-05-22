using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;

using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace POSMainForm
{
    public partial class frmReportDailSalesByInvoice : Form
    {

        DateTime ReportDate;
        public frmReportDailSalesByInvoice(DateTime reportDate)
        {
            InitializeComponent();

            ReportDate = reportDate;
        }

        private void frmReportDailSalesByInvoice_Load(object sender, EventArgs e)
        {

            //this.reportViewer1.RefreshReport();
            LoadReport();
        }

        private void LoadReport()
        {
            try
            {
                SQLConn.sqL = "SELECT T.InvoiceNo, ProductCode, P.Description, REPLACE(TDate, '-', '/') as TDate, TTime,TD.ItemPrice, SUM(TD.Quantity) as totalQuantity, (TD.ItemPrice * SUM(TD.Quantity)) as TotalPrice  FROM Product as P, Transactions as T, TransactionDetails as TD WHERE P.ProductNo = TD.ProductNo AND TD.InvoiceNo = T.InvoiceNo AND  TDate = '" + ReportDate.ToString("MM/dd/yyyy") + "' GROUP BY T.InvoiceNo, P.ProductNo, TDate ORDER By TDate";
                SQLConn.ConnDB();
                SQLConn.cmd = new MySqlCommand(SQLConn.sqL, SQLConn.conn);
                SQLConn.da = new MySqlDataAdapter(SQLConn.cmd);

                this.dsReportC.DailySalesByInvoice.Clear();
                SQLConn.da.Fill(this.dsReportC.DailySalesByInvoice);

                this.reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                this.reportViewer1.ZoomPercent = 90;
                this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;

                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                Interaction.MsgBox(ex.ToString());
            }
        }
    }
}
