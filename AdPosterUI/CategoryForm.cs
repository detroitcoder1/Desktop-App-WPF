using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdPosterLibrary.Model;
using AdPosterLibrary.Presenter;
using System.Windows.Forms;
using System.IO;




namespace AdPosterUI.Views
{
    public partial class CategoryForm : Form, IAddCat
    {
        public CategoryForm()
        {
            InitializeComponent();

        }

        public List<string> FileList
        {
            get
            {
                CategoryPresenter presenter = new CategoryPresenter(this);
                List<string> FileList = presenter.GetCategories();
                return FileList;
            }
            set
            {
                foreach (var item in FileList)
                {
                    cboCategory.Items.Add(item);
                }
            }
        }
        public List<string> CityList
        {
            get
            {
                CategoryPresenter presenter = new CategoryPresenter(this);
                string StateText = cboState.SelectedItem.ToString();
                List<string> CityList = presenter.GetCity(StateText);
                return CityList;
            }
            set
            {
                foreach (var item in CityList)
                {
                    cboCity.Items.Add(item);
                }
            }
        }
        public List<string> StateList
        {
            get
            {
                CategoryPresenter presenter = new CategoryPresenter(this);
                List<string> StateList = presenter.GetStates();
                return StateList;
            }
            set
            {
                foreach (var item in StateList)
                {
                    cboState.Items.Add(item);
                }
            }
        }
        public string EmailText
        {
            get
            {
                return txtEmail.Text.ToString();
            }

            set { }
        }
        public string PasswordText
        {
            get
            {
                return txtPassword.Text.ToString();
            }
            set { }
        }
        public string CityText
        {
            get
            {
                return cboCity.SelectedItem.ToString();
            }
            set { }
        }
        public string StateText
        {
            get
            {
                return cboState.SelectedItem.ToString();
            }
            set { }

        }
        public string FileText
        {
            get
            {
                return cboCategory.SelectedItem.ToString();
            }

            set { }
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            CategoryPresenter presenter = new CategoryPresenter(this);
            FileList = new List<string>();
            StateList = new List<string>();
            presenter.GetCategories();
            presenter.GetStates();

        }
        private void cboState_SelectedIndexChanged(object sender, EventArgs e)
        {
            CategoryPresenter presenter = new CategoryPresenter(this);
            CityList = new List<string>();
            string StateText = cboState.SelectedItem.ToString();
            string FileText = cboCategory.SelectedItem.ToString();
            presenter.GetCity(StateText);
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            CategoryPresenter presenter = new CategoryPresenter(this);
            VaildateUserInput ValidateUser = new VaildateUserInput();
            presenter.WriteFile(FileText, PasswordText, EmailText, CityText);
            if (!ValidateUser.ValidateInput(FileText, StateText, PasswordText, EmailText))

            {
                MessageBox.Show(("Must contain a value"), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Error Messages for category form
                string messageType = presenter.message;
                switch (messageType)
                {
                case "saved":
                    MessageBox.Show("Settings Saved");
                    break;
                case "noExist":
                   MessageBox.Show("Input file does not exist");
                    break;
                case "wrongFile":
                    MessageBox.Show("Please select the correct file");
                    break;
            }
            ScheduleForm schedule = new ScheduleForm();
            schedule.chkSelect.Items.Add(FileText);
            schedule.Show();



        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            Home home = new Home();
            home.Show();
        }
    }
}
