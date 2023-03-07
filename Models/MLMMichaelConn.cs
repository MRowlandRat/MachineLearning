namespace MachineLearning.Models
{
    public class MLMMichaelConn
    {
        public string prediction(int YOE, string title, string company, string location, int YAC)
        {
            //Load sample data
            var sampleData = new MLMMichael.ModelInput()
            {
                Company = company,
                Title = title,
                Totalyearlycompensation = 100000F,
                Location = location,
                Yearsofexperience = YOE.ToString(),
                Yearsatcompany = (float)YAC,
            };

            //Load model and predict output
            var result = MLMMichael.Predict(sampleData);

            if (result == null)
            {
                return "help ive broken";
            }
            else
            {
                return "$" + result.Score.ToString();
            }

        }
    }
}