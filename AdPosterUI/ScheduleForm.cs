using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdPosterLibrary.Presenter;
using AdPosterLibrary.Model;
using AdPosterUI.Views;
using System.Diagnostics;

namespace AdPosterUI
{
    public partial class ScheduleForm : Form, ISchedule
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }

        public string StartModeText
        {
            get
            {
                return cboStartMode.SelectedItem.ToString();
            }

            set { }
        }
        public string ExecuteModeText
        {
            get
            {
                return cboExecute.SelectedItem.ToString();
            }

            set { }
        }
        public int StartNumberInt
        {
            get
            {
                Int32.TryParse(txtStrtNo.Text, out int StartNumber);
                return StartNumber;
            }

            set { }
        }
        public int NumberofPostInt
        {
            get
            {
                Int32.TryParse(txtNumber.Text, out int NumberofPost);
                return NumberofPost;
            }

            set { }
        }
        public string SelectedFileText
        {
            get
            {
                return chkSelect.Text.ToString();
            }

            set { }
        }
        public List<string> ExecuteList
        {
            get
            {
                SchedulePresenter schedule = new SchedulePresenter(this);
                List<string> ExecuteList = schedule.GetStartMode();
                return ExecuteList;
            }
            set
            {
                foreach (var item in ExecuteList)
                {
                    cboExecute.Items.Add(item);
                }
            }
        }
        public List<string> StartList
        {
            get
            {
                SchedulePresenter schedule = new SchedulePresenter(this);
                ////string StartModeText = cboStartMode.SelectedItem.ToString();
                List<string> StartList = schedule.GetExecuteModes();
                return StartList;
            }
            set
            {
                foreach (var item in StartList)
                {
                    cboStartMode.Items.Add(item);
                }
            }
        }
        public List<string> FileTextList
        {
            get
            {
                List<string> FileTextList = new List<string>();
                foreach (var item in chkSelect.CheckedItems)
                {

                    FileTextList.Add(item.ToString());
                };

                return FileTextList;
            }
            set { }

        }
        public bool FhaCheck
        {
            get
            {
                if (this.chkFHA.Checked == true)
                {
                    return true;
                }
                return false;
            }

            set { }
        }
        public bool Courtesy
        {
            get
            {
                if (chkCourtesy.Checked == true)
                {
                    return true;
                }
                return false;
            }

            set { }
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {

            SchedulePresenter schedule = new SchedulePresenter(this);
            StartList = new List<string>();
            ExecuteList = new List<string>();



        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            FileWriter fw = new FileWriter();
            ValidateStartNumber();
            fw.WriteFile(NumberofPostInt, StartNumberInt, SelectedFileText, FhaCheck);
            fw.WriteFile(NumberofPostInt, FileTextList, FhaCheck, SelectedFileText, ExecuteModeText);
            SchedulePresenter schedule = new SchedulePresenter(this);
            schedule.Run(StartModeText, SelectedFileText);
        }


        private void ValidateStartNumber()
        {
            Int32.TryParse(chkSelect.Text, out int x);
            if (chkSelect.Text == String.Empty)
            {
                MessageBox.Show("Add a file from the Post Home window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtStrtNo.Text == String.Empty || x < 0)
            {
                MessageBox.Show("Add a file from the Post Home window", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            CategoryForm form = new CategoryForm();
            form.Show();


        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < chkSelect.Items.Count - 1; i++)
            {
                chkSelect.SetItemChecked(i, false);
                chkSelect.SetSelected(i, false);
            }

            txtNumber.Clear();
            txtStrtNo.Clear();
            StartModeText = "d";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Process[] prosess = Process.GetProcessesByName("bpo5000");

            foreach (var p in prosess)
            {
                p.Kill();
            }
        }
    }
}
