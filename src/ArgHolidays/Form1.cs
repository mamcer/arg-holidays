using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ArgHolidays
{
    public partial class Form1 : Form
    {
        MIFeriados.FeriadoDS _holidays;

        public MIFeriados.FeriadoDS Holidays 
        {
            get 
            {
                return _holidays;
            }
            set
            {
                _holidays = value;
            }
        }

        public Form1()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            dtDate1.Value = today;
            dtDate2.Value = today.AddMonths(6);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                DataRow[] dr = Holidays.Feriado.Select(string.Format("ID={0}",id));
                if (dr.Length > 0)
                {
                    lblName.Text = dr[0][3].ToString();
                    lblDescription.Text = dr[0][4].ToString();
                    lblDescriptionType.Text = dr[0][7].ToString();
                    lblEffectiveDate.Text = ((DateTime)dr[0][2]).ToLongDateString();
                    lblOriginalDate.Text = ((DateTime)dr[0][1]).ToLongDateString();
                }
            }
        }

        private void lblEffectiveDate_Click(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            pnlControls.Enabled = false;
            MIFeriados.MyServiceClient client = new ArgHolidays.MIFeriados.MyServiceClient();
            Holidays = client.FeriadosEntreFechas(dtDate1.Value, dtDate2.Value);
            if (Holidays.Feriado.Rows.Count > 0)
            {
                pnlResults.Enabled = true;
            }

            dataGridView1.DataSource = Holidays.Feriado;
            pnlControls.Enabled = true;
            Cursor = Cursors.Default;
            statusStrip1.Items[0].Text = string.Format("Total: {0} holidays", Holidays.Feriado.Rows.Count);
        }

        private void lnkThisYear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime today = DateTime.Today;
            dtDate1.Value = new DateTime(today.Year,1,1);
            dtDate2.Value = new DateTime(today.Year, 12, 31);
        }

        private void lnkThisMonth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime today = DateTime.Today;
            dtDate1.Value = new DateTime(today.Year, today.Month, 1);
            dtDate2.Value = new DateTime(today.Year, today.Month, DateTime.DaysInMonth(today.Year, today.Month));
        }

        private void lnkLastSixMonths_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime today = DateTime.Today;
            dtDate1.Value = today.AddMonths(-6);
            dtDate2.Value = today;
        }

        private void lnkNextSixMonths_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DateTime today = DateTime.Today;
            dtDate1.Value = today;
            dtDate2.Value = today.AddMonths(6);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (DataRow dr in Holidays.Feriado.Rows)
                {
                    for (int i = 0; i < Holidays.Feriado.Columns.Count; i++)
                    {
                        if (i != 5)
                        {
                            sw.Write(dr[i].ToString() + ",");
                        }
                    }

                    sw.Write(sw.NewLine);
                }

                sw.Close();
            }
        }

        private void lnkAboutBox_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
    }
}