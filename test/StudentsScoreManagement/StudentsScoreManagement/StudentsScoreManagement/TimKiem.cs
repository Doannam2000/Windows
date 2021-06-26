using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsScoreManagement
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }
        public string title{ get; set; }
        public string user { get; set; }
        DataUtil data = new DataUtil();
        public DataTable dataTable{ get; set; }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            lblTT.Text = "Tìm kiếm " + title;
            loadForm();
        }
        private void loadForm()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            if (user.ToUpper().Equals("ADMIN"))
            {

            }    
        }
    }
}
