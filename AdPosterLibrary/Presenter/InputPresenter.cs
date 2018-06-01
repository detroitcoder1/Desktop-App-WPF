using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Data;

namespace AdPosterLibrary.Presenter
{
    public class InputPresenter
    {
        public string browseText;

        public string Browse(OpenFileDialog openFile)
        {
            try
            {
                openFile = new OpenFileDialog();
                openFile.Filter = "Comma Seperated documents (.csv)|*.csv|text documents (.txt)|*.txt|Excel documents (.xls)|*.xls";
                openFile.DefaultExt = ".csv,.txt";
                if (openFile.ShowDialog() == DialogResult.OK)

                {

                    browseText = openFile.FileName;

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            return browseText;
        }

        public void GetData(DataGridView dgv, string browseText)
        {
            String textLine = string.Empty;
            String[] currentRows;

            // clear the grid view

            dgv.SuspendLayout();

            dgv.Rows.Clear();
            try
            {
                if (System.IO.File.Exists(browseText))
                {
                    System.IO.StreamReader objReader = new System.IO.StreamReader(browseText);


                    string currentLine = objReader.ReadLine();
                    currentRows = currentLine.Split(',');

                    foreach (var row in currentRows)
                    {
                        dgv.Columns.Add(row.ToString(), row.ToString());
                    }

                    do
                    {
                        currentRows = Regex.Split(objReader.ReadLine(), @",(?=(?:[^""]*""[^""]*"")*(?![^""]*""))");
                        dgv.Rows.Add(currentRows.ToArray());
                    }
                    while (objReader.Peek() != -1);
                }
            }
            catch (Exception)
            {

                //'display message
           // MsgBox("File is being used by another process");
           return;
            }
        
        }

        public void SaveFile(DataGridView dgv)
        {
            string StrExport = "";

            foreach (DataGridViewColumn C in dgv.Columns)
            {

                StrExport = string.Concat(" ", StrExport,C.HeaderText,",");
               
            }
            StrExport = StrExport.Substring(0, (StrExport.Length - 1));
            StrExport += Environment.NewLine;

            foreach (DataGridViewRow R in dgv.Rows)
            {
                foreach (DataGridViewCell C in R.Cells)
                {
                    if (!(C.Value == null))
                    {
                        StrExport = string.Concat(StrExport ,"", C.Value, ",");

                            
                    }
                    else
                    {
                        StrExport = string.Concat(StrExport,"", "", ",");
                    }
                }
                StrExport = StrExport.Substring(0, StrExport.Length - 1);
                StrExport += Environment.NewLine;

            }
            string folder = @"C:\Users\Public\Documents\AdBlazer\Datasources\";
            string outputfile = @"C:\Users\Public\Documents\AdBlazer\Datasources\rento.csv";
            try
            {
                System.IO.TextWriter tw = new System.IO.StreamWriter(outputfile);
                tw.Write(StrExport);
                tw.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }

}

