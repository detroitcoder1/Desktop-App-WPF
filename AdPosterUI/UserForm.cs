using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdPosterLibrary.Model;
using AdPosterLibrary.Presenter;


namespace AdPosterUI
{
    public partial class UserForm : Form
    {
        string ConnectionString = string.Empty;
        public UserForm()
        {
            InitializeComponent();
        }

       

        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void bntClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            Properties.Settings.Default.Name = txtName.Text;
            Properties.Settings.Default.State = txtState.Text;
            Properties.Settings.Default.Phone = txtPhone.Text;
            Properties.Settings.Default.Remarks = txtRemarks1.Text;
            Properties.Settings.Default.City = txtCity.Text;
            Properties.Settings.Default.Remarks = txtRemarks2.Text;
            Properties.Settings.Default.Info = txtInfo.Text;
            Properties.Settings.Default.Save();
           

        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            txtName.Text = Properties.Settings.Default.Name;
            txtState.Text = Properties.Settings.Default.State;
            txtPhone.Text = Properties.Settings.Default.Phone;
            txtRemarks1.Text = Properties.Settings.Default.Remarks;
            txtRemarks2.Text = Properties.Settings.Default.Remarks2;
            txtCity.Text = Properties.Settings.Default.City;
            txtInfo.Text = Properties.Settings.Default.Info;

         
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
        }
    }
}
