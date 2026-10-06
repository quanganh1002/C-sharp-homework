namespace C4
{
    partial class bai1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblA = new Label();
            lblB = new Label();
            lblKQ = new Label();
            txtA = new TextBox();
            txtB = new TextBox();
            txtKQ = new TextBox();
            btnCong = new Button();
            btnTru = new Button();
            btnNhan = new Button();
            btnChia = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(34, 35);
            lblA.Name = "lblA";
            lblA.Size = new Size(41, 20);
            lblA.TabIndex = 0;
            lblA.Text = "Số a:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(217, 35);
            lblB.Name = "lblB";
            lblB.Size = new Size(42, 20);
            lblB.TabIndex = 2;
            lblB.Text = "Số b:";
            lblB.Click += lblB_Click;
            // 
            // lblKQ
            // 
            lblKQ.AutoSize = true;
            lblKQ.Location = new Point(34, 78);
            lblKQ.Name = "lblKQ";
            lblKQ.Size = new Size(63, 20);
            lblKQ.TabIndex = 8;
            lblKQ.Text = "Kết quả:";
            lblKQ.Click += lblKQ_Click;
            // 
            // txtA
            // 
            txtA.AllowDrop = true;
            txtA.Location = new Point(124, 35);
            txtA.Margin = new Padding(3, 4, 3, 4);
            txtA.Name = "txtA";
            txtA.Size = new Size(87, 27);
            txtA.TabIndex = 1;
            txtA.TextChanged += TxtSo_TextChanged;
            txtA.KeyPress += TxtSo_KeyPress;
            txtA.Validating += TxtSo_Validating;
            // 
            // txtB
            // 
            txtB.AllowDrop = true;
            txtB.Location = new Point(290, 35);
            txtB.Margin = new Padding(3, 4, 3, 4);
            txtB.Name = "txtB";
            txtB.Size = new Size(87, 27);
            txtB.TabIndex = 3;
            txtB.TextChanged += TxtSo_TextChanged;
            txtB.KeyPress += TxtSo_KeyPress;
            txtB.Validating += TxtSo_Validating;
            // 
            // txtKQ
            // 
            txtKQ.AllowDrop = true;
            txtKQ.Location = new Point(124, 75);
            txtKQ.Margin = new Padding(3, 4, 3, 4);
            txtKQ.Name = "txtKQ";
            txtKQ.ReadOnly = true;
            txtKQ.Size = new Size(253, 27);
            txtKQ.TabIndex = 9;
            txtKQ.TextChanged += txtKQ_TextChanged;
            // 
            // btnCong
            // 
            btnCong.Location = new Point(34, 122);
            btnCong.Margin = new Padding(3, 4, 3, 4);
            btnCong.Name = "btnCong";
            btnCong.Size = new Size(80, 41);
            btnCong.TabIndex = 4;
            btnCong.Text = "+";
            btnCong.UseVisualStyleBackColor = true;
            btnCong.Click += BtnPhepToan_Click;
            // 
            // btnTru
            // 
            btnTru.Location = new Point(124, 122);
            btnTru.Margin = new Padding(3, 4, 3, 4);
            btnTru.Name = "btnTru";
            btnTru.Size = new Size(80, 41);
            btnTru.TabIndex = 5;
            btnTru.Text = "-";
            btnTru.UseVisualStyleBackColor = true;
            btnTru.Click += BtnPhepToan_Click;
            // 
            // btnNhan
            // 
            btnNhan.Location = new Point(211, 122);
            btnNhan.Margin = new Padding(3, 4, 3, 4);
            btnNhan.Name = "btnNhan";
            btnNhan.Size = new Size(80, 41);
            btnNhan.TabIndex = 6;
            btnNhan.Text = "*";
            btnNhan.UseVisualStyleBackColor = true;
            btnNhan.Click += BtnPhepToan_Click;
            // 
            // btnChia
            // 
            btnChia.Location = new Point(297, 122);
            btnChia.Margin = new Padding(3, 4, 3, 4);
            btnChia.Name = "btnChia";
            btnChia.Size = new Size(80, 41);
            btnChia.TabIndex = 7;
            btnChia.Text = "/";
            btnChia.UseVisualStyleBackColor = true;
            btnChia.Click += BtnPhepToan_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // bai1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(407, 192);
            Controls.Add(lblA);
            Controls.Add(txtA);
            Controls.Add(lblB);
            Controls.Add(txtB);
            Controls.Add(btnCong);
            Controls.Add(btnTru);
            Controls.Add(btnNhan);
            Controls.Add(btnChia);
            Controls.Add(lblKQ);
            Controls.Add(txtKQ);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "bai1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phép tính hai số";
            FormClosing += bai1_FormClosing;
            Load += bai1_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}