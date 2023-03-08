namespace MachineLearning.Models
{
    public class SpaceMissionModel
    {
        //Company_Name = @"CASC",
        //        Location = @"Site 9401 (SLS-2), Jiuquan Satellite Launch Center, China",
        //        Datum = @"Thu Aug 06, 2020 04:01 UTC",
        //        Detail = @"Long March 2D | Gaofen-9 04 & Q-SAT",
        //        Status_Rocket = @"StatusActive",
        //        Rocket = @"29.75",

       
        public string CompanyName { get; set; }

        public string Location { get; set; }

        public string StatusRocket { get; set; }

        public string RocketCost { get; set; }

        public SpaceMissionModel(string companyName, string location, string statusRocket, string rocketCost)
        {
            CompanyName = companyName;
            Location = location;
            StatusRocket = statusRocket;
            RocketCost = rocketCost;
        }

        public SpaceMissionModel()
        {

        }

    }
}
