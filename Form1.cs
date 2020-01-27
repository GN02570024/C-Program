using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.MultiSelect = false;
            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            ShowSortInfo();
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.VirtualMode = true;
            var col = dataGridView1.Columns[e.ColumnIndex];

            ListSortDirection direction;
            if (dataGridView1.SortOrder == (SortOrder.Descending | SortOrder.None))
            {
                direction = ListSortDirection.Ascending;
            }
            else
            {
                direction = ListSortDirection.Descending;
            }
            dataGridView1.Sort(col, direction);
        }

        // Populates the DataGridView.
        // Replace this with your own code to populate the DataGridView.
        public void PopulateDataGridView()
        {
            // DataGridViewSelectionMode.ColumnHeaderSelect 時，DataGridViewColumn.SortMode 不能是 Auto
            dataGridView1.SelectionMode =DataGridViewSelectionMode.ColumnHeaderSelect;

            // 設定 DataGridViewTextBoxColumn
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "姓",
                Name = "ColLastName",
                SortMode = DataGridViewColumnSortMode.Programmatic
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "都市1233",
                Name = "ColCity",
                SortMode = DataGridViewColumnSortMode.Programmatic
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "性",
                Name = "sex",
                SortMode = DataGridViewColumnSortMode.Programmatic
            });

            // DataGridView 資料
            dataGridView1.Rows.Add("Parker", "Seattle","boy");
            dataGridView1.Rows.Add("Watson", "Seattle","gril");
            dataGridView1.Rows.Add("Osborn", "New York", "boy");
            dataGridView1.Rows.Add("Jameson", "New York", "boy");
            dataGridView1.Rows.Add("Brock", "New Jersey", "boy");
        }

        private void ShowSortInfo()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
