namespace ArgHolidays
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            statusStrip1 = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            pnlResults = new System.Windows.Forms.Panel();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            FechaEfectiva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            feriadoBindingSource = new System.Windows.Forms.BindingSource(components);
            button1 = new System.Windows.Forms.Button();
            groupBox1 = new System.Windows.Forms.GroupBox();
            lblOriginalDate = new System.Windows.Forms.Label();
            lblEffectiveDate = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            lblDescriptionType = new System.Windows.Forms.Label();
            lblDescription = new System.Windows.Forms.Label();
            lblName = new System.Windows.Forms.Label();
            pnlControls = new System.Windows.Forms.Panel();
            lnkThisMonth = new System.Windows.Forms.LinkLabel();
            lnkNextSixMonths = new System.Windows.Forms.LinkLabel();
            lnkLastSixMonths = new System.Windows.Forms.LinkLabel();
            lnkThisYear = new System.Windows.Forms.LinkLabel();
            lblToDate = new System.Windows.Forms.Label();
            lblFromDate = new System.Windows.Forms.Label();
            btnGo = new System.Windows.Forms.Button();
            dtDate2 = new System.Windows.Forms.DateTimePicker();
            dtDate1 = new System.Windows.Forms.DateTimePicker();
            saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            lnkAboutBox = new System.Windows.Forms.LinkLabel();
            statusStrip1.SuspendLayout();
            pnlResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(feriadoBindingSource)).BeginInit();
            groupBox1.SuspendLayout();
            pnlControls.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            toolStripStatusLabel1});
            statusStrip1.Location = new System.Drawing.Point(0, 472);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new System.Drawing.Size(649, 22);
            statusStrip1.TabIndex = 4;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlResults
            // 
            pnlResults.Controls.Add(dataGridView1);
            pnlResults.Controls.Add(button1);
            pnlResults.Controls.Add(groupBox1);
            pnlResults.Enabled = false;
            pnlResults.Location = new System.Drawing.Point(12, 106);
            pnlResults.Name = "pnlResults";
            pnlResults.Size = new System.Drawing.Size(624, 357);
            pnlResults.TabIndex = 8;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            iDDataGridViewTextBoxColumn,
            FechaEfectiva,
            nombreDataGridViewTextBoxColumn});
            dataGridView1.DataSource = feriadoBindingSource;
            dataGridView1.Location = new System.Drawing.Point(3, 19);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new System.Drawing.Size(246, 298);
            dataGridView1.TabIndex = 7;
            dataGridView1.SelectionChanged += new System.EventHandler(dataGridView1_SelectionChanged);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.ReadOnly = true;
            iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // FechaEfectiva
            // 
            FechaEfectiva.DataPropertyName = "FechaEfectiva";
            FechaEfectiva.HeaderText = "FechaEfectiva";
            FechaEfectiva.Name = "FechaEfectiva";
            FechaEfectiva.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            nombreDataGridViewTextBoxColumn.ReadOnly = true;
            nombreDataGridViewTextBoxColumn.Width = 140;
            // 
            // feriadoBindingSource
            // 
            feriadoBindingSource.DataMember = "Feriado";
            feriadoBindingSource.DataSource = typeof(ArgHolidays.MIFeriados.FeriadoDS);
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(504, 323);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(111, 23);
            button1.TabIndex = 8;
            button1.Text = "Export to csv File";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(button1_Click_1);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblOriginalDate);
            groupBox1.Controls.Add(lblEffectiveDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(lblDescriptionType);
            groupBox1.Controls.Add(lblDescription);
            groupBox1.Controls.Add(lblName);
            groupBox1.Location = new System.Drawing.Point(255, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new System.Drawing.Size(366, 314);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Details";
            // 
            // lblOriginalDate
            // 
            lblOriginalDate.AutoSize = true;
            lblOriginalDate.Location = new System.Drawing.Point(97, 146);
            lblOriginalDate.Name = "lblOriginalDate";
            lblOriginalDate.Size = new System.Drawing.Size(80, 13);
            lblOriginalDate.TabIndex = 6;
            lblOriginalDate.Text = "Fecha original";
            // 
            // lblEffectiveDate
            // 
            lblEffectiveDate.AutoSize = true;
            lblEffectiveDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEffectiveDate.Location = new System.Drawing.Point(97, 115);
            lblEffectiveDate.Name = "lblEffectiveDate";
            lblEffectiveDate.Size = new System.Drawing.Size(88, 15);
            lblEffectiveDate.TabIndex = 5;
            lblEffectiveDate.Text = "Fecha efectiva";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 146);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(72, 13);
            label2.TabIndex = 4;
            label2.Text = "Source Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 115);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(80, 13);
            label1.TabIndex = 3;
            label1.Text = "Effective Date:";
            // 
            // lblDescriptionType
            // 
            lblDescriptionType.AutoSize = true;
            lblDescriptionType.Location = new System.Drawing.Point(7, 79);
            lblDescriptionType.Name = "lblDescriptionType";
            lblDescriptionType.Size = new System.Drawing.Size(108, 13);
            lblDescriptionType.TabIndex = 2;
            lblDescriptionType.Text = "Tipo de Descripción";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDescription.Location = new System.Drawing.Point(7, 54);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new System.Drawing.Size(80, 16);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Descripción";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblName.Location = new System.Drawing.Point(6, 16);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(71, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Nombre";
            // 
            // pnlControls
            // 
            pnlControls.Controls.Add(lnkAboutBox);
            pnlControls.Controls.Add(lnkThisMonth);
            pnlControls.Controls.Add(lnkNextSixMonths);
            pnlControls.Controls.Add(lnkLastSixMonths);
            pnlControls.Controls.Add(lnkThisYear);
            pnlControls.Controls.Add(lblToDate);
            pnlControls.Controls.Add(lblFromDate);
            pnlControls.Controls.Add(btnGo);
            pnlControls.Controls.Add(dtDate2);
            pnlControls.Controls.Add(dtDate1);
            pnlControls.Location = new System.Drawing.Point(12, 12);
            pnlControls.Name = "pnlControls";
            pnlControls.Size = new System.Drawing.Size(624, 87);
            pnlControls.TabIndex = 9;
            // 
            // lnkThisMonth
            // 
            lnkThisMonth.AutoSize = true;
            lnkThisMonth.Location = new System.Drawing.Point(64, 7);
            lnkThisMonth.Name = "lnkThisMonth";
            lnkThisMonth.Size = new System.Drawing.Size(64, 13);
            lnkThisMonth.TabIndex = 20;
            lnkThisMonth.TabStop = true;
            lnkThisMonth.Text = "This month";
            lnkThisMonth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lnkThisMonth_LinkClicked);
            // 
            // lnkNextSixMonths
            // 
            lnkNextSixMonths.AutoSize = true;
            lnkNextSixMonths.Location = new System.Drawing.Point(218, 7);
            lnkNextSixMonths.Name = "lnkNextSixMonths";
            lnkNextSixMonths.Size = new System.Drawing.Size(81, 13);
            lnkNextSixMonths.TabIndex = 19;
            lnkNextSixMonths.TabStop = true;
            lnkNextSixMonths.Text = "Next 6 months";
            lnkNextSixMonths.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lnkNextSixMonths_LinkClicked);
            // 
            // lnkLastSixMonths
            // 
            lnkLastSixMonths.AutoSize = true;
            lnkLastSixMonths.Location = new System.Drawing.Point(134, 7);
            lnkLastSixMonths.Name = "lnkLastSixMonths";
            lnkLastSixMonths.Size = new System.Drawing.Size(78, 13);
            lnkLastSixMonths.TabIndex = 18;
            lnkLastSixMonths.TabStop = true;
            lnkLastSixMonths.Text = "Last 6 months";
            lnkLastSixMonths.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lnkLastSixMonths_LinkClicked);
            // 
            // lnkThisYear
            // 
            lnkThisYear.AutoSize = true;
            lnkThisYear.Location = new System.Drawing.Point(7, 7);
            lnkThisYear.Name = "lnkThisYear";
            lnkThisYear.Size = new System.Drawing.Size(51, 13);
            lnkThisYear.TabIndex = 17;
            lnkThisYear.TabStop = true;
            lnkThisYear.Text = "This Year";
            lnkThisYear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lnkThisYear_LinkClicked);
            // 
            // lblToDate
            // 
            lblToDate.AutoSize = true;
            lblToDate.Location = new System.Drawing.Point(269, 33);
            lblToDate.Name = "lblToDate";
            lblToDate.Size = new System.Drawing.Size(46, 13);
            lblToDate.TabIndex = 12;
            lblToDate.Text = "To Date";
            // 
            // lblFromDate
            // 
            lblFromDate.AutoSize = true;
            lblFromDate.Location = new System.Drawing.Point(7, 33);
            lblFromDate.Name = "lblFromDate";
            lblFromDate.Size = new System.Drawing.Size(60, 13);
            lblFromDate.TabIndex = 11;
            lblFromDate.Text = "From Date";
            // 
            // btnGo
            // 
            btnGo.Location = new System.Drawing.Point(540, 51);
            btnGo.Name = "btnGo";
            btnGo.Size = new System.Drawing.Size(75, 23);
            btnGo.TabIndex = 10;
            btnGo.Text = "Go!";
            btnGo.UseVisualStyleBackColor = true;
            btnGo.Click += new System.EventHandler(btnGo_Click);
            // 
            // dtDate2
            // 
            dtDate2.CustomFormat = "";
            dtDate2.Location = new System.Drawing.Point(272, 52);
            dtDate2.Name = "dtDate2";
            dtDate2.Size = new System.Drawing.Size(246, 22);
            dtDate2.TabIndex = 9;
            // 
            // dtDate1
            // 
            dtDate1.CustomFormat = "";
            dtDate1.Location = new System.Drawing.Point(10, 52);
            dtDate1.Name = "dtDate1";
            dtDate1.Size = new System.Drawing.Size(246, 22);
            dtDate1.TabIndex = 8;
            // 
            // lnkAboutBox
            // 
            lnkAboutBox.AutoSize = true;
            lnkAboutBox.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lnkAboutBox.Location = new System.Drawing.Point(586, 8);
            lnkAboutBox.Name = "lnkAboutBox";
            lnkAboutBox.Size = new System.Drawing.Size(29, 12);
            lnkAboutBox.TabIndex = 21;
            lnkAboutBox.TabStop = true;
            lnkAboutBox.Text = "About";
            lnkAboutBox.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(lnkAboutBox_LinkClicked);
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(649, 494);
            Controls.Add(pnlControls);
            Controls.Add(pnlResults);
            Controls.Add(statusStrip1);
            Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            Icon = ((System.Drawing.Icon)(resources.GetObject("$Icon")));
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Argentina Holidays";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            pnlResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(feriadoBindingSource)).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pnlControls.ResumeLayout(false);
            pnlControls.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

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

