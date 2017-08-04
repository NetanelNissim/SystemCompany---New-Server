using System;
using System.Data;
using System.Windows.Forms;

namespace SystemCustomers.ManageProjectToCustomers
{
    public partial class ManageReportCompany : Form
    {
        public ManageReportCompany()
        {
            InitializeComponent();
            InitializeDataGridListCompany();
        }
        private void InitializeDataGridListCompany()
        {
           // datagListCompany.DataSource = SingletonManagerDb.Instance.DbViewingCustomersIdAndName();
        }

        private void ManageReportCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                this.Dispose();
                this.Close();
                GC.Collect();
            }
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            //if (datagListCompany.SelectedRows.Count != 1) return;
            //using (DataGridViewRow dr = datagListCompany.SelectedRows[0])
            //{
            //    string companyId = dr.Cells["idcust"].Value.ToString();
            //    var company = new DataTable();
            //    company = SingletonManagerDb.Instance.DbViewingRelationCompany(companyId);
            //    using (DataGridView dataGridListCompany = new DataGridView())
            //    {
            //        dataGridListCompany.Visible = false;
            //        dataGridListCompany.DataSource = company;
                    //Microsoft.Office.Interop.Word.Application wordApp = null;
                    //wordApp = new Microsoft.Office.Interop.Word.Application();
                    //wordApp.Documents.add(company);
                    //wordApp.ActiveDocument.ExportAsFixedFormat("", Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF);

                    //Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                    //app.Visible = false;
                    //app.UserControl = true;

                    //Microsoft.Office.Interop.Word.Words wb;
                    //wb = app.Workbook.Add(Type.Missing);
                    //Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets.get_Item(1);



                }


            }

           
            //try
            //{
               
            //}
            //finally
            //{
            //    if (wordApp != null)
            //        wordApp.Quit();
            //}
    
}
