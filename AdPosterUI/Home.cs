using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdPosterUI.Views;


namespace AdPosterUI
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)

        {
            this.Visible = false;
            CategoryForm form = new CategoryForm();
            form.Show();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ScheduleForm form = new ScheduleForm();
            form.Show();
            
        }

        private void btnUserSet_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            UserForm user = new UserForm();
            user.Show();
            
        }

        private void btnViewTasks_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ImportForm import = new ImportForm();
            import.Show();
        }
    }
}
