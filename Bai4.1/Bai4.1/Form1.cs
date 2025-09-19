using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            {
                int n;
                if (!int.TryParse(txtN.Text, out n) || n <= 0)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên dương!");
                    return;
                }

                // Bài 4.1: S = 1 + 2 + ... + n
                int S1 = 0;
                for (int i = 1; i <= n; i++)
                    S1 += i;

                // Bài 4.2: S = 1^2 + 2^2 + ... + n^2
                int S2 = 0;
                for (int i = 1; i <= n; i++)
                    S2 += i * i;

                // Bài 4.3: S = 1 + 1/2 + ... + 1/n
                double S3 = 0;
                for (int i = 1; i <= n; i++)
                    S3 += 1.0 / i;

                // Bài 4.4: S = 1 + 3 + 5 + ... + (2n+1)
                int S4 = 0;
                for (int i = 0; i <= n; i++)
                    S4 += (2 * i + 1);

                // Bài 4.5: S = 2 + 4 + 6 + ... + 2n
                int S5 = 0;
                for (int i = 1; i <= n; i++)
                    S5 += 2 * i;

                // Bài 4.6: S = 1 + 1/3 + 1/5 + ... + 1/(2n-1)
                double S6 = 0;
                for (int i = 0; i < n; i++)
                    S6 += 1.0 / (2 * i + 1);

                // Bài 4.7: S = n!
                long S7 = 1;
                for (int i = 1; i <= n; i++)
                    S7 *= i;

                // Hiển thị kết quả
                txtS.Text =
                    "Bài 4.1: " + S1 +
                    "\r\nBài 4.2: " + S2 +
                    "\r\nBài 4.3: " + S3 +
                    "\r\nBài 4.4: " + S4 +
                    "\r\nBài 4.5: " + S5 +
                    "\r\nBài 4.6: " + S6 +
                    "\r\nBài 4.7: " + S7;
            }
        }
    }
}
