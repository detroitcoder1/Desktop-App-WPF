using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdPosterLibrary.Model;
using System.IO;

namespace AdPosterLibrary.Presenter
{
    public class VaildateUserInput
    {


        public bool ValidateInput(string FileText, string StateText, string Password, string EmailText)
        {
            string txtEmail = EmailText;
            string txtPassword = Password;
            string txtState = StateText;
            //only testing for empty strings
                if (txtEmail.ToString() == String.Empty || FileText.ToString() == String.Empty)
                {
                    return false;
                }
            // //validate user input for combo boxes
            if (txtPassword.Contains("Enter") || txtState.Contains("Enter"))
                {
                return false;
                }
            return true;
        }

    }
}
