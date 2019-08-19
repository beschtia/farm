namespace Dunja
{
    partial class CattleDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabVaganja = new System.Windows.Forms.TabPage();
            this.dgvWeighings = new System.Windows.Forms.DataGridView();
            this.btnVaganje = new System.Windows.Forms.Button();
            this.tabPageTerapije = new System.Windows.Forms.TabPage();
            this.btnTerapija = new System.Windows.Forms.Button();
            this.dgTerapije = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtArrivalDate = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtKalo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtArrivalWeight = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtInputWeight = new System.Windows.Forms.TextBox();
            this.txtNoBreedingDays = new System.Windows.Forms.TextBox();
            this.txtBreed = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLifeNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbcWeightDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcControlFatteningDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcControlGrowth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcControlGrowthPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcFatteningDays = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcGrowth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcGrowthPerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabVaganja.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeighings)).BeginInit();
            this.tabPageTerapije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTerapije)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabVaganja);
            this.tabControl1.Controls.Add(this.tabPageTerapije);
            this.tabControl1.Location = new System.Drawing.Point(12, 202);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 425);
            this.tabControl1.TabIndex = 27;
            // 
            // tabVaganja
            // 
            this.tabVaganja.Controls.Add(this.chart1);
            this.tabVaganja.Controls.Add(this.dgvWeighings);
            this.tabVaganja.Controls.Add(this.btnVaganje);
            this.tabVaganja.Location = new System.Drawing.Point(4, 22);
            this.tabVaganja.Name = "tabVaganja";
            this.tabVaganja.Padding = new System.Windows.Forms.Padding(3);
            this.tabVaganja.Size = new System.Drawing.Size(688, 399);
            this.tabVaganja.TabIndex = 0;
            this.tabVaganja.Text = "Vaganja";
            this.tabVaganja.UseVisualStyleBackColor = true;
            // 
            // dgvWeighings
            // 
            this.dgvWeighings.AllowUserToAddRows = false;
            this.dgvWeighings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvWeighings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWeighings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvWeighings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWeighings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tbcWeightDate,
            this.tbcWeight,
            this.tbcControlFatteningDays,
            this.tbcControlGrowth,
            this.tbcControlGrowthPerDay,
            this.tbcFatteningDays,
            this.tbcGrowth,
            this.tbcGrowthPerDay});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWeighings.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWeighings.Location = new System.Drawing.Point(16, 50);
            this.dgvWeighings.Name = "dgvWeighings";
            this.dgvWeighings.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWeighings.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvWeighings.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWeighings.Size = new System.Drawing.Size(645, 144);
            this.dgvWeighings.TabIndex = 21;
            this.dgvWeighings.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DgvWeighings_UserDeletingRow);
            // 
            // btnVaganje
            // 
            this.btnVaganje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVaganje.Location = new System.Drawing.Point(584, 21);
            this.btnVaganje.Name = "btnVaganje";
            this.btnVaganje.Size = new System.Drawing.Size(77, 23);
            this.btnVaganje.TabIndex = 23;
            this.btnVaganje.Text = "Izvaži";
            this.btnVaganje.UseVisualStyleBackColor = true;
            this.btnVaganje.Click += new System.EventHandler(this.BtnVaganje_Click);
            // 
            // tabPageTerapije
            // 
            this.tabPageTerapije.Controls.Add(this.btnTerapija);
            this.tabPageTerapije.Controls.Add(this.dgTerapije);
            this.tabPageTerapije.Location = new System.Drawing.Point(4, 22);
            this.tabPageTerapije.Name = "tabPageTerapije";
            this.tabPageTerapije.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTerapije.Size = new System.Drawing.Size(681, 292);
            this.tabPageTerapije.TabIndex = 1;
            this.tabPageTerapije.Text = "Terapije";
            this.tabPageTerapije.UseVisualStyleBackColor = true;
            // 
            // btnTerapija
            // 
            this.btnTerapija.Location = new System.Drawing.Point(580, 17);
            this.btnTerapija.Name = "btnTerapija";
            this.btnTerapija.Size = new System.Drawing.Size(75, 23);
            this.btnTerapija.TabIndex = 22;
            this.btnTerapija.Text = "Liječi";
            this.btnTerapija.UseVisualStyleBackColor = true;
            // 
            // dgTerapije
            // 
            this.dgTerapije.AllowUserToAddRows = false;
            this.dgTerapije.AllowUserToDeleteRows = false;
            this.dgTerapije.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgTerapije.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTerapije.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgTerapije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTerapije.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgTerapije.Location = new System.Drawing.Point(17, 56);
            this.dgTerapije.Name = "dgTerapije";
            this.dgTerapije.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTerapije.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgTerapije.Size = new System.Drawing.Size(638, 215);
            this.dgTerapije.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBuyPrice);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtArrivalDate);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtKalo);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtArrivalWeight);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtInputWeight);
            this.groupBox1.Controls.Add(this.txtNoBreedingDays);
            this.groupBox1.Controls.Add(this.txtBreed);
            this.groupBox1.Controls.Add(this.txtSex);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLifeNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(689, 165);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Govedo: ";
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.Location = new System.Drawing.Point(293, 97);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.ReadOnly = true;
            this.txtBuyPrice.Size = new System.Drawing.Size(48, 20);
            this.txtBuyPrice.TabIndex = 53;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(209, 100);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Ulazna Cijena: ";
            // 
            // txtArrivalDate
            // 
            this.txtArrivalDate.Location = new System.Drawing.Point(123, 97);
            this.txtArrivalDate.Name = "txtArrivalDate";
            this.txtArrivalDate.ReadOnly = true;
            this.txtArrivalDate.Size = new System.Drawing.Size(66, 20);
            this.txtArrivalDate.TabIndex = 51;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(18, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Datum Ulaza: ";
            // 
            // txtKalo
            // 
            this.txtKalo.Location = new System.Drawing.Point(445, 130);
            this.txtKalo.Name = "txtKalo";
            this.txtKalo.ReadOnly = true;
            this.txtKalo.Size = new System.Drawing.Size(36, 20);
            this.txtKalo.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(384, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "KALO % : ";
            // 
            // txtArrivalWeight
            // 
            this.txtArrivalWeight.Location = new System.Drawing.Point(293, 130);
            this.txtArrivalWeight.Name = "txtArrivalWeight";
            this.txtArrivalWeight.ReadOnly = true;
            this.txtArrivalWeight.Size = new System.Drawing.Size(50, 20);
            this.txtArrivalWeight.TabIndex = 47;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(204, 133);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Dolazna Kilaža: ";
            // 
            // txtInputWeight
            // 
            this.txtInputWeight.Location = new System.Drawing.Point(123, 130);
            this.txtInputWeight.Name = "txtInputWeight";
            this.txtInputWeight.ReadOnly = true;
            this.txtInputWeight.Size = new System.Drawing.Size(66, 20);
            this.txtInputWeight.TabIndex = 43;
            // 
            // txtNoBreedingDays
            // 
            this.txtNoBreedingDays.Location = new System.Drawing.Point(445, 97);
            this.txtNoBreedingDays.Name = "txtNoBreedingDays";
            this.txtNoBreedingDays.ReadOnly = true;
            this.txtNoBreedingDays.Size = new System.Drawing.Size(47, 20);
            this.txtNoBreedingDays.TabIndex = 41;
            // 
            // txtBreed
            // 
            this.txtBreed.Location = new System.Drawing.Point(369, 41);
            this.txtBreed.Name = "txtBreed";
            this.txtBreed.ReadOnly = true;
            this.txtBreed.Size = new System.Drawing.Size(123, 20);
            this.txtBreed.TabIndex = 40;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(271, 41);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(15, 20);
            this.txtSex.TabIndex = 39;
            this.txtSex.Text = "M";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Ulazna Kilaža: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Pasmina: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Dana u tovu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(231, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Spol: ";
            // 
            // txtLifeNumber
            // 
            this.txtLifeNumber.Location = new System.Drawing.Point(21, 41);
            this.txtLifeNumber.Name = "txtLifeNumber";
            this.txtLifeNumber.ReadOnly = true;
            this.txtLifeNumber.Size = new System.Drawing.Size(154, 20);
            this.txtLifeNumber.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Broj markice: ";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(17, 209);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.XValueMember = "Weight_date";
            series1.YValueMembers = "Weight";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(644, 174);
            this.chart1.TabIndex = 24;
            this.chart1.Text = "chart1";
            // 
            // tbcWeightDate
            // 
            this.tbcWeightDate.DataPropertyName = "Weight_date";
            this.tbcWeightDate.HeaderText = "Datum vaganja";
            this.tbcWeightDate.Name = "tbcWeightDate";
            this.tbcWeightDate.ReadOnly = true;
            // 
            // tbcWeight
            // 
            this.tbcWeight.DataPropertyName = "Weight";
            this.tbcWeight.HeaderText = "Kilaža";
            this.tbcWeight.Name = "tbcWeight";
            this.tbcWeight.ReadOnly = true;
            // 
            // tbcControlFatteningDays
            // 
            this.tbcControlFatteningDays.DataPropertyName = "Control_Fattening_days";
            this.tbcControlFatteningDays.HeaderText = "Dana u tovu između vaganja";
            this.tbcControlFatteningDays.Name = "tbcControlFatteningDays";
            this.tbcControlFatteningDays.ReadOnly = true;
            // 
            // tbcControlGrowth
            // 
            this.tbcControlGrowth.DataPropertyName = "Control_growth";
            this.tbcControlGrowth.HeaderText = "Kontrolni prirast";
            this.tbcControlGrowth.Name = "tbcControlGrowth";
            this.tbcControlGrowth.ReadOnly = true;
            // 
            // tbcControlGrowthPerDay
            // 
            this.tbcControlGrowthPerDay.DataPropertyName = "Control_growthPerDay";
            this.tbcControlGrowthPerDay.HeaderText = "Kontrolni dnevni prirast";
            this.tbcControlGrowthPerDay.Name = "tbcControlGrowthPerDay";
            this.tbcControlGrowthPerDay.ReadOnly = true;
            // 
            // tbcFatteningDays
            // 
            this.tbcFatteningDays.DataPropertyName = "Fattening_days";
            this.tbcFatteningDays.HeaderText = "Dana u tovu";
            this.tbcFatteningDays.Name = "tbcFatteningDays";
            this.tbcFatteningDays.ReadOnly = true;
            // 
            // tbcGrowth
            // 
            this.tbcGrowth.DataPropertyName = "Growth";
            this.tbcGrowth.HeaderText = "Prirast";
            this.tbcGrowth.Name = "tbcGrowth";
            this.tbcGrowth.ReadOnly = true;
            // 
            // tbcGrowthPerDay
            // 
            this.tbcGrowthPerDay.DataPropertyName = "Growth_per_day";
            this.tbcGrowthPerDay.HeaderText = "Dnevni prirast";
            this.tbcGrowthPerDay.Name = "tbcGrowthPerDay";
            this.tbcGrowthPerDay.ReadOnly = true;
            // 
            // CattleDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 632);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CattleDetails";
            this.Text = "CattleDetails";
            this.Activated += new System.EventHandler(this.CattleDetails_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tabVaganja.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWeighings)).EndInit();
            this.tabPageTerapije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTerapije)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabVaganja;
        private System.Windows.Forms.DataGridView dgvWeighings;
        private System.Windows.Forms.Button btnVaganje;
        private System.Windows.Forms.TabPage tabPageTerapije;
        private System.Windows.Forms.Button btnTerapija;
        private System.Windows.Forms.DataGridView dgTerapije;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBuyPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtArrivalDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtKalo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtArrivalWeight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtInputWeight;
        private System.Windows.Forms.TextBox txtNoBreedingDays;
        private System.Windows.Forms.TextBox txtBreed;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLifeNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcWeightDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcControlFatteningDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcControlGrowth;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcControlGrowthPerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcFatteningDays;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcGrowth;
        private System.Windows.Forms.DataGridViewTextBoxColumn tbcGrowthPerDay;
    }
}