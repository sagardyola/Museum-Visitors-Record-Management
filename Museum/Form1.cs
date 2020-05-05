using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Museum
{
    public partial class Form1 : Form
    {
        String csvPath = "Records.csv";
        List<Visitor> visitorList = new List<Visitor>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            DateTime dateValue = DateTime.Now;
            int dayCheck = (int)dateValue.DayOfWeek;
            String timeCheck = dateValue.ToString("HH");

            if ((dayCheck > 0 && dayCheck <6) && (int.Parse(timeCheck) > 9 && int.Parse(timeCheck) < 17))
            {

                Visitor v = new Visitor();

                if (txtFName.Text != "" && txtLName.Text != "" && txtEmail.Text != "" && txtContact.Text != "" && txtOccupation.Text != "")
                {
                    if (lblCardNoValue.Text.Equals(""))
                    {
                        Random r = new Random();
                        v.cardNo = r.Next(1000, 9999);
                        lblCardNoValue.Text = v.cardNo.ToString();
                    }
                    else
                    {
                        v.cardNo = int.Parse(lblCardNoValue.Text);
                    }

                    v.day = DateTime.Now;

                    v.firstName = txtFName.Text.ToString();
                    v.lastName = txtLName.Text.ToString();
                    v.email = txtEmail.Text.ToString();
                    v.contact = txtContact.Text.ToString();
                    v.occupation = txtOccupation.Text.ToString();
                    v.inTime = DateTime.Now;

                    visitorList.Add(v);

                    //Save file
                    String visitorInfo = v.cardNo + "," + v.firstName + "," + v.lastName + "," + v.email + "," + v.contact + "," + v.occupation + "," + v.inTime + ",";
                    saveVisitor(visitorInfo);

                    //Check Report type
                    dataGridType();

                    //Messagebox
                    MessageBox.Show("Welcome " + v.firstName + ".\nYour Card Number is " + v.cardNo, "Record Added Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClear_Click(null, null);
                    randomNumber();
                }
                else
                {
                    MessageBox.Show("The given fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("Sorry. The Museum is closed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void randomNumber()
        {
            Random r = new Random();
            lblCardNoValue.Text = r.Next(1000, 9999).ToString();
        }

        private void saveVisitor(String visitorInfo)
        {
            using (StreamWriter writer = new StreamWriter(csvPath, append: true))
            {
                writer.WriteLine(visitorInfo);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtContact.Text = "";
            txtOccupation.Text = "";
        }

        static DataTable listToDataTable(List<Visitor> visitorList)
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Day");
            dt.Columns.Add("Card Number");
            dt.Columns.Add("Name");
            dt.Columns.Add("Email");
            dt.Columns.Add("Contact");
            dt.Columns.Add("Occupation");
            dt.Columns.Add("In Time");
            dt.Columns.Add("Out Time");
            dt.Columns.Add("Duration (mins)");

            foreach (var item in visitorList)
            {
                var row = dt.NewRow();
                DateTime dateValue = item.inTime;
                DateTime dateValue2 = item.outTime;

                row["Day"] = dateValue.DayOfWeek;
                row["Card Number"] = item.cardNo;
                row["Name"] = item.firstName + " " + item.lastName;
                row["Email"] = item.email;
                row["Contact"] = item.contact;
                row["Occupation"] = item.occupation;
                row["In Time"] = dateValue.ToString("hh: mm: ss tt");

                //Check null value
                DateTime? dtime = null;
                var dateV = dtime.GetValueOrDefault();

                if (!item.outTime.Equals(dateV))
                {
                    row["Out Time"] = dateValue2.ToString("hh: mm: ss tt");
                    row["Duration (mins)"] = item.duration;
                }
                dt.Rows.Add(row);
            }
            return dt;
        }

        private List<Visitor> GetCSVData(String csvPath)
        {
            if (File.Exists(csvPath))
            {
                using (var reader = new StreamReader(csvPath))
                {
                    while (!reader.EndOfStream)
                    {
                        Visitor v = new Visitor();
                        var line = reader.ReadLine();
                        var values = line.Split(',');

                        v.day = Convert.ToDateTime(values[6]);
                        v.cardNo = int.Parse(values[0]);
                        v.firstName = Convert.ToString(values[1]);
                        v.lastName = Convert.ToString(values[2]);
                        v.email = Convert.ToString(values[3]);
                        v.contact = Convert.ToString(values[4]);
                        v.occupation = Convert.ToString(values[5]);
                        v.inTime = Convert.ToDateTime(values[6]);
                        
                        //Check if there is outime
                        if (!values[7].Equals(""))
                        {
                            v.outTime = Convert.ToDateTime(values[7]);
                            TimeSpan span = v.outTime.Subtract(v.inTime);
                            v.duration = Convert.ToInt32(span.TotalMinutes);
                        }
                        visitorList.Add(v);
                    }
                }
            }
            return visitorList;
        }

        private void sortRecords(List<Visitor> visitorList)
        {
            DataTable tableFirst = listToDataTable(visitorList);
            int length = visitorList.Count;
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length - 1; j++)
                {
                    if (visitorList[j].cardNo > visitorList[j + 1].cardNo)
                    {
                        Visitor v = visitorList[j + 1];
                        visitorList[j + 1] = visitorList[j];
                        visitorList[j] = v;
                    }
                }
            }
            DataTable dt = listToDataTable(visitorList);
            dataGridView1.DataSource = dt;
        }

        private void txtCardNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            randomNumber();
            comboReportType.SelectedIndex = 0;
            GetCSVData(csvPath);
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnCardNoExit_Click(object sender, EventArgs e)
        {
            int count = 0;
            if (!txtCardNoExit.Text.Equals(""))
            {
                try
                {
                    Visitor v = visitorList.Where(x => x.cardNo == int.Parse(txtCardNoExit.Text)).FirstOrDefault();
                    int lineToChange = -1;
                    for (int i = 0; i < visitorList.Count; i++)
                    {
                        using (StreamReader file = new StreamReader(csvPath))
                        {
                            for (int indexCount = 0; !file.EndOfStream; indexCount++)
                            {
                                string[] column = file.ReadLine().Split(',');
                                if (column[0].Equals(v.cardNo.ToString()) && column[7] == "")
                                {
                                    lineToChange = indexCount;
                                }
                            }
                        }

                        if (lineToChange != -1)
                        {
                            string[] arrLine = File.ReadAllLines(csvPath);
                            string[] newColumn = arrLine[lineToChange].Split(',');
                            int a = newColumn.Length - 1;
                            newColumn[a] = DateTime.Now.ToString();
                            string newLine = String.Join(",", newColumn);
                            arrLine[lineToChange] = newLine;
                            File.WriteAllLines(csvPath, arrLine);

                            v.outTime = DateTime.Parse(newColumn[a]);
                            TimeSpan span = DateTime.Parse(newColumn[a]).Subtract(v.inTime);
                            v.duration = Convert.ToInt32(span.TotalMinutes);

                            count = 1;
                        }
                    }

                    dataGridType();

                    if (count == 0)
                    {
                        MessageBox.Show("Record not found.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Have a good day " + v.firstName + ".", "Visitor Departured", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex)
                {
                    MessageBox.Show("Invalid Input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("The given fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog()
            {
                Title = "Browse CSV Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "csv",
                Filter = "csv files (*.csv)|*.csv",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtBrowse.Text = openFileDialog1.FileName;

                var result = MessageBox.Show("Are you sure you want to import?", "Import File", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    GetCSVData(openFileDialog1.FileName);
                    dataGridType();

                    //Combine Two files
                    File.AppendAllText(csvPath, File.ReadAllText(openFileDialog1.FileName));
                    MessageBox.Show("Successfully imported.", "Imported", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnCardNoOld_Click(object sender, EventArgs e)
        {
            if (!txtCardNoOld.Text.Equals(""))
            {
                try {
                
                    Visitor v = visitorList.Where(x => x.cardNo == int.Parse(txtCardNoOld.Text)).FirstOrDefault();
                    if (v != null)
                    {
                        lblCardNoValue.Text = v.cardNo.ToString(); ;
                        txtFName.Text = v.firstName.ToString();
                        txtLName.Text = v.lastName.ToString();
                        txtEmail.Text = v.email.ToString();
                        txtContact.Text = v.contact.ToString();
                        txtOccupation.Text = v.occupation.ToString();
                    } else
                    {
                        MessageBox.Show("Record not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show("Invalid Input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                MessageBox.Show("The given fields cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //txtCardNoOld.Text = "";
        }

        private void dailyReport()
        {
            //Clear data grid
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            var vi = visitorList.Where(x => x.inTime.Date == dateTimePicker1.Value.Date);
            sortRecords(vi.ToList());

            int totalVisitors = vi.Select(x => x.cardNo).Distinct().Count();
            int totalDuration = vi.Sum(x => x.duration);
            lblTotalVisitorsNum.Text = totalVisitors.ToString();
            lblTotalDurationNum.Text = totalDuration.ToString() + " minutes";
        }

        private void weeklyReport()
        {
            //Clear data grid
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Refresh();

            //get current datetime 
            DateTime date = dateTimePicker1.Value;

            //get year from the date
            int year = date.Date.Year;

            //set the first day of the year
            DateTime firstDay = new DateTime(year, 1, 1);

            //get Day of the week 
            DayOfWeek day = date.DayOfWeek;

            CultureInfo cul = CultureInfo.CurrentCulture;

            //get no of week for the date
            int weekNo = cul.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Sunday);

            //get no of day
            int days = (weekNo - 1) * 7;
            DateTime dt1 = firstDay.AddDays(days);
            DayOfWeek dow = dt1.DayOfWeek;
            DateTime startDateOfWeek = dt1.AddDays(-(int)dow);
            DateTime endDateOfWeek = startDateOfWeek.AddDays(6);

            chartVisitors.Series.Clear();
            chartDuration.Series.Clear();

            var chartTotalV = chartVisitors.Series.Add("Total Visitors");
            var chartTotalD = chartDuration.Series.Add("Total Duration");

            dataGridView1.Columns.Add("Day", "Day");
            dataGridView1.Columns.Add("Total Visitor", "Total Visitor");
            dataGridView1.Columns.Add("Total Time Spent", "Total Time Spent");

            for (int i = 1; i < 6; i++)
            {
                DateTime count = (startDateOfWeek.AddDays(i));

                var v = visitorList.Where(x => x.day.Date == count.Date);
                int totalVis = v.Select(x => x.cardNo).Distinct().Count();
                int totalDur = v.Sum(x => x.duration);

                DateTime temp = Convert.ToDateTime(count);
                String newDOW = Convert.ToString(temp.DayOfWeek);

                dataGridView1.Rows.Add(newDOW, totalVis, totalDur);
                this.dataGridView1.Sort(this.dataGridView1.Columns["Total Visitor"], ListSortDirection.Ascending);

                chartTotalV.Points.AddXY(newDOW, totalVis);
                chartTotalD.Points.AddXY(newDOW, totalDur);
            }

        }

        private void dataGridType()
        {
            switch (comboReportType.SelectedIndex)
            {
                case 0:
                    //Daily Report
                    dailyReport();
                    break;

                case 1:
                    //Weekly Report
                    weeklyReport();
                    break;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dataGridType();
        }

        private void comboReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboReportType.SelectedIndex)
            {
                case 0:
                    //Daily Report

                    lblChartVisitors.Visible = false;
                    chartVisitors.Visible = false;
                    lblChartDuration.Visible = false;
                    chartDuration.Visible = false;

                    lblTotalVisitors.Visible = true;
                    lblTotalDuration.Visible = true;
                    lblTotalVisitorsNum.Visible = true;
                    lblTotalDurationNum.Visible = true;

                    lblDailyInfo.Visible = true;
                    dailyReport();
                    break;

                case 1:
                    //Weekly Report

                    lblChartVisitors.Visible = true;
                    chartVisitors.Visible = true;
                    lblChartDuration.Visible = true;
                    chartDuration.Visible = true;

                    lblTotalVisitors.Visible = false;
                    lblTotalDuration.Visible = false;
                    lblTotalVisitorsNum.Visible = false;
                    lblTotalDurationNum.Visible = false;

                    lblDailyInfo.Visible = false;
                    weeklyReport();
                    break;
            }
        }
    }
}