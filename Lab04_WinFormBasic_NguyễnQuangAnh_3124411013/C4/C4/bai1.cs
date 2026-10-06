using System;
using System.Globalization;
using System.Windows.Forms;

namespace C4
{
    public partial class bai1 : Form
    {
        public bai1()
        {
            InitializeComponent();
        }

        // ================== MỨC 2: CHẶN KÝ TỰ KHÔNG PHẢI SỐ ==================
        private void TxtSo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            char c = e.KeyChar;
            string dauThapPhan = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;

            // Cho phép phím điều khiển (Backspace, Ctrl+C, Ctrl+V...) và chữ số
            if (char.IsControl(c) || char.IsDigit(c))
                return;

            // Dấu '-' chỉ được ở đầu và chỉ một lần
            if (c == '-')
            {
                if (tb.SelectionStart == 0 && !tb.Text.Contains("-"))
                    return;
                e.Handled = true;
                return;
            }

            // Dấu thập phân: chỉ một lần
            if (c.ToString() == dauThapPhan)
            {
                if (!tb.Text.Contains(dauThapPhan))
                    return;
                e.Handled = true;
                return;
            }

            // Các ký tự còn lại: chặn
            e.Handled = true;
        }

        // ================== MỨC 1: ERRORPROVIDER ==================
        private bool KiemTraSo(TextBox tb, string ten)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                errorProvider1.SetError(tb, "Vui lòng nhập số " + ten + "!");
                return false;
            }
            if (!double.TryParse(tb.Text, NumberStyles.Float, CultureInfo.CurrentCulture, out _))
            {
                errorProvider1.SetError(tb, "Số " + ten + " không hợp lệ!");
                return false;
            }
            errorProvider1.SetError(tb, "");
            return true;
        }

        private void TxtSo_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            KiemTraSo(tb, tb == txtA ? "a" : "b");
        }

        private void TxtSo_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            KiemTraSo(tb, tb == txtA ? "a" : "b");
        }

        // ================== TÍNH TOÁN ==================
        private void BtnPhepToan_Click(object sender, EventArgs e)
        {
            bool hopLeA = KiemTraSo(txtA, "a");
            bool hopLeB = KiemTraSo(txtB, "b");

            if (!hopLeA)
            {
                MessageBox.Show("Dữ liệu số a không hợp lệ! Vui lòng nhập lại.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus();
                return;
            }
            if (!hopLeB)
            {
                MessageBox.Show("Dữ liệu số b không hợp lệ! Vui lòng nhập lại.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus();
                return;
            }

            double a = double.Parse(txtA.Text, CultureInfo.CurrentCulture);
            double b = double.Parse(txtB.Text, CultureInfo.CurrentCulture);
            double kq;

            Button btn = (Button)sender;
            if (btn == btnCong) kq = a + b;
            else if (btn == btnTru) kq = a - b;
            else if (btn == btnNhan) kq = a * b;
            else
            {
                if (b == 0)
                {
                    MessageBox.Show("Không thể chia cho 0!",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtB.Focus();
                    txtB.SelectAll();
                    return;
                }
                kq = a / b;
            }

            txtKQ.Text = kq.ToString(CultureInfo.CurrentCulture);
        }

        // ================== HỎI XÁC NHẬN KHI ĐÓNG FORM ==================
        private void bai1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình?",
                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void lblB_Click(object sender, EventArgs e)
        {

        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblKQ_Click(object sender, EventArgs e)
        {

        }

        private void bai1_Load(object sender, EventArgs e)
        {

        }
    }
}