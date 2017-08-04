using System;
using System.Collections;
using System.Diagnostics;
//using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace SystemCustomers
{
  public class ExportToExcel
    {
        private string FileName { get; set; }

        private string Path { get; set; }

        private string Name { get; set; }

        private System.Data.DataTable Dt { get; set; }

        public ExportToExcel(string path , string fileName,System.Data.DataTable dt)
        {
            this.FileName = fileName;
            this.Path = path;
            this.Dt = dt;

            var t = new Thread(SwichCaseExport);
            t.Start();
         //  this.Name =  t.Name = "Nati" ;
        }

        private void SwichCaseExport()
        {
            switch (FileName)
            {
                case "List_Customer.xlsx":
                    ExportToExcelListCustomers();
                    break;
                case "List_Service_Customers.xlsx":
                    ExportToExcelListServiceToCustomers();
                    break;
                case "List_Service_Call.xlsx":
                    ExportServiceCall();
                    break;
                case "List_Project_Company.xlsx":
                    ExportProjectCustomers();
                    break;
            }
        }

        private void ExportProjectCustomers()
        {
            // get process ids before running the excel codes
            CheckExcellProcesses();

            var app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;
            app.UserControl = true;
            Workbook wb = app.Workbooks.Add(Type.Missing);
            var ws = (Worksheet)wb.Worksheets.Item[1];
            try
            {
                // changing the name of active sheet 
                ws.Name = "List Project Customers";

                for (int i = 1; i < 9; i++)
                {
                    ws.Cells[1, i].Font.Size = 14;
                    ws.Cells[1, i].Font.Bold = true;
                    ws.Cells[1, i].Font.Underline = true;
                    ws.Cells[1, i].Font.Color = Color.Red;
                }
                // Set Background Picture 
               // ws.SetBackgroundPicture("D:\\Project VS 2012\\SystemCompany\\SystemCustomers\\bin\\Debug\\DataFiles\\55\\12\\DSC_0195.JPG");

                ws.Cells[1, 1] = "שם חברה";
                ws.Cells[1, 2] = "שם פרויקט";
                ws.Cells[1, 3] = "תאריך התחלת פרויקט";
                ws.Cells[1, 4] = "תאריך סיום פרויקט";
                ws.Cells[1, 5] = "פריסת תשלום";
                ws.Cells[1, 6] = "סטטוס תשלום";
                ws.Cells[1, 7] = "הערות";
                ws.Cells[1, 8] = "קובץ פרטי פרויקט";

                for (int i = 2; i <= Dt.Columns.Count -1 ; i++)
                {
                    for (int j = 0, j2 = 1; j < Dt.Rows.Count; j++, j2++)
                    {
                        ws.Cells[j2 + 1, i - 1] = Dt.Rows[j][i].ToString();
                    }
                }

                // save the application
                wb.SaveAs(Path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageUtils.LogUtils.WriteToLog(" Export File Successful The file name: "+ System.IO.Path.GetFileName(this.Path));
                MessageUtils.LogUtils.SystemEventLogsInformation(" Export File Successful The file name: "+ System.IO.Path.GetFileName(this.Path) );
            }
            catch
            {

            }
            finally
            {
               wb.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                app.Quit();

                releaseObject(ws);
                releaseObject(wb);
                releaseObject(app);

                GC.GetTotalMemory(false);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.GetTotalMemory(true);

                // kill the right process after export completed
                KillExcel();
            }
           if(DialogResult.Yes == new MessageUtils.MessageBoxText("Do you want to open this file?  ", "Open Excel File").YesorNoMessageBox()) OpenFileFromDataGrid();
        }

        private void OpenFileFromDataGrid()
        {
            Process.Start(this.Path);
        }

        private void ExportServiceCall()
        {
            // get process ids before running the excel codes
            CheckExcellProcesses();

            var app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;
            app.UserControl = true;
            Workbook wb = app.Workbooks.Add(Type.Missing);
            var ws = (Worksheet)wb.Worksheets.Item[1];
            try
            {
                // changing the name of active sheet 
                ws.Name = "List Service Call";

                for (int i = 1; i < 5; i++)
                {
                    ws.Cells[1, i].Font.Size = 14;
                    ws.Cells[1, i].Font.Bold = true;
                    ws.Cells[1, i].Font.Underline = true;
                }

                ws.Cells[1, 1] = "שם חברה";
                ws.Cells[1, 2] = "תאריך פתיחת קריאה";
                ws.Cells[1, 3] = "עדיפות";
                ws.Cells[1, 4] = "תאור";

                for (int i = 3; i <= Dt.Columns.Count - 1; i++)
                {
                    for (int j = 0, j2 = 1; j < Dt.Rows.Count; j++, j2++)
                    {
                        ws.Cells[j2 + 1, i - 2] = Dt.Rows[j][i].ToString();
                    }
                }

                // save the application 
                wb.SaveAs(Path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageUtils.LogUtils.WriteToLog(" Export File Successful ");
                MessageUtils.LogUtils.SystemEventLogsInformation(" Export File Successful ");
            }
            catch
            {

            }
            finally
            {
                wb.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                app.Quit();

                releaseObject(ws);
                releaseObject(wb);
                releaseObject(app);

                GC.GetTotalMemory(false);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.GetTotalMemory(true);

                // kill the right process after export completed
                KillExcel();
            }
            if (DialogResult.Yes == new MessageUtils.MessageBoxText("Do you want to open this file?  ", "Open Excel File").YesorNoMessageBox()) OpenFileFromDataGrid();

        }

        private void ExportToExcelListServiceToCustomers()
        {
            // get process ids before running the excel codes
            CheckExcellProcesses();

            var app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;
            app.UserControl = true;
            Workbook wb = app.Workbooks.Add(Type.Missing);
            var ws = (Worksheet) wb.Worksheets.Item[1];
            try
            {
                // changing the name of active sheet 
                ws.Name = "List Service To Customer";

                for (int i = 1; i < 8; i++)
                {
                    ws.Cells[1, i].Font.Size = 14;
                    ws.Cells[1, i].Font.Bold = true;
                    ws.Cells[1, i].Font.Underline = true;
                    ws.Cells[1, i].Font.Color = Color.Red;
                }

                ws.Cells[1, 1] = "שם חברה";
                ws.Cells[1, 2] = "סוג שרות";
                ws.Cells[1, 3] = "תאריך תחילת שרות";
                ws.Cells[1, 4] = "תאריך סיום שרות";
                ws.Cells[1, 5] = "מחיר";
                ws.Cells[1, 6] = "מחיר עלות";
                ws.Cells[1, 7] = "מצב תשלום";
                for (int i = 3; i <= Dt.Columns.Count - 1; i++)
                {
                    for (int j = 0, j2 = 1; j < Dt.Rows.Count; j++, j2++)
                    {
                        ws.Cells[j2 + 1, i - 2] = Dt.Rows[j][i].ToString();
                    }
                }

                // save the application 
                wb.SaveAs(Path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageUtils.LogUtils.WriteToLog(" Export File Successful ");
                MessageUtils.LogUtils.SystemEventLogsInformation(" Export File Successful ");
            }
            catch
            {

            }
            finally
            {
                wb.Close(false, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                app.Quit();

                releaseObject(ws);
                releaseObject(wb);
                releaseObject(app);

                GC.GetTotalMemory(false);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.GetTotalMemory(true);

                // kill the right process after export completed
                KillExcel();
            }
            if (DialogResult.Yes == new MessageUtils.MessageBoxText("Do you want to open this file?  ", "Open Excel File").YesorNoMessageBox()) OpenFileFromDataGrid();

        }

        private void ExportToExcelListCustomers()
        {
            // get process ids before running the excel codes
            CheckExcellProcesses();

            var app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = false;
            app.UserControl = true;

            Workbook wb = app.Workbooks.Add(Type.Missing);
            var ws = (Worksheet)wb.Worksheets.Item[1];
            try
            {
                // changing the name of active sheet 
                ws.Name = "List Customer";

                for (int i = 1; i <= 12; i++)
                {
                    ws.Cells[1, i].Font.Size = 14;
                    ws.Cells[1, i].Font.Bold = true;
                    ws.Cells[1, i].Font.Underline = true;
                }

                /*  "שם חברה";
           "שם נציג חברה";
           "טלפון נייד";
           "דואר אלקטרוני";
           "מספר טלפון";
           "תנאי תשלום"
           "פקס";
           "מספר ח,פ";
           "כתובת";
           "עיר";
           "מיקוד";
           "תא דואר";*/

                ws.Cells[1, 1] = "שם חברה";
                ws.Cells[1, 2] = "שם נציג חברה";
                ws.Cells[1, 3] = "טלפון נייד";
                ws.Cells[1, 4] = "דואר אלקטרוני";
                ws.Cells[1, 5] = "מספר טלפון";
                ws.Cells[1, 6] = "תנאי תשלום";
                ws.Cells[1, 7] = "פקס";
                ws.Cells[1, 8] = "מספר ח,פ";
                ws.Cells[1, 9] = "כתובת";
                ws.Cells[1, 10] = "עיר";
                ws.Cells[1, 11] = "מיקוד";
                ws.Cells[1, 12] = "תא דואר";


                for (int  i = 0; i <= Dt.Columns.Count - 2; i++)
                {
                    for (int j = 0,j2=1; j <  Dt.Rows.Count ; j++,j2++)
                    {
                        ws.Cells[j2 + 1, i+1] = Dt.Rows[j][i].ToString();
                    }
                }

                // save the application 
                wb.SaveAs(this.Path, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                          XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                MessageUtils.LogUtils.WriteToLog(" Export File Successful ");
                MessageUtils.LogUtils.SystemEventLogsInformation(" Export File Successful ");
            }
            catch
            {

            }
            finally
            {
                wb.Close(true, System.Reflection.Missing.Value, System.Reflection.Missing.Value);
                app.Workbooks.Close();
                app.Quit();

                releaseObject(ws);
                releaseObject(wb);
                releaseObject(app);

                GC.GetTotalMemory(false);
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.GetTotalMemory(true);

                // kill the right process after export completed
                KillExcel();
            }
            if (DialogResult.Yes == new MessageUtils.MessageBoxText("Do you want to open this file?  ", "Open Excel File").YesorNoMessageBox()) OpenFileFromDataGrid();

        }

        Hashtable myHashtable;

        private void KillExcel()
        {
            Process[] AllProcesses = Process.GetProcessesByName("excel");

            // check to kill the right process
            foreach (Process ExcelProcess in AllProcesses)
            {
                if (myHashtable.ContainsKey(ExcelProcess.Id) == false)
                    ExcelProcess.Kill();
            }

            AllProcesses = null;
        }

        private void CheckExcellProcesses()
        {
            Process[] AllProcesses = Process.GetProcessesByName("excel");
            myHashtable = new Hashtable();
            int iCount = 0;

            foreach (Process ExcelProcess in AllProcesses)
            {
                myHashtable.Add(ExcelProcess.Id, iCount);
                iCount = iCount + 1;
            }
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
            }
            finally
            {
                GC.Collect();
            }
        }

    }
}
