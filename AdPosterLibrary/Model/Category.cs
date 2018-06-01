using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;




namespace AdPosterLibrary.Model
{
    public class Category 
    {
        
        public List <string> FileNames { get; set; }
        public List <string> Cities { get; set; }
        public List <string> States { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        public string File { get; set; }
        public string City{ get; set; }
        public string State { get; set; }


        public Category()
        {
            FileNames = new List<string>();
            Cities = new List<string>();
            States = new List<string>();
        }

    }


}
