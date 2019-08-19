namespace Dunja
{
    partial class Excel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnReadExcel = new System.Windows.Forms.Button();
            this.cbBreed = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbSheets = new System.Windows.Forms.ListBox();
            this.btnUpload = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.txtArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLifeNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBreed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtInputWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtArrivalWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuyPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(161, 172);
            this.txtPrice.MaxLength = 5;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(100, 20);
            this.txtPrice.TabIndex = 14;
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPrice_KeyPress);
            // 
            // btnReadExcel
            // 
            this.btnReadExcel.Location = new System.Drawing.Point(170, 235);
            this.btnReadExcel.Name = "btnReadExcel";
            this.btnReadExcel.Size = new System.Drawing.Size(75, 23);
            this.btnReadExcel.TabIndex = 15;
            this.btnReadExcel.Text = "Read";
            this.btnReadExcel.UseVisualStyleBackColor = true;
            this.btnReadExcel.Click += new System.EventHandler(this.BtnReadExcel_Click);
            // 
            // cbBreed
            // 
            this.cbBreed.FormattingEnabled = true;
            this.cbBreed.Location = new System.Drawing.Point(152, 135);
            this.cbBreed.Name = "cbBreed";
            this.cbBreed.Size = new System.Drawing.Size(121, 21);
            this.cbBreed.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(152, 99);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // lbSheets
            // 
            this.lbSheets.FormattingEnabled = true;
            this.lbSheets.Location = new System.Drawing.Point(12, 68);
            this.lbSheets.Name = "lbSheets";
            this.lbSheets.Size = new System.Drawing.Size(117, 251);
            this.lbSheets.TabIndex = 11;
            // 
            // btnUpload
            // 
            this.btnUpload.Enabled = false;
            this.btnUpload.Location = new System.Drawing.Point(554, 377);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 17;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUpload_Click);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtArrivalDate,
            this.txtLifeNumber,
            this.txtSex,
            this.txtBreed,
            this.txtInputWeight,
            this.txtArrivalWeight,
            this.txtBuyPrice,
            this.txtTotal});
            this.dgv.Location = new System.Drawing.Point(299, 68);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(670, 251);
            this.dgv.TabIndex = 16;
            this.dgv.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Dgv_EditingControlShowing);
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.DataPropertyName = "ArrivalDate";
            this.txtArrivalDate.HeaderText = "Arrival date";
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.ReadOnly = true;
            this.txtArrivalDate.Width = 85;
            // 
            // txtLifeNumber
            // 
            this.txtLifeNumber.DataPropertyName = "LifeNumber";
            this.txtLifeNumber.HeaderText = "Life number";
            this.txtLifeNumber.Name = "txtLifeNumber";
            this.txtLifeNumber.ReadOnly = true;
            this.txtLifeNumber.Width = 87;
            // 
            // txtSex
            // 
            this.txtSex.DataPropertyName = "Sex";
            this.txtSex.HeaderText = "Sex";
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Width = 50;
            // 
            // txtBreed
            // 
            this.txtBreed.DataPropertyName = "BreedID";
            this.txtBreed.HeaderText = "Breed";
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.ReadOnly = true;
            this.txtBreed.Width = 60;
            // 
            // txtInputWeight
            // 
            this.txtInputWeight.DataPropertyName = "InputWeight";
            this.txtInputWeight.HeaderText = "Input weight";
            this.txtInputWeight.Name = "txtInputWeight";
            this.txtInputWeight.ReadOnly = true;
            this.txtInputWeight.Width = 90;
            // 
            // txtArrivalWeight
            // 
            this.txtArrivalWeight.DataPropertyName = "ArrivalWeight";
            this.txtArrivalWeight.HeaderText = "Arrival weight";
            this.txtArrivalWeight.MaxInputLength = 4;
            this.txtArrivalWeight.Name = "txtArrivalWeight";
            this.txtArrivalWeight.Width = 95;
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.DataPropertyName = "BuyPrice";
            this.txtBuyPrice.HeaderText = "Buy price";
            this.txtBuyPrice.MaxInputLength = 5;
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Width = 76;
            // 
            // txtTotal
            // 
            this.txtTotal.DataPropertyName = "Total";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.txtTotal.DefaultCellStyle = dataGridViewCellStyle1;
            this.txtTotal.HeaderText = "Total price";
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Width = 82;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(12, 29);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(104, 31);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(303, 20);
            this.txtPath.TabIndex = 18;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Dunja.Properties.Resources.dribbble_spinner_800x600;
            this.pictureBox1.Location = new System.Drawing.Point(152, 307);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Excel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 544);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnReadExcel);
            this.Controls.Add(this.cbBreed);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbSheets);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Name = "Excel";
            this.Text = "Excel";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Button btnReadExcel;
        private System.Windows.Forms.ComboBox cbBreed;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListBox lbSheets;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtArrivalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtLifeNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBreed;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtInputWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtArrivalWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtBuyPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTotal;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}