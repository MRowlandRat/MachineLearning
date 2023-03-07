namespace MachineLearning.Models
{
    public class GeneClassification
    {
        
          public  string DataClassification(string GeneDescription, string GeneAccessionNumber, int Call)
            {
                var sampleData = new CancerClassification.ModelInput()
                {
                    Gene_Description = GeneDescription,
                    Gene_Accession_Number = GeneAccessionNumber,
                    Call = Call.ToString(),
                };

                var result = CancerClassification.Predict(sampleData);

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
