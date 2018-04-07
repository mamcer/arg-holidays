namespace ArgHolidays
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlResults = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaEfectiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.feriadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOriginalDate = new System.Windows.Forms.Label();
            this.lblEffectiveDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDescriptionType = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lnkAboutBox = new System.Windows.Forms.LinkLabel();
            this.lnkThisMonth = new System.Windows.Forms.LinkLabel();
            this.lnkNextSixMonths = new System.Windows.Forms.LinkLabel();
            this.lnkLastSixMonths = new System.Windows.Forms.LinkLabel();
            this.lnkThisYear = new System.Windows.Forms.LinkLabel();
            this.lblToDate = new System.Windows.Forms.Label();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.dtDate2 = new System.Windows.Forms.DateTimePicker();
            this.dtDate1 = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1.SuspendLayout();
            this.pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feriadoBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 472);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(649, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlResults
            // 
            this.pnlResults.Controls.Add(this.dataGridView1);
            this.pnlResults.Controls.Add(this.button1);
            this.pnlResults.Controls.Add(this.groupBox1);
            this.pnlResults.Enabled = false;
            this.pnlResults.Location = new System.Drawing.Point(12, 106);
            this.pnlResults.Name = "pnlResults";
            this.pnlResults.Size = new System.Drawing.Size(624, 357);
            this.pnlResults.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.FechaEfectiva,
            this.nombreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.feriadoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 19);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(246, 298);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // FechaEfectiva
            // 
            this.FechaEfectiva.DataPropertyName = "FechaEfectiva";
            this.FechaEfectiva.HeaderText = "FechaEfectiva";
            this.FechaEfectiva.Name = "FechaEfectiva";
            this.FechaEfectiva.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 140;
            // 
            // feriadoBindingSource
            // 
            this.feriadoBindingSource.DataMember = "Feriado";
            this.feriadoBindingSource.DataSource = typeof(ArgHolidays.MIFeriados.FeriadoDS);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Export to csv File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOriginalDate);
            this.groupBox1.Controls.Add(this.lblEffectiveDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblDescriptionType);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Location = new System.Drawing.Point(255, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 314);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Details";
            // 
            // lblOriginalDate
            // 
            this.lblOriginalDate.AutoSize = true;
            this.lblOriginalDate.Location = new System.Drawing.Point(97, 146);
            this.lblOriginalDate.Name = "lblOriginalDate";
            this.lblOriginalDate.Size = new System.Drawing.Size(80, 13);
            this.lblOriginalDate.TabIndex = 6;
            this.lblOriginalDate.Text = "Fecha original";
            // 
            // lblEffectiveDate
            // 
            this.lblEffectiveDate.AutoSize = true;
            this.lblEffectiveDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEffectiveDate.Location = new System.Drawing.Point(97, 115);
            this.lblEffectiveDate.Name = "lblEffectiveDate";
            this.lblEffectiveDate.Size = new System.Drawing.Size(88, 15);
            this.lblEffectiveDate.TabIndex = 5;
            this.lblEffectiveDate.Text = "Fecha efectiva";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Source Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Effective Date:";
            // 
            // lblDescriptionType
            // 
            this.lblDescriptionType.AutoSize = true;
            this.lblDescriptionType.Location = new System.Drawing.Point(7, 79);
            this.lblDescriptionType.Name = "lblDescriptionType";
            this.lblDescriptionType.Size = new System.Drawing.Size(108, 13);
            this.lblDescriptionType.TabIndex = 2;
            this.lblDescriptionType.Text = "Tipo de Descripción";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(7, 54);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(80, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Descripción";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(6, 16);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(71, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.lnkAboutBox);
            this.pnlControls.Controls.Add(this.lnkThisMonth);
            this.pnlControls.Controls.Add(this.lnkNextSixMonths);
            this.pnlControls.Controls.Add(this.lnkLastSixMonths);
            this.pnlControls.Controls.Add(this.lnkThisYear);
            this.pnlControls.Controls.Add(this.lblToDate);
            this.pnlControls.Controls.Add(this.lblFromDate);
            this.pnlControls.Controls.Add(this.btnGo);
            this.pnlControls.Controls.Add(this.dtDate2);
            this.pnlControls.Controls.Add(this.dtDate1);
            this.pnlControls.Location = new System.Drawing.Point(12, 12);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(624, 87);
            this.pnlControls.TabIndex = 9;
            // 
            // lnkAboutBox
            // 
            this.lnkAboutBox.AutoSize = true;
            this.lnkAboutBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkAboutBox.Location = new System.Drawing.Point(582, 8);
            this.lnkAboutBox.Name = "lnkAboutBox";
            this.lnkAboutBox.Size = new System.Drawing.Size(39, 13);
            this.lnkAboutBox.TabIndex = 21;
            this.lnkAboutBox.TabStop = true;
            this.lnkAboutBox.Text = "About";
            this.lnkAboutBox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAboutBox_LinkClicked);
            // 
            // lnkThisMonth
            // 
            this.lnkThisMonth.AutoSize = true;
            this.lnkThisMonth.Location = new System.Drawing.Point(64, 7);
            this.lnkThisMonth.Name = "lnkThisMonth";
            this.lnkThisMonth.Size = new System.Drawing.Size(64, 13);
            this.lnkThisMonth.TabIndex = 20;
            this.lnkThisMonth.TabStop = true;
            this.lnkThisMonth.Text = "This month";
            this.lnkThisMonth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkThisMonth_LinkClicked);
            // 
            // lnkNextSixMonths
            // 
            this.lnkNextSixMonths.AutoSize = true;
            this.lnkNextSixMonths.Location = new System.Drawing.Point(218, 7);
            this.lnkNextSixMonths.Name = "lnkNextSixMonths";
            this.lnkNextSixMonths.Size = new System.Drawing.Size(81, 13);
            this.lnkNextSixMonths.TabIndex = 19;
            this.lnkNextSixMonths.TabStop = true;
            this.lnkNextSixMonths.Text = "Next 6 months";
            this.lnkNextSixMonths.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNextSixMonths_LinkClicked);
            // 
            // lnkLastSixMonths
            // 
            this.lnkLastSixMonths.AutoSize = true;
            this.lnkLastSixMonths.Location = new System.Drawing.Point(134, 7);
            this.lnkLastSixMonths.Name = "lnkLastSixMonths";
            this.lnkLastSixMonths.Size = new System.Drawing.Size(78, 13);
            this.lnkLastSixMonths.TabIndex = 18;
            this.lnkLastSixMonths.TabStop = true;
            this.lnkLastSixMonths.Text = "Last 6 months";
            this.lnkLastSixMonths.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLastSixMonths_LinkClicked);
            // 
            // lnkThisYear
            // 
            this.lnkThisYear.AutoSize = true;
            this.lnkThisYear.Location = new System.Drawing.Point(7, 7);
            this.lnkThisYear.Name = "lnkThisYear";
            this.lnkThisYear.Size = new System.Drawing.Size(50, 13);
            this.lnkThisYear.TabIndex = 17;
            this.lnkThisYear.TabStop = true;
            this.lnkThisYear.Text = "This Year";
            this.lnkThisYear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkThisYear_LinkClicked);
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(269, 33);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(45, 13);
            this.lblToDate.TabIndex = 12;
            this.lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(7, 33);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(60, 13);
            this.lblFromDate.TabIndex = 11;
            this.lblFromDate.Text = "From Date";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(540, 51);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 10;
            this.btnGo.Text = "Go!";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // dtDate2
            // 
            this.dtDate2.CustomFormat = "";
            this.dtDate2.Location = new System.Drawing.Point(272, 52);
            this.dtDate2.Name = "dtDate2";
            this.dtDate2.Size = new System.Drawing.Size(246, 22);
            this.dtDate2.TabIndex = 9;
            // 
            // dtDate1
            // 
            this.dtDate1.CustomFormat = "";
            this.dtDate1.Location = new System.Drawing.Point(10, 52);
            this.dtDate1.Name = "dtDate1";
            this.dtDate1.Size = new System.Drawing.Size(246, 22);
            this.dtDate1.TabIndex = 8;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 494);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlResults);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Argentina Holidays";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feriadoBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlResults;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblOriginalDate;
        private System.Windows.Forms.Label lblEffectiveDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDescriptionType;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource feriadoBindingSource;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.DateTimePicker dtDate2;
        private System.Windows.Forms.DateTimePicker dtDate1;
        private System.Windows.Forms.LinkLabel lnkThisMonth;
        private System.Windows.Forms.LinkLabel lnkNextSixMonths;
        private System.Windows.Forms.LinkLabel lnkLastSixMonths;
        private System.Windows.Forms.LinkLabel lnkThisYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaEfectiva;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.LinkLabel lnkAboutBox;
    }
}

