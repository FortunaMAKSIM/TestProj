using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestProj.Data;

namespace TestProj
{
    public partial class Form2 : Form
    {
        private MyDbContext _dbContext;
        public Form2(MyDbContext dbContext)
        {
            InitializeComponent();
            _dbContext = dbContext;
            LoadApplications();
        }
        private void LoadApplications(string faultTypeFilter = null)
        {
            var applications = _dbContext.TestTable.ToList();
            dataGridView1.DataSource = applications;
        }
        private void LoadSortedData(string faultTypeFilter = null)
        {
            var applications = _dbContext.TestTable
            .OrderByDescending(app => app.Age) // Сортировка по возрасту от большего к меньшему
            .ToList();

            dataGridView1.DataSource = applications;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SortBtn_Click(object sender, EventArgs e)
        {
            LoadSortedData();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            LoadApplications();
        }
    }
}   
