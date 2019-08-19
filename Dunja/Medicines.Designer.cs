namespace Dunja
{
    partial class Medicines
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtQuarantine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lbNazivLijeka = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.linkPDF = new System.Windows.Forms.LinkLabel();
            this.tbcMedicineID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcQuarantine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(271, 270);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "Spremi";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(251, 250);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 23);
            this.btnUpdate.TabIndex = 30;
            this.btnUpdate.Text = "Izmjeni lijek";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Lijekovi:";
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.AllowUserToAddRows = false;
            this.dgvMedicine.AllowUserToDeleteRows = false;
            this.dgvMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMedicine.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcMedicineID,
            this.tbcName,
            this.tbcDescription,
            this.tbcQuarantine,
            this.tbcStock,
            this.tbcLink});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.NullValue = null;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMedicine.DefaultCellStyle = dataGridViewCellStyle14;
            this.dgvMedicine.Location = new System.Drawing.Point(12, 42);
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvMedicine.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvMedicine.Size = new System.Drawing.Size(167, 271);
            this.dgvMedicine.TabIndex = 34;
            this.dgvMedicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvMedicine_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.linkPDF);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.txtQuarantine);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.lbNazivLijeka);
            this.groupBox1.Location = new System.Drawing.Point(194, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 206);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lijek:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(49, 24);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(90, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(141, 172);
            this.txtStock.MaxLength = 4;
            this.txtStock.Name = "txtStock";
            this.txtStock.ReadOnly = true;
            this.txtStock.Size = new System.Drawing.Size(43, 20);
            this.txtStock.TabIndex = 4;
            // 
            // txtQuarantine
            // 
            this.txtQuarantine.Location = new System.Drawing.Point(141, 145);
            this.txtQuarantine.MaxLength = 3;
            this.txtQuarantine.Name = "txtQuarantine";
            this.txtQuarantine.ReadOnly = true;
            this.txtQuarantine.Size = new System.Drawing.Size(43, 20);
            this.txtQuarantine.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Količina (mL):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opis:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Trajanje karence (dana): ";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(9, 71);
            this.txtDescription.MaxLength = 500;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDescription.Size = new System.Drawing.Size(198, 61);
            this.txtDescription.TabIndex = 2;
            // 
            // lbNazivLijeka
            // 
            this.lbNazivLijeka.AutoSize = true;
            this.lbNazivLijeka.Location = new System.Drawing.Point(6, 27);
            this.lbNazivLijeka.Name = "lbNazivLijeka";
            this.lbNazivLijeka.Size = new System.Drawing.Size(37, 13);
            this.lbNazivLijeka.TabIndex = 1;
            this.lbNazivLijeka.Text = "Naziv:";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(251, 290);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(116, 23);
            this.btnInsert.TabIndex = 31;
            this.btnInsert.Text = "Dodaj novi lijek";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.BtnInsert_Click);
            // 
            // linkPDF
            // 
            this.linkPDF.AutoSize = true;
            this.linkPDF.Location = new System.Drawing.Point(152, 27);
            this.linkPDF.Name = "linkPDF";
            this.linkPDF.Size = new System.Drawing.Size(28, 13);
            this.linkPDF.TabIndex = 36;
            this.linkPDF.TabStop = true;
            this.linkPDF.Text = "PDF";
            this.linkPDF.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkPDF_LinkClicked);
            // 
            // tbcMedicineID
            // 
            this.tbcMedicineID.DataPropertyName = "MedicineID";
            this.tbcMedicineID.HeaderText = "MedicineID";
            this.tbcMedicineID.Name = "tbcMedicineID";
            this.tbcMedicineID.ReadOnly = true;
            this.tbcMedicineID.Visible = false;
            // 
            // tbcName
            // 
            this.tbcName.DataPropertyName = "Name";
            this.tbcName.HeaderText = "Lijek";
            this.tbcName.Name = "tbcName";
            this.tbcName.ReadOnly = true;
            // 
            // tbcDescription
            // 
            this.tbcDescription.DataPropertyName = "Description";
            this.tbcDescription.HeaderText = "Description";
            this.tbcDescription.Name = "tbcDescription";
            this.tbcDescription.ReadOnly = true;
            this.tbcDescription.Visible = false;
            // 
            // tbcQuarantine
            // 
            this.tbcQuarantine.DataPropertyName = "Quarantine_days";
            this.tbcQuarantine.HeaderText = "Karenca";
            this.tbcQuarantine.Name = "tbcQuarantine";
            this.tbcQuarantine.ReadOnly = true;
            this.tbcQuarantine.Visible = false;
            // 
            // tbcStock
            // 
            this.tbcStock.DataPropertyName = "Stock";
            this.tbcStock.HeaderText = "Stanje";
            this.tbcStock.Name = "tbcStock";
            this.tbcStock.ReadOnly = true;
            // 
            // tbcLink
            // 
            this.tbcLink.DataPropertyName = "Link";
            this.tbcLink.HeaderText = "Link";
            this.tbcLink.Name = "tbcLink";
            this.tbcLink.ReadOnly = true;
            this.tbcLink.Visible = false;
            // 
            // Medicines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 450);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMedicine);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInsert);
            this.Name = "Medicines";
            this.Text = "Medicines";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtQuarantine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbNazivLijeka;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.LinkLabel linkPDF;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcMedicineID;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcName;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcQuarantine;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcLink;
    }
}