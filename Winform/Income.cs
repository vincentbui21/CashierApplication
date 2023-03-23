using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace Winform
{
    public partial class Income : Form
    {
        public Income()
        {
            InitializeComponent();
        }

        private void dgvIncome_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Import_btn_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application xlApp;
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorksheet;
            Microsoft.Office.Interop.Excel.Range xlRange;

            int xlRow;
            string strFileName;
            openFD.Filter = "Excel Office |*.xls; *xlsx";
            openFD.ShowDialog();
            strFileName = openFD.FileName;

            if (strFileName != "")
            {
                xlApp = new Microsoft.Office.Interop.Excel.Application();
                xlWorkbook = xlApp.Workbooks.Open(strFileName);
                xlWorksheet = xlWorkbook.Worksheets["Sheet1"];
                xlRange = xlWorksheet.UsedRange;

                int i = 0;
                for (xlRow = 2; xlRow <= xlRange.Rows.Count; xlRow++)
                {
                    i++;
                    dgvIncome.Rows.Add(i, xlRange.Cells[xlRow, 1].Text, xlRange.Cells[xlRow, 2].Text, xlRange.Cells[xlRow, 3].Text, xlRange.Cells[xlRow, 4].Text);
                }
                xlWorkbook.Close();
                xlApp.Quit();
            }
        }
    }
}
