using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace AppManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
            using (var context = new AppDbContext())
            {
                dgvRecords.DataSource = context.AppRecords
                .Select(r => new
                {
                    r.AppId,
                    r.AppName,
                    r.PlanAppId,
                    r.AppTech,
                    r.Version,
                    TechOutOfSupport = r.TechOutOfSupport.ToString("dd-MMM-yyyy")
                }).ToList();
                // Table Header, Remove if sql file name required.
                dgvRecords.Columns["AppId"].HeaderText = "ASP III Application ID";
                dgvRecords.Columns["AppName"].HeaderText = "ASP III Application Name";
                dgvRecords.Columns["PlanAppId"].HeaderText = "Planning IT Application ID";
                dgvRecords.Columns["AppTech"].HeaderText = "Application Tech";
                dgvRecords.Columns["Version"].HeaderText = "Version";
                dgvRecords.Columns["TechOutOfSupport"].HeaderText = "Application Tech Out Of Support";

            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            var newRecord = new AppRecord
            {
                AppId = txtAppId.Text.Trim(),
                AppName = txtAppName.Text.Trim(),
                PlanAppId = txtPlanAppId.Text.Trim(),
                AppTech = txtAppTech.Text.Trim(),
                Version = txtVersion.Text.Trim(),
                TechOutOfSupport = dtpTechSupport.Value
            };


            if (string.IsNullOrWhiteSpace(newRecord.AppId) || string.IsNullOrWhiteSpace(newRecord.AppTech))
            {
                MessageBox.Show("ASP III App ID and App Tech are required.");
                return;
            }

            using (var context = new AppDbContext())
            {

                bool exists = context.AppRecords
                    .Any(r => r.AppId == newRecord.AppId && r.AppTech == newRecord.AppTech);

                if (exists)
                {
                    MessageBox.Show("A record with the same ASP III App ID and App Tech already exists.");
                    return;
                }

                context.AppRecords.Add(newRecord);
                context.SaveChanges();
            }


            ClearInputs();
            LoadData();
            MessageBox.Show("Record added successfully!");
        }
        private void ClearInputs()
        {
            txtAppId.Clear();
            txtAppName.Clear();
            txtPlanAppId.Clear();
            txtAppTech.Clear();
            txtVersion.Clear();
            //txtTechSupport.Clear();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim().ToLower();

            using (var context = new AppDbContext())
            {
                var results = context.AppRecords
                    .Where(r => r.AppName.ToLower().Contains(keyword))
                    .ToList();

                dgvRecords.DataSource = results;
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadData();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvRecords.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.");
                return;
            }

            var selectedRow = dgvRecords.SelectedRows[0];

            string appId = selectedRow.Cells["AppId"].Value.ToString();
            string appName = selectedRow.Cells["AppName"].Value.ToString();
            string PlanAppId = selectedRow.Cells["PlanAppId"].Value.ToString();
            string appTech = selectedRow.Cells["AppTech"].Value.ToString();
            string version = selectedRow.Cells["Version"].Value?.ToString();
            DateTime techSupport = Convert.ToDateTime(selectedRow.Cells["TechOutOfSupport"].Value);

            UpdateForm updateForm = new UpdateForm
            {
                AppId = appId,
                AppName = appName,
                PlanAppId = PlanAppId,
                AppTech = appTech,
                Version = version,
                TechOutOfSupport = techSupport
            };

            if (updateForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void tableRecordLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
