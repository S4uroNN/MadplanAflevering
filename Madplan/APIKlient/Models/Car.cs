namespace APIKlient.Models
{
    [Serializable]
    public class Car
    {
        public int? ID { get; set; }
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int? Milage { get; set; }
        public object? Owners { get; set; }
        public int? Year { get; set; }
        public DateTime? MOT { get; set; }
        public object? Service { get; set; }
        public bool? HasMOT { get; set; }


        public override string ToString()
        {
            return "Make " + Make + " Model" + Model;
        }

    }
}
