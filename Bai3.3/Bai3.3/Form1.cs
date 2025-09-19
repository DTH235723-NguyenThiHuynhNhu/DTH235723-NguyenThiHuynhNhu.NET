using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool NamNhuan(int year)
        {
            return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0));
        }
        private void btnKiemTra_Click(object sender, EventArgs e)
        {
            try
            {
                int ngay = int.Parse(txtNgay.Text);
                int thang = int.Parse(txtThang.Text);
                int nam = int.Parse(txtNam.Text);

                int maxNgay;

                switch (thang)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        maxNgay = 31;
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        maxNgay = 30;
                        break;
                    case 2:
                        maxNgay = NamNhuan(nam) ? 29 : 28;
                        break;
                    default:
                        MessageBox.Show("Ngày KHÔNG hợp lệ!", "Thông báo");
                        return;
                }

                if (ngay >= 1 && ngay <= maxNgay)
                    MessageBox.Show("Ngày hợp lệ!", "Thông báo");
                else
                    MessageBox.Show("Ngày KHÔNG hợp lệ!", "Thông báo");
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!", "Lỗi");
            }
        }
    }
}
