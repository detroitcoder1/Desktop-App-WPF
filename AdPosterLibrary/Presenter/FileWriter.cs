using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AdPosterLibrary.Presenter
{
    public class FileWriter
    {
        string messageType;
        public string message { get { return messageType; } set { messageType = value; } }

        //update  .iim datafile from start button on schedule form
        public string WriteFile(int NumPost, int StartNum, string FileText, bool FhaCheck)
        {
            string testCheck = "SET !VAR1";

            string notExist = "notExist";
            string saved = "saved";
            string wrongFile = "wrongFile ";
            string strtNum = Convert.ToString(StartNum);
            List<String> list = new List<string>();
            string dataFile = @"C:\Users\Public\Documents\AdBlazer\Post\" + FileText;
            try
            {
                if (!File.Exists(dataFile))
                {
                    messageType = notExist;
                };
                using (var fileStream = File.OpenRead(dataFile))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true))
                {
                    int loc1;
                    int loc2;
                    int stringToRemove;
                    string fhaString = "<hr><SP>FHA<SP>Financing<SP>Available<hr><B>Monthly<SP>Payment<B><SP>as<SP>Low<SP>as:<SP>${{!COL25}}<BR>Only<SP>${{!COL26}}<SP>Down*<BR>Seller<SP>can<SP>pay<SP>up<SP>to<SP>${{!COL27}}<SP>towards<SP>closing<SP>cost<SP>and<SP>fees.";
                    string courtesyString = "<BR>|Courtesy<SP>of<SP>{{!COL10}}|";
                    string line;
                    while ((line = streamReader.ReadLine()) != null)
                        if (FileText.StartsWith("mail") || FileText.Contains("delete"))
                        {
                            while (line.Contains(""))
                            {
                                if (line.Contains(testCheck))
                                {
                                    line = "SET !LOOP " + strtNum;
                                }
                                if (line.Contains("TYPE = LABEL"))
                                {
                                    line = "TAG POS=1 TYPE=LABEL ATTR=TXT:{{!COL5}}*";
                                }
                                if (FhaCheck == true & FileText.Contains("Sale") & line.Contains("PostingBody") & !line.Contains("Payment"))
                                {
                                    line = line + fhaString;
                                }
                                if ((FhaCheck == true & FileText.Contains("Sale") & line.Contains("description") & !line.Contains("Payment")))
                                {
                                    line = line + fhaString;
                                }
                                if (FhaCheck == false & line.Contains("Payment"))
                                {
                                    loc1 = line.IndexOf("<hr><SP>FHA");
                                    loc2 = line.LastIndexOf(".");
                                    stringToRemove = loc2 - (loc1 - 1);
                                    line = line.Remove(loc1, stringToRemove);
                                }
                                if (FhaCheck == true & line.Contains("PostingBody") & !line.Contains("Courtesy"))
                                {
                                    line = line + courtesyString;
                                }
                                if (FhaCheck == true & line.Contains("description") & !line.Contains("Courtesy"))
                                {
                                    line = line + courtesyString;
                                }
                                if (FhaCheck == false & line.Contains("Courtesy"))
                                {
                                    loc1 = line.LastIndexOf("|");
                                    loc2 = line.IndexOf("<BR>|");
                                    stringToRemove = loc1 - (loc2 - 1);
                                    line = line.Remove(loc2, stringToRemove);
                                }
                                list.Add(line += Environment.NewLine);
                                line = streamReader.ReadLine();
                            }
                        }
                }
                //'write updated file and save
                using (var streamWriter = new StreamWriter(dataFile))
                    foreach (var line in list)
                    {
                        streamWriter.Write(line);
                    }
                messageType = saved;
            }
            catch (Exception)
            {
                messageType = wrongFile;
            }
            return messageType;
        }

        //override to write batch file with extension
        public void WriteFile(int NumPost, List<string> FileTextList, bool FhaCheck, string SelectedFileText, string ExecuteModeText)
        {
            string notExist = "notExist";
            string saved = "saved";
            string wrongFile = "wrongFile ";
            string suffix = ".iim";
            string bsuffix = ".bat";
            string macro;
            string testCheck = "TestString.iim";
            string num = "- loop 5";
            string category = SelectedFileText;
            string strtNum = Convert.ToString(NumPost);
            string file = SelectedFileText + bsuffix;
            string outputfile = @"C:\Users\Public\Documents\Task\" + file;

            //'Mandatory file that starts string replacements(only file needed in the task folder)
            string dataFile = @"C:\Users\Public\Documents\Task\batch.bat";
            List<String> list = new List<string>();
            try
            {
                foreach (var item in FileTextList)
                {
                    
                    if (!File.Exists(dataFile))
                    {
                        messageType = notExist;
                    };
                    macro = item.ToString();
                    using (var fileStream = File.OpenRead(dataFile))
                    using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true))
                    {
                        string line;

                        while ((line = streamReader.ReadLine()) != null)
                          
                            {

                            

                                    if (line.Contains(testCheck))
                                    {
                                        line = line.Replace(testCheck.ToString(), macro);
                                        line = line.Replace(num.ToString(), "-loop " + NumPost);
                                        //'if statement to check for silent posting
                                    }
                                    if (ExecuteModeText == "Tray(Background)" & line.Contains(macro))
                                    {
                                        line = line = String.Concat(line, " -silent");
                                    }
                        

                        //for (int i = 0; i < 11; i++)
                        //        {
                                    list.Add(line += Environment.NewLine);
                                    line = streamReader.ReadLine();
                                //}
                        }
                    }
                }
                //'write updated file and save
                using (var streamWriter = new StreamWriter(outputfile))
                    foreach (var line in list)
                    {
                        streamWriter.Write(line);
                    }
                messageType = saved;

            }
            catch (Exception)
            {
                messageType = wrongFile;
            }


        }
    }
}



