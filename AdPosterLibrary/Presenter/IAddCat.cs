using System.Collections.Generic;
using AdPosterLibrary.Model;

namespace AdPosterLibrary.Presenter
{
    public interface IAddCat
    {
        List<string> FileList { get; set; }
        List<string> CityList { get; set; }
        List<string>  StateList{ get; set; }
        string EmailText { get; set; }
        string PasswordText { get; set; }
        string FileText { get; set; }
        string CityText { get; set; }
        string StateText { get; set; }
    }
}