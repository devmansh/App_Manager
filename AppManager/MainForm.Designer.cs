namespace AppManager
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
            lblAppId = new Label();
            txtAppId = new TextBox();
            lblAppName = new Label();
            txtAppName = new TextBox();
            lblPlanAppId = new Label();
            txtPlanAppId = new TextBox();
            lblAppTech = new Label();
            txtAppTech = new TextBox();
            lblVersion = new Label();
            txtVersion = new TextBox();
            lblTechSupport = new Label();
            btnAdd = new Button();
            dgvRecords = new DataGridView();
            btnUpdate = new Button();
            dtpTechSupport = new DateTimePicker();
            tableLayoutPanel1 = new TableLayoutPanel();
            contentLayout = new TableLayoutPanel();
            grpAddRecord = new GroupBox();
            tableRecordLayout = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            grpSearch = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            lblSearch = new Label();
            btnClear = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvRecords).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            contentLayout.SuspendLayout();
            grpAddRecord.SuspendLayout();
            tableRecordLayout.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            grpSearch.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppId
            // 
            lblAppId.Anchor = AnchorStyles.Right;
            lblAppId.AutoSize = true;
            lblAppId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAppId.Location = new Point(71, 11);
            lblAppId.Name = "lblAppId";
            lblAppId.Size = new Size(220, 28);
            lblAppId.TabIndex = 0;
            lblAppId.Text = "ASP III Application ID:";
            lblAppId.Click += label1_Click;
            // 
            // txtAppId
            // 
            txtAppId.Anchor = AnchorStyles.Left;
            txtAppId.Location = new Point(297, 8);
            txtAppId.Name = "txtAppId";
            txtAppId.Size = new Size(236, 34);
            txtAppId.TabIndex = 1;
            // 
            // lblAppName
            // 
            lblAppName.Anchor = AnchorStyles.Right;
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAppName.Location = new Point(36, 61);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(255, 28);
            lblAppName.TabIndex = 2;
            lblAppName.Text = "ASP III Application Name:";
            // 
            // txtAppName
            // 
            txtAppName.Anchor = AnchorStyles.Left;
            txtAppName.Location = new Point(297, 58);
            txtAppName.Name = "txtAppName";
            txtAppName.Size = new Size(236, 34);
            txtAppName.TabIndex = 3;
            // 
            // lblPlanAppId
            // 
            lblPlanAppId.Anchor = AnchorStyles.Right;
            lblPlanAppId.AutoSize = true;
            lblPlanAppId.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPlanAppId.Location = new Point(25, 111);
            lblPlanAppId.Name = "lblPlanAppId";
            lblPlanAppId.Size = new Size(266, 28);
            lblPlanAppId.TabIndex = 4;
            lblPlanAppId.Text = "Planning IT Application ID:";
            // 
            // txtPlanAppId
            // 
            txtPlanAppId.Anchor = AnchorStyles.Left;
            txtPlanAppId.Location = new Point(297, 108);
            txtPlanAppId.Name = "txtPlanAppId";
            txtPlanAppId.Size = new Size(236, 34);
            txtPlanAppId.TabIndex = 5;
            // 
            // lblAppTech
            // 
            lblAppTech.Anchor = AnchorStyles.Right;
            lblAppTech.AutoSize = true;
            lblAppTech.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblAppTech.Location = new Point(116, 161);
            lblAppTech.Name = "lblAppTech";
            lblAppTech.Size = new Size(175, 28);
            lblAppTech.TabIndex = 6;
            lblAppTech.Text = "Application Tech:";
            // 
            // txtAppTech
            // 
            txtAppTech.Anchor = AnchorStyles.Left;
            txtAppTech.Location = new Point(297, 158);
            txtAppTech.Name = "txtAppTech";
            txtAppTech.Size = new Size(236, 34);
            txtAppTech.TabIndex = 7;
            // 
            // lblVersion
            // 
            lblVersion.Anchor = AnchorStyles.Right;
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblVersion.Location = new Point(204, 211);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(87, 28);
            lblVersion.TabIndex = 8;
            lblVersion.Text = "Version:";
            // 
            // txtVersion
            // 
            txtVersion.AllowDrop = true;
            txtVersion.Anchor = AnchorStyles.Left;
            txtVersion.Location = new Point(297, 208);
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(236, 34);
            txtVersion.TabIndex = 9;
            // 
            // lblTechSupport
            // 
            lblTechSupport.Anchor = AnchorStyles.Right;
            lblTechSupport.AutoSize = true;
            lblTechSupport.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTechSupport.Location = new Point(35, 261);
            lblTechSupport.Name = "lblTechSupport";
            lblTechSupport.Size = new Size(256, 28);
            lblTechSupport.TabIndex = 10;
            lblTechSupport.Text = "App Tech Out Of Support:";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top;
            btnAdd.Location = new Point(352, 303);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 37);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add Record";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dgvRecords
            // 
            dgvRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvRecords.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecords.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRecords.Location = new Point(3, 3);
            dgvRecords.MultiSelect = false;
            dgvRecords.Name = "dgvRecords";
            dgvRecords.ReadOnly = true;
            dgvRecords.RowHeadersWidth = 62;
            dgvRecords.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRecords.Size = new Size(806, 341);
            dgvRecords.TabIndex = 17;
            // 
            // btnUpdate
            // 
            btnUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnUpdate.Location = new Point(281, 350);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(250, 34);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update Selected Row";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dtpTechSupport
            // 
            dtpTechSupport.Anchor = AnchorStyles.Left;
            dtpTechSupport.Location = new Point(297, 258);
            dtpTechSupport.Name = "dtpTechSupport";
            dtpTechSupport.Size = new Size(236, 34);
            dtpTechSupport.TabIndex = 19;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(contentLayout, 0, 1);
            tableLayoutPanel1.Controls.Add(grpSearch, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1378, 544);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // contentLayout
            // 
            contentLayout.ColumnCount = 2;
            contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            contentLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            contentLayout.Controls.Add(grpAddRecord, 0, 0);
            contentLayout.Controls.Add(groupBox1, 1, 0);
            contentLayout.Dock = DockStyle.Fill;
            contentLayout.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contentLayout.Location = new Point(3, 103);
            contentLayout.Name = "contentLayout";
            contentLayout.RowCount = 1;
            contentLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            contentLayout.Size = new Size(1372, 438);
            contentLayout.TabIndex = 1;
            // 
            // grpAddRecord
            // 
            grpAddRecord.Controls.Add(tableRecordLayout);
            grpAddRecord.Dock = DockStyle.Fill;
            grpAddRecord.Location = new Point(3, 3);
            grpAddRecord.Name = "grpAddRecord";
            grpAddRecord.Padding = new Padding(3, 15, 3, 3);
            grpAddRecord.Size = new Size(542, 432);
            grpAddRecord.TabIndex = 0;
            grpAddRecord.TabStop = false;
            grpAddRecord.Text = "Add Application";
            // 
            // tableRecordLayout
            // 
            tableRecordLayout.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            tableRecordLayout.ColumnCount = 2;
            tableRecordLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55F));
            tableRecordLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableRecordLayout.Controls.Add(dtpTechSupport, 1, 5);
            tableRecordLayout.Controls.Add(btnAdd, 1, 6);
            tableRecordLayout.Controls.Add(lblAppId, 0, 0);
            tableRecordLayout.Controls.Add(lblAppName, 0, 1);
            tableRecordLayout.Controls.Add(txtAppId, 1, 0);
            tableRecordLayout.Controls.Add(txtAppName, 1, 1);
            tableRecordLayout.Controls.Add(lblTechSupport, 0, 5);
            tableRecordLayout.Controls.Add(lblPlanAppId, 0, 2);
            tableRecordLayout.Controls.Add(txtVersion, 1, 4);
            tableRecordLayout.Controls.Add(txtPlanAppId, 1, 2);
            tableRecordLayout.Controls.Add(lblVersion, 0, 4);
            tableRecordLayout.Controls.Add(lblAppTech, 0, 3);
            tableRecordLayout.Controls.Add(txtAppTech, 1, 3);
            tableRecordLayout.Location = new Point(3, 42);
            tableRecordLayout.Name = "tableRecordLayout";
            tableRecordLayout.RowCount = 8;
            tableRecordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableRecordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableRecordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableRecordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableRecordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableRecordLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableRecordLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableRecordLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableRecordLayout.Size = new Size(536, 387);
            tableRecordLayout.TabIndex = 0;
            tableRecordLayout.Paint += tableRecordLayout_Paint;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(551, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 15, 3, 3);
            groupBox1.Size = new Size(818, 432);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Applications Record";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(btnUpdate, 0, 1);
            tableLayoutPanel2.Controls.Add(dgvRecords, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 42);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.Size = new Size(812, 387);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // grpSearch
            // 
            grpSearch.Controls.Add(tableLayoutPanel3);
            grpSearch.Dock = DockStyle.Fill;
            grpSearch.Font = new Font("Segoe UI", 10F);
            grpSearch.Location = new Point(3, 3);
            grpSearch.Name = "grpSearch";
            grpSearch.Size = new Size(1372, 94);
            grpSearch.TabIndex = 0;
            grpSearch.TabStop = false;
            grpSearch.Text = "ZUK ASP Applications";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 5;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel3.Controls.Add(lblSearch, 0, 0);
            tableLayoutPanel3.Controls.Add(btnClear, 3, 0);
            tableLayoutPanel3.Controls.Add(btnSearch, 2, 0);
            tableLayoutPanel3.Controls.Add(txtSearch, 1, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 30);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(1366, 61);
            tableLayoutPanel3.TabIndex = 17;
            // 
            // lblSearch
            // 
            lblSearch.Anchor = AnchorStyles.Right;
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSearch.Location = new Point(55, 16);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(215, 28);
            lblSearch.TabIndex = 13;
            lblSearch.Text = "Search by App Name:";
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Left;
            btnClear.Location = new Point(685, 12);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 37);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Left;
            btnSearch.Location = new Point(549, 12);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(125, 37);
            btnSearch.TabIndex = 15;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Left;
            txtSearch.Location = new Point(276, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(267, 34);
            txtSearch.TabIndex = 14;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1378, 544);
            Controls.Add(tableLayoutPanel1);
            MinimumSize = new Size(1000, 600);
            Name = "MainForm";
            Text = "ZUKASPApps.DXC";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRecords).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            contentLayout.ResumeLayout(false);
            grpAddRecord.ResumeLayout(false);
            tableRecordLayout.ResumeLayout(false);
            tableRecordLayout.PerformLayout();
            groupBox1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            grpSearch.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAppId;
        private TextBox txtAppId;
        private Label lblAppName;
        private TextBox txtAppName;
        private Label lblPlanAppId;
        private TextBox txtPlanAppId;
        private Label lblAppTech;
        private TextBox txtAppTech;
        private Label lblVersion;
        private TextBox txtVersion;
        private Label lblTechSupport;
        private Button btnAdd;
        private DataGridView dgvRecords;
        private Button btnUpdate;
        private DateTimePicker dtpTechSupport;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox grpSearch;
        private TableLayoutPanel contentLayout;
        private GroupBox grpAddRecord;
        private TableLayoutPanel tableRecordLayout;
        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label lblSearch;
        private Button btnClear;
        private Button btnSearch;
        private TextBox txtSearch;
    }
}
