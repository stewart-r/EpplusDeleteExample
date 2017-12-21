using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpplusDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            var myFileInfo = new FileInfo("Demo.xlsx");
            using (var pack = new ExcelPackage(myFileInfo))
            {
                var ws = pack.Workbook.Worksheets.FirstOrDefault();
                ws.DeleteRow(1, 5, true);
                pack.SaveAs(new FileInfo("output.xlsx"));
            }
        }
    }
}
