using System.Data;

namespace DataGridViewDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("1");
            dt.Columns.Add("2");
            dt.Columns.Add("3");
            dt.Columns.Add("4");
            dt.Rows.Add("中国", "上海", "5000", "7000");
            dt.Rows.Add("中国", "北京", "3000", "5600");
            dt.Rows.Add("美国", "纽约", "6000", "8600");
            dt.Rows.Add("美国", "华劢顿", "8000", "9000");
            dt.Rows.Add("英国", "伦敦", "7000", "8800");
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.MergeColumnNames.Add("Column1");
            this.dataGridView1.AddSpanHeader(2, 2, "XXXX");
        }
    }
}
