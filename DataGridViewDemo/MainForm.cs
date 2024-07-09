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
            dt.Rows.Add("�й�", "�Ϻ�", "5000", "7000");
            dt.Rows.Add("�й�", "����", "3000", "5600");
            dt.Rows.Add("����", "ŦԼ", "6000", "8600");
            dt.Rows.Add("����", "��۽��", "8000", "9000");
            dt.Rows.Add("Ӣ��", "�׶�", "7000", "8800");
            this.dataGridView1.DataSource = dt;
            this.dataGridView1.ColumnHeadersHeight = 40;
            this.dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.MergeColumnNames.Add("Column1");
            this.dataGridView1.AddSpanHeader(2, 2, "XXXX");
        }
    }
}
