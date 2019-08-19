namespace Dunja
{
    partial class Form1
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
            this.dgvCattle = new System.Windows.Forms.DataGridView();
            this.txtCattleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLifeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbBreed = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtInputWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtArrivalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnMedicine = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCattle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCattle
            // 
            this.dgvCattle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCattle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCattle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtCattleID,
            this.txtArrivalDate,
            this.txtBuyPrice,
            this.txtLifeNumber,
            this.txtSex,
            this.cbBreed,
            this.txtInputWeight,
            this.txtArrivalWeight});
            this.dgvCattle.Location = new System.Drawing.Point(12, 133);
            this.dgvCattle.MultiSelect = false;
            this.dgvCattle.Name = "dgvCattle";
            this.dgvCattle.Size = new System.Drawing.Size(774, 300);
            this.dgvCattle.TabIndex = 0;
            this.dgvCattle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCattle_CellDoubleClick);
            this.dgvCattle.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DgvCattle_CellValidating);
            this.dgvCattle.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCattle_CellValueChanged);
            this.dgvCattle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.DgvCattle_EditingControlShowing);
            this.dgvCattle.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DgvCattle_UserDeletingRow);
            // 
            // txtCattleID
            // 
            this.txtCattleID.DataPropertyName = "CattleID";
            this.txtCattleID.HeaderText = "CattleID";
            this.txtCattleID.Name = "txtCattleID";
            this.txtCattleID.ReadOnly = true;
            this.txtCattleID.Width = 30;
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.DataPropertyName = "Arrival_date";
            this.txtArrivalDate.HeaderText = "Arrival date";
            this.txtArrivalDate.MaxInputLength = 10;
            this.txtArrivalDate.Name = "txtArrivalDate";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.DataPropertyName = "Buy_price";
            this.txtBuyPrice.HeaderText = "Buy price";
            this.txtBuyPrice.MaxInputLength = 5;
            this.txtBuyPrice.Name = "txtBuyPrice";
            // 
            // txtLifeNumber
            // 
            this.txtLifeNumber.DataPropertyName = "Life_number";
            this.txtLifeNumber.HeaderText = "Life number";
            this.txtLifeNumber.MaxInputLength = 12;
            this.txtLifeNumber.Name = "txtLifeNumber";
            // 
            // txtSex
            // 
            this.txtSex.DataPropertyName = "Sex";
            this.txtSex.HeaderText = "Sex";
            this.txtSex.MaxInputLength = 1;
            this.txtSex.Name = "txtSex";
            // 
            // cbBreed
            // 
            this.cbBreed.DataPropertyName = "BreedID";
            this.cbBreed.HeaderText = "Breed";
            this.cbBreed.Name = "cbBreed";
            // 
            // txtInputWeight
            // 
            this.txtInputWeight.DataPropertyName = "Input_weight";
            this.txtInputWeight.HeaderText = "Input weight";
            this.txtInputWeight.MaxInputLength = 4;
            this.txtInputWeight.Name = "txtInputWeight";
            // 
            // txtArrivalWeight
            // 
            this.txtArrivalWeight.DataPropertyName = "Arrival_weight";
            this.txtArrivalWeight.HeaderText = "Arrival weight";
            this.txtArrivalWeight.MaxInputLength = 4;
            this.txtArrivalWeight.Name = "txtArrivalWeight";
            // 
            // btnExcel
            // 
            this.btnExcel.Location = new System.Drawing.Point(12, 12);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(86, 68);
            this.btnExcel.TabIndex = 4;
            this.btnExcel.Text = "Excel";
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.BtnExcel_Click);
            // 
            // btnMedicine
            // 
            this.btnMedicine.Location = new System.Drawing.Point(113, 12);
            this.btnMedicine.Name = "btnMedicine";
            this.btnMedicine.Size = new System.Drawing.Size(86, 68);
            this.btnMedicine.TabIndex = 5;
            this.btnMedicine.Text = "Lijekovi";
            this.btnMedicine.UseVisualStyleBackColor = true;
            this.btnMedicine.Click += new System.EventHandler(this.BtnMedicine_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 444);
            this.Controls.Add(this.btnMedicine);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dgvCattle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCattle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCattle;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtCattleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtArrivalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLifeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSex;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbBreed;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInputWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtArrivalWeight;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnMedicine;
    }
}

