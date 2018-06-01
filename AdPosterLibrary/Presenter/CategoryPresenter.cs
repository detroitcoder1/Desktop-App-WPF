using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdPosterLibrary.Model;
using System.IO;
namespace AdPosterLibrary.Presenter
{
    public class CategoryPresenter
    {
        IAddCat categoryview;
        public CategoryPresenter(IAddCat view)
        {
            categoryview = view;
        }
        Category category = new Category();
        string messageType;
        public string message { get { return messageType; } set { messageType = value; }}
        //add list items to category combobox.
        public List<string> GetCategories()
        {
            
            var file = @"C:\\Users\\Public\\Documents\\AdBlazer\\Post\\";
            try
            {
                DirectoryInfo Dir = new DirectoryInfo(file);
                FileInfo[] FileList = Dir.GetFiles("*.iim", SearchOption.AllDirectories);
                foreach (FileInfo FI in FileList)
                {
                    category.FileNames.Add(FI.Name);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return category.FileNames;
        }
        public List<string> GetStates()
        {


            Category category = new Category();
            string[] States = new string[49] {
            "Alaska",
            "Arizona",
            "Alabama",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "District of Columbia",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "NewHampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"
        };
            try
            {
                
                for (int i = 0; i < States.Length; i++)
                {
                    category.States.Add(States[i]);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return category.States;
        }
        public List<string> GetCity(string value)
        {
            Category category = new Category();
            string[] Alaska = new string[3] { "Anchorage", "Fairbanks", "Juneau" };
            string[] Arizona = new string[9] { "Flagstaff", "Mohave", "Count", "Phoenix", "Prescott", "Showlow", "Sierravista", "Tucson", "Yuma" };
            string[] Alabama = new string[9] { "Auburn", "Birmingham", "Dothan", "Shoals", "Gadsden-Anniston", "Huntsville / Decatur", "Mobile", "Montgomery", "Tuscaloosa" };
            string[] Arkansas = new string[5] { "Fayetteville", "Fort Smith", "Jonesboro", "Littlerock", "Texarkana" };
            string[] California = new string[28] { "Bakersfield", "Chico", "Fresno / Madera", "Gold", "Hanford", "Humboldt", "Imperial", "Inlandempire", "Losangeles", "Mendocino", "Merced", "Modesto", "Monterey", "Orangecounty", "Palmsprings", "Redding", "Sacramento", "Sandiego", "Sfbayarea", "Sanluisobispo", "Santabarbara", "Santamaria", "Siskiyou", "Stockton", "Susanville", "Ventura", "Visalia-Tulare", "Yuba-Sutter" };
            string[] Colorado = new string[8] { "Boulder", "Coloradosprings", "Denver", "Eastco", "Fortcollins", "Rockies", "Pueblo", "Westernslope" };
            string[] Connecticut = new string[4] { "Newlondon", "Hartford", "Newhaven", "Nwct" };
            string[] Delaware = new string[1] { "Delaware" };
            string[] Districtofcolumbia = new string[1] { "Washington" };
            string[] Florida = new string[23] { "Broward", "Daytona", "Keys", "Fortlauderdale", "Fortmyers", "Gainesville", "Cfl", "Jacksonville", "Lakeland", "Miami", "Lakecity", "Ocala", "Okaloosa", "Orlando", "Panamacity", "Pensacola", "Sarasota", "Miami", "Spacecoast", "Staugustine", "Tallahassee", "Tampa", "Treasure" };
            string[] Georgia = new string[12] { "Albany", "Athens", "Atlanta", "Augusta", "Brunswick", "Columbus", "Macon", "Robins", "Nwga", "Savannah", "Statesboro", "Valdosta" };
            string[] Hawaii = new string[1] { "Honolulu" };
            string[] Idaho = new string[7] { "Boise", "Eastidaho", "Lewiston", "Twinfalls", "Pullman", "Spokane", "Twinfalls" };
            string[] Illinois = new string[13] { "Bn", "Chambana", "Chicago", "Decatur", "Lasalle", "Mattoon", "Peoria", "Quadcites", "Rockford", "Peoria", "Springfield", "Stlouis", "Quincy" };
            string[] Indiana = new string[9] { "Bloomington", "Evansville", "Indianapolis", "Kokomo", "Lafayette", "Munice", "Richmond", "Southbend", "Terrehaute" };
            string[] Iowa = new string[12] { "Aimes", "Cedarrapids", "Desmoines", "Dubuque", "Fortdodge", "Iowacity", "Masoncity", "Omaha", "Quadcities", "Siouxcity", "Ottumwa", "Waterloo" };
            string[] Kansas = new string[9] { "Kansascity", "Lawrence", "Manhattan", "Nwks", "Salina", "SeKs", "SwKs", "Topeka", "Wichita" };
            string[] Kentucky = new string[6] { "Bgky", "Cincinnati", "Eastky", "Huntington", "Owensboro", "Westky" };
            string[] Louisiana = new string[8] { "Batonrouge", "Cenla", "Houma", "Lakecharles", "Lafayette", "Monroe", "Neworleans", "Shreveport" };
            string[] Maine = new string[1] { "Maine" };
            string[] Maryland = new string[6] { "Annapolis", "Baltimore", "Easternshore", "Frederick", "SMD", "Westmd" };
            string[] Massachusetts = new string[5] { "Boston", "Capecod", "Southcoast", "Westernmass", "Worcester" };
            string[] Michigan = new string[17] { "Annarbor", "Battlecreek", "Centralmich", "Detroit", "Flint", "Grandrapids", "Holland", "Jackson", "Kalamazoo", "Lansing", "Monroe", "Muskegon", "Nmi", "Porthuron", "Saginaw", "Swmi", "UP" };
            string[] Minnesota = new string[8] { "Bemidji", "Brainerd", "Duluth", "Mankato", "Minneapolis", "Rochester", "Marshall", "Stcloud" };
            string[] Mississippi = new string[6] { "Gulfport", "Hattiesburg", "Jackson", "Meridian", "Northmiss", "Natchez" };
            string[] Missouri = new string[9] { "Columbia", "Joplin", "Kansascity", "Kirksville", "Loz", "Semo", "Springfield", "Stjoseph", "Stlouis" };
            string[] Montana = new string[8] { "Billings", "Bozeman", "Butte", "Greatfalls", "Helena", "Kalispell", "Missoula", "Montana" };
            string[] Nebraska = new string[5] { "Grandisland", "Lincoln", "Northplatte", "Omaha", "Scotsbluff" };
            string[] Newjersey = new string[4] { "Cnj", "Jerseyshore", "Newjersey", "Southjersey" };
            string[] Newhampshire = new string[1] { "Nh" };
            string[] Nevada = new string[3] { "Elko", "Lasvegas", "Reno" };
            string[] Newmexico = new string[6] { "Albuquerque", "Clovis", "Farmington", "Lascruces", "Roswell", "Santafe" };
            string[] Newyork = new string[19] { "Albany", "Binghanmton", "Buffalo", "Catskills", "Chautauqua", "Elmira", "Fingerlakes", "Glensfalls", "Hudsonvalley", "Ithaca", "Longisland", "Newyork", "Oneonta", "Plattsburgh", "Potsdam", "Utica", "Watertown", "Rochester", "Syracuse" };
            string[] Northcarolina = new string[12] { "Asheville", "Boone", "Charlotte", "Eastnc", "Fayetteville", "Greensboro", "Hickory", "Jacksonville", "Outerbanks", "Raleigh", "Winstonsalem", "Willmington" };
            string[] Northdakota = new string[4] { "Bismarck", "Fargo", "Grandforks", "Northdakota" };
            string[] Ohio = new string[15] { "Akron", "Ashtabula", "Athens", "Chillicothe", "Cincinnati", "Cleveland", "Columbus", "Dayton", "Lima", "Mansfield", "Sandusky", "Toledo", "Tuscarawas", "Youngstown", "Zanesville" };
            string[] Oklahoma = new string[5] { "Lawton", "Enid", "Oaklahomacity", "Stillwater", "Tulsa" };
            string[] Oregon = new string[10] { "Bend", "Corvallis", "Eastoregon", "Eugene", "Klamath", "Medford", "Oregoncoast", "Portland", "Roseburg", "Salem" };
            string[] Pennsylvania = new string[15] { "Altoona", "Cumberland", "Erie", "Harrisburg", "Lancaster", "Lehigh", "Meadville", "Phildelphia", "Pittsburgh", "Poconos", "Reading", "Scranton", "Pennstate", "Williamsport", "York" };
            string[] Rhode = new string[1] { "Rhodeisland" };
            string[] Southcarolina = new string[6] { "Charleston", "Columbia", "Florence", "Greenville", "Hiltonhead", "Myrtlebeach" };
            string[] Southdakota = new string[5] { "Nesd", "Csd", "Rapidcity", "Siouxfalls", "SD" };
            string[] Tennessee = new string[8] { "Chattanooga", "Clarksville", "Cookeville", "Jackson", "Knoxville", "Memphis", "Nashville", "Tricities" };
            string[] Texas = new string[25] { "Abilene", "Amarillo", "Austin", "Beaumont", "Brownsville", "Collegestation", "Corpuscristi", "Dallas", "Nacogdoches", "Delrio", "Elpaso", "Galveston", "Houston", "Keleen", "Lubbock", "Mcallen", "Odessa", "Sanangelo", "Sanantonio", "Sanmarcos", "Bigbend", "Easttexas", "Victoria", "Waco", "Wichitafalls" };
            string[] Utah = new string[5] { "Logan", "Ogden", "Provo", "Saltlakecity", "Stgeorge" };
            string[] Vermont = new string[1] { "Vermont" };
            string[] Virgina = new string[11] { "Charlottesville", "Danville", "Fredericksburg", "Norfolk", "Harrisonburg", "Lynchburg", "Blacksburg", "Richmond", "Roanoke", "Swva", "Winchester" };
            string[] Washington = new string[9] { "Bellingham", "Kpr", "Olympic", "Moseslake", "Spokane", "Skagit", "Seattle", "Wenatchee", "Yakima" };
            string[] WV = new string[8] { "CharlestonWV", "Martinsburg", "Huntington", "Morgantown", "Wheeling", "Parkersburg", "Swv", "WV" };
            string[] Wisconsin = new string[11] { "Appleton", "Eauclaire", "Greenbay", "Janesville", "Kenosha", "Lacrosse", "Madison", "Milwaukee", "Northernwi", "Sheboygan", "Wausau" };
            string[] Wyoming = new string[1] { "Wyoming" };
            switch (value)
            {
                case "Alabama":
                    for (int i = 0; i < Alabama.Length; i++)
                    {
                        category.Cities.Add(Alabama[i]);
                    }
                    break;
                case "Alaska":
                    for (int i = 0; i < Alaska.Length; i++)
                    {
                        category.Cities.Add(Alaska[i]);
                    }
                    break;
            }
            return category.Cities;
        }

        public string WriteFile(string FileText, string PasswordText, string EmailText, string CityText)
        {
            string testCheck = "SET !VAR1";
            string testCheck2 = "SET !VAR2";
            string notExist = "notExist";
            string saved = "saved";
            string wrongFile = "wrongFile ";
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
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                        if (FileText.StartsWith("mail") || FileText.Contains("delete"))
                        {
                            while (line.Contains(""))
                            {
                                if (line.Contains(testCheck))
                                {
                                    line = "SET !VAR1 " + PasswordText;
                                }
                                if (line.Contains(testCheck2))
                                {
                                    line = "SET !VAR2 " + EmailText;
                                }
                                list.Add(line += Environment.NewLine);
                                line = streamReader.ReadLine();
                            }
                        }
                        else
                        {
                            while (line != null)
                            {
                                if (line.Contains(testCheck))
                                {
                                    line = "SET !VAR1 " + CityText;
                                }
                                if (line.Contains(testCheck2))
                                {
                                    line = "SET !VAR2 " + EmailText;
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
        //return message box messages from write file
        public string Message()
        {
            return messageType;
         }
        }

    }

