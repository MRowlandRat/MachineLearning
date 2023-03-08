namespace MachineLearning.Models
{
    public class connAbby
    {
       
        public string predictData(string companyName, string location, string rocketStatus, string rocketCost)
        {
            //this is an instance of the prediction engine
            //var mlContext = new MLContext();
            ////exported model as a zip
            //var transformer = mlContext.Model.Load("MLModelAbby.zip", out _);
            //var predictionEngine = mlContext.Model
            //    .CreatePredictionEngine<ModelInput, ModelOutput>(transformer);

            //Load sample data
            var sampleData = new MLModelAbby.ModelInput()
            {
                Company_Name = companyName,
                Location = location,
                Status_Rocket = rocketStatus,
                Rocket = rocketCost,
                
            };

            //Load model and predict output
            var result = MLModelAbby.Predict(sampleData);
            /*Console.WriteLine(result);
            Console.WriteLine(result.Score.ToString());

            //retrieves the labels from the prediction
            var labelBuffer = new VBuffer<ReadOnlyMemory<char>>();
            predictionEngine.OutputSchema["Score"].Annotations.GetValue("SlotNames", ref labelBuffer);
            var labels = labelBuffer.DenseValues().Select(l => l.ToString()).ToArray();*/

            if (result == null)
            {
                return "Error";
            }
            else
            {
                return result.PredictedLabel.ToString();
            }
        }


    }
}
