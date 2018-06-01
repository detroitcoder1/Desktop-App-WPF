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
using System.IO;

namespace AdPosterUI
{
    public partial class ImportForm : Form
    {
        private string browseText;

        public ImportForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            InputPresenter Input = new AdPosterLibrary.Presenter.InputPresenter();
            Input.Browse(OpenFileDialog1);
            browseText = Input.browseText;
            Input.GetData(DataGridView1, browseText);

        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InputPresenter Input = new AdPosterLibrary.Presenter.InputPresenter();
            Input.SaveFile(DataGridView1 );
        }
    }
}
