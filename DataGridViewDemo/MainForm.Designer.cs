namespace DataGridViewDemo
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            dataGridView1 = new DataGridMergeView();
            国家 = new DataGridViewTextBoxColumn();
            城市 = new DataGridViewTextBoxColumn();
            男 = new DataGridViewTextBoxColumn();
            女 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { 国家, 城市, 男, 女 });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.MergeColumnHeaderBackColor = SystemColors.Control;
            dataGridView1.MergeColumnNames = (List<string>)resources.GetObject("dataGridView1.MergeColumnNames");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(760, 537);
            dataGridView1.TabIndex = 0;
            // 
            // 国家
            // 
            国家.DataPropertyName = "1";
            国家.HeaderText = "国家";
            国家.Name = "国家";
            // 
            // 城市
            // 
            城市.DataPropertyName = "2";
            城市.HeaderText = "城市";
            城市.Name = "城市";
            // 
            // 男
            // 
            男.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            男.DataPropertyName = "3";
            男.HeaderText = "男";
            男.Name = "男";
            // 
            // 女
            // 
            女.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            女.DataPropertyName = "4";
            女.HeaderText = "女";
            女.Name = "女";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 561);
            Controls.Add(dataGridView1);
            Font = new Font("Microsoft YaHei UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DataGridView";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridMergeView dataGridView1;
        private DataGridViewTextBoxColumn 国家;
        private DataGridViewTextBoxColumn 城市;
        private DataGridViewTextBoxColumn 男;
        private DataGridViewTextBoxColumn 女;
    }
}
