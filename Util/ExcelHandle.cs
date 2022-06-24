using Syncfusion.XlsIO;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace TE11Manager.Util
{
    public static class ExcelHandle
    {
        public static void ExportExcelByDataTable(DataTable dataGridView, bool isOpenAfterCreate, string outputString = "Output.xlsx")
        {
            try
            {
                using (ExcelEngine excelEngine = new ExcelEngine())
                {
                    IApplication application = excelEngine.Excel;
                    IWorkbook workbook = application.Workbooks.Create(1);
                    IWorksheet worksheet = workbook.Worksheets[0];

                    worksheet.ImportDataTable(dataGridView,true, 1, 1);
                    worksheet.UsedRange.AutofitColumns();
                    Stream excelFile = new FileStream(outputString,FileMode.OpenOrCreate);
                    workbook.SaveAs(excelFile);
                    excelFile.Dispose();
                    if (isOpenAfterCreate)
                    {
                        Process.Start(outputString);
                    }
                }
            }catch(Exception e)
            {
                MessageBox.Show("Export data failed");
            }
        }
    }
}
