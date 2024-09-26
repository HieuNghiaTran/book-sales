namespace Book_Manager.Forms
{
    partial class SalesHistory
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
            components = new System.ComponentModel.Container();
            Label label1;
            menuStrip1 = new MenuStrip();
            btnExit = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgvHistory = new DataGridView();
            detail = new DataGridViewButtonColumn();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(391, 30);
            label1.Name = "label1";
            label1.Size = new Size(192, 33);
            label1.TabIndex = 3;
            label1.Text = "Lịch sử bán hàng";
            label1.Click += label1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { btnExit });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1022, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnExit
            // 
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(61, 24);
            btnExit.Text = "Thoát";
            btnExit.Click += thoátToolStripMenuItem_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Columns.AddRange(new DataGridViewColumn[] { detail });
            dgvHistory.Location = new Point(12, 73);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.Size = new Size(984, 395);
            dgvHistory.TabIndex = 2;
            dgvHistory.CellContentClick += dgvHistory_CellContentClick;
            // 
            // detail
            // 
            detail.HeaderText = "Action";
            detail.MinimumWidth = 6;
            detail.Name = "detail";
            detail.Text = "Chi tiết";
            detail.UseColumnTextForButtonValue = true;
            // 
            // SalesHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 491);
            Controls.Add(label1);
            Controls.Add(dgvHistory);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "SalesHistory";
            Text = "SalesHistory";
            Load += SalesHistory_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem btnExit;
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dgvHistory;
        private DataGridViewButtonColumn detail;
        private Label label1;
    }
}