namespace MachineLearning.Models
{
    public class person
    {

        /*
           Company = company,
           Title = title,
           Totalyearlycompensation = 100000F,
           Location = location,
           Yearsofexperience = YOE.ToString(),
           Yearsatcompany = (float)YAC,
         */

        public string Company { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public int YearsOfExperience { get; set; }
        public int YearsAtCompany { get; set; }


        public person(string company, string title, string location, int yearsofexperience, int yearsatcompany)
        {
            Company= company;
            Title= title;
            Location= location; 
            YearsOfExperience= yearsofexperience;
            YearsAtCompany = yearsatcompany;
        }

        public person()
        {

        }



    }
}
