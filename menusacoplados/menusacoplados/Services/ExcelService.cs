using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
namespace menusacoplados.Services
{
    public class ExcelService
    {

        public ExcelService() { }
        public void CrearExcelApp(DataGridView dataGridView1)
        {
            Excel.Application excelApp = new Excel.Application();
             
            excelApp.Visible = true;
            excelApp.Workbooks.Add();

            Excel._Worksheet Hoja = (Excel.Worksheet)excelApp.ActiveSheet;
            Hoja.Name = "Hoja prueba";
            //exportar lo datos de un datagridview a excel

            foreach (DataGridViewColumn columna in dataGridView1.Columns)
            {
                Hoja.Cells[1, columna.Index + 1] = columna.HeaderText;
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    Hoja.Cells[fila.Index + 2, columna.Index + 1] = fila.Cells[columna.Index].Value;
                }
            }
        }
          
    }
}
