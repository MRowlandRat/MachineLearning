namespace MachineLearning.Models
{


    public class Destiny2
    {
        public Destiny2() { }

        public string destiny2Predictions(String Gun_Name, String Gun_Archtype, String Source, String Element, float RateofFire, String Weapon_Type)
        {
            var sampleData = new MLMSav.ModelInput()
            {


                Gun_name = Gun_Name,
                Gun_archetype = Gun_Archtype,
                Source = Source,
                Element = Element,
                Gun_RoF = RateofFire,
                Weapon_type = Weapon_Type

            };

            //Load model and predict output
            var result = MLMSav.Predict(sampleData);

            return result.PredictedLabel.ToString();

        }

        

    }
}