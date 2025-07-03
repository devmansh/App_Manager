namespace AppManager
{
    partial class UpdateForm
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
            lblAppId = new Label();
            lblAppName = new Label();
            lblAppTech = new Label();
            lblVersion = new Label();
            lblTechSupport = new Label();
            txtAppId = new TextBox();
            txtAppName = new TextBox();
            txtAppTech = new TextBox();
            txtVersion = new TextBox();
            btnSave = new Button();
            btnCancel = new Button();
            dtpTechSupport = new DateTimePicker();
            grpUpdateBox = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblPlanAppId = new Label();
            txtPlanAppId = new TextBox();
            grpUpdateBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblAppId
            // 
            lblAppId.Anchor = AnchorStyles.Right;
            lblAppId.AutoSize = true;
            lblAppId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAppId.Location = new Point(43, 25);
            lblAppId.Name = "lblAppId";
            lblAppId.Size = new Size(201, 25);
            lblAppId.TabIndex = 0;
            lblAppId.Text = "ASP III Application ID:";
            // 
            // lblAppName
            // 
            lblAppName.Anchor = AnchorStyles.Right;
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAppName.Location = new Point(12, 81);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(232, 25);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "ASP III Application Name:";
            // 
            // lblAppTech
            // 
            lblAppTech.Anchor = AnchorStyles.Right;
            lblAppTech.AutoSize = true;
            lblAppTech.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblAppTech.Location = new Point(85, 193);
            lblAppTech.Name = "lblAppTech";
            lblAppTech.Size = new Size(159, 25);
            lblAppTech.TabIndex = 2;
            lblAppTech.Text = "Application Tech:";
            // 
            // lblVersion
            // 
            lblVersion.Anchor = AnchorStyles.Right;
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVersion.Location = new Point(164, 249);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(80, 25);
            lblVersion.TabIndex = 3;
            lblVersion.Text = "Version:";
            // 
            // lblTechSupport
            // 
            lblTechSupport.Anchor = AnchorStyles.Right;
            lblTechSupport.AutoSize = true;
            lblTechSupport.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTechSupport.Location = new Point(11, 302);
            lblTechSupport.Name = "lblTechSupport";
            lblTechSupport.Size = new Size(233, 25);
            lblTechSupport.TabIndex = 4;
            lblTechSupport.Text = "App Tech Out Of Support:";
            // 
            // txtAppId
            // 
            txtAppId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAppId.Location = new Point(250, 22);
            txtAppId.Margin = new Padding(3, 3, 10, 3);
            txtAppId.Name = "txtAppId";
            txtAppId.ReadOnly = true;
            txtAppId.Size = new Size(262, 31);
            txtAppId.TabIndex = 5;
            // 
            // txtAppName
            // 
            txtAppName.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAppName.Location = new Point(250, 78);
            txtAppName.Margin = new Padding(3, 3, 10, 3);
            txtAppName.Name = "txtAppName";
            txtAppName.ReadOnly = true;
            txtAppName.Size = new Size(262, 31);
            txtAppName.TabIndex = 6;
            // 
            // txtAppTech
            // 
            txtAppTech.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtAppTech.Location = new Point(250, 190);
            txtAppTech.Margin = new Padding(3, 3, 10, 3);
            txtAppTech.Name = "txtAppTech";
            txtAppTech.ReadOnly = true;
            txtAppTech.Size = new Size(262, 31);
            txtAppTech.TabIndex = 7;
            // 
            // txtVersion
            // 
            txtVersion.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtVersion.Location = new Point(250, 246);
            txtVersion.Margin = new Padding(3, 3, 10, 3);
            txtVersion.Name = "txtVersion";
            txtVersion.Size = new Size(262, 31);
            txtVersion.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top;
            btnSave.Location = new Point(313, 343);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(143, 34);
            btnSave.TabIndex = 10;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top;
            btnCancel.Location = new Point(313, 394);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(143, 34);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dtpTechSupport
            // 
            dtpTechSupport.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpTechSupport.Location = new Point(250, 299);
            dtpTechSupport.Margin = new Padding(3, 3, 10, 3);
            dtpTechSupport.Name = "dtpTechSupport";
            dtpTechSupport.Size = new Size(262, 31);
            dtpTechSupport.TabIndex = 12;
            // 
            // grpUpdateBox
            // 
            grpUpdateBox.Controls.Add(tableLayoutPanel1);
            grpUpdateBox.Location = new Point(0, 0);
            grpUpdateBox.Name = "grpUpdateBox";
            grpUpdateBox.RightToLeft = RightToLeft.No;
            grpUpdateBox.Size = new Size(528, 544);
            grpUpdateBox.TabIndex = 13;
            grpUpdateBox.TabStop = false;
            grpUpdateBox.Text = "ZUK ASP App Update";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.31801F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.68199F));
            tableLayoutPanel1.Controls.Add(lblAppName, 0, 1);
            tableLayoutPanel1.Controls.Add(txtAppId, 1, 0);
            tableLayoutPanel1.Controls.Add(lblAppId, 0, 0);
            tableLayoutPanel1.Controls.Add(txtAppName, 1, 1);
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 7);
            tableLayoutPanel1.Controls.Add(btnSave, 1, 6);
            tableLayoutPanel1.Controls.Add(dtpTechSupport, 1, 5);
            tableLayoutPanel1.Controls.Add(txtVersion, 1, 4);
            tableLayoutPanel1.Controls.Add(txtAppTech, 1, 3);
            tableLayoutPanel1.Controls.Add(lblTechSupport, 0, 5);
            tableLayoutPanel1.Controls.Add(lblVersion, 0, 4);
            tableLayoutPanel1.Controls.Add(lblAppTech, 0, 3);
            tableLayoutPanel1.Controls.Add(lblPlanAppId, 0, 2);
            tableLayoutPanel1.Controls.Add(txtPlanAppId, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 27);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(0, 10, 0, 0);
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.928572F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.126985F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.7063494F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(522, 514);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblPlanAppId
            // 
            lblPlanAppId.Anchor = AnchorStyles.Right;
            lblPlanAppId.AutoSize = true;
            lblPlanAppId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPlanAppId.Location = new Point(3, 137);
            lblPlanAppId.Name = "lblPlanAppId";
            lblPlanAppId.Size = new Size(241, 25);
            lblPlanAppId.TabIndex = 13;
            lblPlanAppId.Text = "Planning IT Application ID:";
            // 
            // txtPlanAppId
            // 
            txtPlanAppId.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtPlanAppId.Location = new Point(250, 134);
            txtPlanAppId.Margin = new Padding(3, 3, 10, 3);
            txtPlanAppId.Name = "txtPlanAppId";
            txtPlanAppId.ReadOnly = true;
            txtPlanAppId.Size = new Size(262, 31);
            txtPlanAppId.TabIndex = 14;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 544);
            Controls.Add(grpUpdateBox);
            Name = "UpdateForm";
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            grpUpdateBox.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblAppId;
        private Label lblAppName;
        private Label lblAppTech;
        private Label lblVersion;
        private Label lblTechSupport;
        private TextBox txtAppId;
        private TextBox txtAppName;
        private TextBox txtAppTech;
        private TextBox txtVersion;
        private Button btnSave;
        private Button btnCancel;
        private DateTimePicker dtpTechSupport;
        private GroupBox grpUpdateBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblPlanAppId;
        private TextBox txtPlanAppId;
    }
}