namespace MachineLearning.Models
{
    public class ConnAbby
    {
        //put into a function
        //Load sample data
        var sampleData = new MLModelAbby.ModelInput()
        {
            Column1 = 1F,
            Unnamed__0 = 1F,
            Company_Name = @"CASC",
            Location = @"Site 9401 (SLS-2), Jiuquan Satellite Launch Center, China",
            Datum = @"Thu Aug 06, 2020 04:01 UTC",
            Detail = @"Long March 2D | Gaofen-9 04 & Q-SAT",
            Status_Rocket = @"StatusActive",
            Rocket = @"29.75",
        };

        //Load model and predict output
        var result = MLModelAbby.Predict(sampleData);

        ////////////////////////////////////////////////////////////////
        //function to predict data
        //function to edit column
        
        //stretch functions:
        ///save predictions
    }
}
