using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Security.Policy;
using System.Windows.Forms;

namespace QKKS_ver_1._4_.DAL
{
    public class Revenue
    {
        private string connect = "SERVER= LAPTOP-7LH8BA5I\\MSSQLSERVER01; database = QLKS(new); integrated Security = True ";
         public string sum(string start,string end)
          {
              string id;
                  using (SqlConnection con = new SqlConnection())
                  {
                        con.ConnectionString = connect;
                         con.Open();
                        string sql = "exec dbo.sumRevenue @start='"+start+"',@end='"+end+"'";
                        SqlCommand cmd = new SqlCommand(sql,con);
                        id=cmd.ExecuteScalar().ToString();  
                        
                        con.Close();
                  }
              return id;
              }

        public void ExportRevenue(DataTable dataTable, string sheetName, string title)
        {
            Microsoft.Office.Interop.Excel.Application Excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbooks Books;
            Microsoft.Office.Interop.Excel.Workbook Book;
            Microsoft.Office.Interop.Excel.Sheets sheets;
            Microsoft.Office.Interop.Excel.Worksheet sheet;

            Excel.Visible = true;
            Excel.DisplayAlerts = false;
            Excel.Application.SheetsInNewWorkbook = 1;
            Books = Excel.Workbooks;
            Book = (Microsoft.Office.Interop.Excel.Workbook)(Excel.Workbooks.Add(Type.Missing));
            sheets = Book.Worksheets;
            sheet = (Microsoft.Office.Interop.Excel.Worksheet)sheets.get_Item(1);
            sheet.Name = sheetName;

            Microsoft.Office.Interop.Excel.Range head = sheet.get_Range("A1", "E1");
            head.MergeCells = true;
            head.Value2 = title;
            head.Font.Bold = true;
            head.Font.Name = "Times New Roman";
            head.Font.Size = "16";
            head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

            Microsoft.Office.Interop.Excel.Range c11 = sheet.get_Range("A3", "A3");
            c11.Value2 = "Số Bill";
            c11.ColumnWidth = 5;

            Microsoft.Office.Interop.Excel.Range c12 = sheet.get_Range("B3", "B3");
            c12.Value2 = "Tổng Tiền";
            c12.ColumnWidth = 20.5;

            Microsoft.Office.Interop.Excel.Range c13 = sheet.get_Range("C3", "C3");
            c13.Value2 = "Khách Hàng";
            c13.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range c14 = sheet.get_Range("D3", "D3");
            c14.Value2 = "Nhân Viên Lập";
            c14.ColumnWidth = 20;

            Microsoft.Office.Interop.Excel.Range c15 = sheet.get_Range("E3", "E3");
            c15.Value2 = "Ngày Lập";
            c15.ColumnWidth = 20;




            Microsoft.Office.Interop.Excel.Range rowHead = sheet.get_Range("A3", "E3");
            rowHead.Font.Bold = true;
            rowHead.Interior.ColorIndex = 6;
            rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;



            object[,] arr = new object[dataTable.Rows.Count, dataTable.Columns.Count];

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                DataRow row = dataTable.Rows[i];
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    arr[i, j] = row[j].ToString();
                }
            }

            int rowStart = 4;
            int colStart = 1;
            int rowEnd = rowStart + dataTable.Rows.Count - 1;
            int colEnd = dataTable.Columns.Count;

            Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[rowStart, colStart];
            Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)sheet.Cells[rowEnd, colEnd];

            Microsoft.Office.Interop.Excel.Range bot = sheet.get_Range("D"+(rowEnd+1), "D" + (rowEnd + 1));
            bot.Value2 = "Tổng Doanh Thu";
           
            bot.Font.Name = "Times New Roman";
            bot.Font.Size = "11";

            Microsoft.Office.Interop.Excel.Range bot2 = sheet.get_Range("E" + (rowEnd + 1), "E" + (rowEnd + 1));
            bot2.Value2 = "=sum(B4,B"+rowEnd+")";
         
            bot2.Font.Name = "Times New Roman";
            bot2.Font.Size = "11";


            Microsoft.Office.Interop.Excel.Range range = sheet.get_Range(c1, c2);
            range.Value2 = arr;
            range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;


        }

    }
}
