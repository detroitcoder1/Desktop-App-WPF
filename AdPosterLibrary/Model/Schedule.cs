using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdPosterLibrary.Model
{
    public class Schedule
    {
        public string StartMode { get; set; }
        public string ExecuteMode { get; set; }
        public string    StartNumber { get; set; }
        public string NumberofPost { get; set; }
        public string sFile {get; set; }
        List<string> ExecuteList{ get; set; }
        List<string> StartList { get; set; }
        List<string> FileTextList { get; set; }

        public Schedule()
        {
            StartNumber = "1";
            ExecuteMode = "Visible";
            NumberofPost = "1";
            ExecuteList = new List<string>();
            StartList = new List<string>();
            FileTextList = new List<string>();
        }

}
}
