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
using app = Microsoft.Office.Interop.Excel.Application;

namespace DangVanPhuc_10121268_DA1_QLNH
{
    public partial class GUI_Thongkehoadonnhap : Form
    {
        public GUI_Thongkehoadonnhap()
        {
            InitializeComponent();
        }

        private void hDNhapBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hDNhapBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLNH_DA1_10121268_DVPDataSet);

        }

        private void GUI_Thongkehoadonnhap_Load(object sender, EventArgs e)
        {
            // TODO: Dòng mã này tải dữ liệu vào bảng 'qLNH_DA1_10121268_DVPDataSet.HDBan'. Bạn có thể di chuyển, hoặc gỡ bỏ nó, khi cần thiết.
            this.hDNhapTableAdapter.Fill(this.qLNH_DA1_10121268_DVPDataSet.HDNhap);

        }

        private void export2Excel(DataGridView g, string duongDan, string tenTap)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;//Đặt độ rộng của tất cả các cột trong ứng dụng thành 25
            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;//gán giá trị của HeaderText (tiêu đề) của cột tương ứng vào ô tương ứng trong workbook
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveCopyAs(duongDan + tenTap + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
        }

        private void XuấtfileExcel_Click(object sender, EventArgs e)
        {
            export2Excel(hDNhapDataGridView, @"D:\"," XuấtfileExcel");
        }
    }
}
