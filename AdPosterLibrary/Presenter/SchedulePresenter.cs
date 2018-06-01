using System;
using System.Collections.Generic;
using AdPosterLibrary.Model;
using System.Diagnostics;

namespace AdPosterLibrary.Presenter
{
    public class SchedulePresenter
    {
        ISchedule scheduleview;
        public SchedulePresenter(ISchedule view)
        {
            scheduleview = view;
        }

       
        public List<string> GetStartMode()
        {

            List<string> mode = new List<string>();
            string[] Modes = new string[2] {
            "Visble(Foreground)",
            "Tray(Background)"
        };
            try
            {
                for (int i = 0; i < Modes.Length; i++)
                {
                    mode.Add(Modes[i]);
                   
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mode;
        }

        public List<string> GetExecuteModes()
        {

            List<string> mode = new List<string>();
            string[] Modes = new string[2] {
            "Start Now",
            "Schedule Start"
        };
            try
            {
                for (int i = 0; i < Modes.Length; i++)
                {
                    mode.Add(Modes[i]);

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return mode;
        }



        public void Run(string StartModeText, string outputfile)
        {
            if (StartModeText == "Start Now")
            {
               var Outputfile = @"C:\Users\Public\Documents\Task\" + outputfile + @".bat";
                var p = new ProcessStartInfo(Outputfile);
                p.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(p);
            }

            else
            {
                //MessageBox.Show("In a few easy steps you can fire away!!" & vbCrLf & vbCrLf & vbCrLf & "1. Select Create a Task" & vbCrLf & vbCrLf & "2. Give the task an name and description of you choice." & vbCrLf & vbCrLf & "3. Choose a Trigger." & vbCrLf & vbCrLf & "4. Choose an ACTION, select 'Start a program'." & vbCrLf & vbCrLf & "5. In the textbox under PROGRAM/SCRIPT " & vbCrLf & "    Type or Browse button to this file location: " & vbCrLf & "    " & outputFile & "" & vbCrLf & vbCrLf & "5. Click 'OK'" & vbCrLf & vbCrLf & vbCrLf & "For more information and options for the task scheduler:" & vbCrLf & "Google 'task scheduler overview'", "Task Scheduler");
                var p = new ProcessStartInfo(@"C:\Windows\System32\taskschd.msc");
                p.WindowStyle = ProcessWindowStyle.Hidden;
                Process.Start(p);
            }
        }

    }


}


