namespace MachineLearning.Models
{
    public class Cancer
    {
        public string Gene_Description { get; set; }
        public string Gene_Accession_Number { get; set; }

        public int Call { get; set; }

        public Cancer(string Gene_Description, string Gene_Accession_Number, int Call)
        {
            this.Gene_Description = Gene_Description;
            this.Gene_Accession_Number = Gene_Accession_Number;
            this.Call = Call;
        }

        public Cancer()
        {

        }
    }
}
