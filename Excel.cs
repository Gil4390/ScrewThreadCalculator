using Microsoft.Office.Interop.Excel;
using System;
using _Excel = Microsoft.Office.Interop.Excel;

namespace Thread_Calculator
{
    class Excel
    {
        string path;
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Excel(string path, int sheet)
        {
            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = (Worksheet)wb.Worksheets[sheet];
        }

        public string ReadCell(int row, int col)
        {
            try
            {
                _Excel.Range range = (_Excel.Range)ws.Cells[row, col];
                string cellValue = range.Value.ToString();
                if (cellValue != "")
                    return cellValue;
                else return "";
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public void Close()
        {
            wb.Close(false);
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
        }
    }
}
