using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdPosterLibrary.Model;

namespace AdPosterLibrary.Presenter
{
   public interface ISchedule
    {
        string StartModeText { get; set; }
        string ExecuteModeText { get; set; }
        int StartNumberInt { get; set; }
        int NumberofPostInt { get; set; }
        string SelectedFileText { get; set; }
        List<string> ExecuteList { get; set; }
        List<string> StartList { get; set; }
        List<string> FileTextList { get; set; }
    }
}
