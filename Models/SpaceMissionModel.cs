using System.ComponentModel.DataAnnotations;

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

       
        public string? companyName { get; set; }

        public string? location { get; set; }

        public string? statusRocket { get; set; }

        public string? rocketCost { get; set; }

        public SpaceMissionModel(string companyName, string location, string statusRocket, string rocketCost)
        {
            this.companyName = companyName;
            this.location = location;
            this.statusRocket = statusRocket;
            this.rocketCost = rocketCost;
        }

        public SpaceMissionModel()
        {

        }

        public override string ToString()
        {
            return $"Inputs:\n      Company Name: {companyName} \n      Location: {location} \n     Rocket Status: {statusRocket} \n    Rocket Cost: {rocketCost}";
        }

    }
}
