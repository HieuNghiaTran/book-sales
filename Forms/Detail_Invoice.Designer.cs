namespace Book_Manager.Forms
{
    partial class Detail_Invoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            dgvDetailInvoice = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbtotal = new Label();
            lbquantity = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailInvoice).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { thoátToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1107, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(65, 24);
            thoátToolStripMenuItem.Text = " Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // dgvDetailInvoice
            // 
            dgvDetailInvoice.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDetailInvoice.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetailInvoice.Location = new Point(12, 80);
            dgvDetailInvoice.Name = "dgvDetailInvoice";
            dgvDetailInvoice.RowHeadersWidth = 51;
            dgvDetailInvoice.Size = new Size(1070, 367);
            dgvDetailInvoice.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(474, 40);
            label1.Name = "label1";
            label1.Size = new Size(179, 33);
            label1.TabIndex = 2;
            label1.Text = "Chi tiết hoá đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(789, 452);
            label2.Name = "label2";
            label2.Size = new Size(123, 25);
            label2.TabIndex = 3;
            label2.Text = " Tổng đơn:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(800, 486);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 4;
            label3.Text = "Gồm:";
            // 
            // lbtotal
            // 
            lbtotal.AutoSize = true;
            lbtotal.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbtotal.ForeColor = Color.Red;
            lbtotal.Location = new Point(928, 452);
            lbtotal.Name = "lbtotal";
            lbtotal.Size = new Size(70, 25);
            lbtotal.TabIndex = 5;
            lbtotal.Text = "label4";
            // 
            // lbquantity
            // 
            lbquantity.AutoSize = true;
            lbquantity.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbquantity.ForeColor = Color.Red;
            lbquantity.Location = new Point(928, 486);
            lbquantity.Name = "lbquantity";
            lbquantity.Size = new Size(70, 25);
            lbquantity.TabIndex = 6;
            lbquantity.Text = "label5";
            // 
            // Detail_Invoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 521);
            Controls.Add(lbquantity);
            Controls.Add(lbtotal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvDetailInvoice);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Detail_Invoice";
            Text = "Detail_Invoice";
            Load += Detail_Invoice_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetailInvoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private DataGridView dgvDetailInvoice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lbtotal;
        private Label lbquantity;
    }
}