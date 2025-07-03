using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppManager
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string appId = txtAppId.Text.Trim();
            string appTech = txtAppTech.Text.Trim();

            using (var context = new AppDbContext())
            {
                var record = context.AppRecords
                    .FirstOrDefault(r => r.AppId == appId && r.AppTech == appTech);

                if (record != null)
                {
                    record.Version = txtVersion.Text.Trim();
                    record.TechOutOfSupport = dtpTechSupport.Value;

                    context.SaveChanges();
                    MessageBox.Show("Record updated successfully!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Record not found.");
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        public string AppId
        {
            set { txtAppId.Text = value; }
        }

        public string AppName
        {
            set { txtAppName.Text = value; }
        }

        public string PlanAppId
        {
            set { txtPlanAppId.Text = value; }
        }

        public string AppTech
        {
            set { txtAppTech.Text = value; }
        }

        public string Version
        {
            set { txtVersion.Text = value; }
            get { return txtVersion.Text; }
        }

        public DateTime TechOutOfSupport
        {
            get => dtpTechSupport.Value;
            set => dtpTechSupport.Value = value;

        }

    }
}
