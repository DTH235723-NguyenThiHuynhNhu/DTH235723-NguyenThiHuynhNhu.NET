using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(txtA.Text);
                double b = double.Parse(txtB.Text);
                double c = double.Parse(txtC.Text);
                string ketQua = "";

                if (a == 0)
                {
                    if (b == 0)
                    {
                        ketQua = (c == 0) ? "Phương trình vô số nghiệm"
                                          : "Phương trình vô nghiệm";
                    }
                    else
                    {
                        double x = -c / b;
                        ketQua = "Phương trình bậc nhất, nghiệm x = " + x;
                    }
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    if (delta < 0)
                    {
                        ketQua = "Phương trình vô nghiệm thực";
                    }
                    else if (delta == 0)
                    {
                        double x = -b / (2 * a);
                        ketQua = "Phương trình có nghiệm kép: x1 = x2 = " + x;
                    }
                    else
                    {
                        double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                        double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                        ketQua = "Phương trình có 2 nghiệm phân biệt:\r\n";
                        ketQua += "x1 = " + x1 + "\r\n";
                        ketQua += "x2 = " + x2;
                    }
                }

                txtKetQua.Text = ketQua;
            }
            catch
            {
                txtKetQua.Text = "Lỗi: vui lòng nhập đúng số!";
            }
        }
    }
}
