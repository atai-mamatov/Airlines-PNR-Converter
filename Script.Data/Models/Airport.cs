namespace Script.Data.Models
{
    public class Airport : BaseEntity
    {
        public string Name { get; set; }
        public string CountryName { get; set; }
        public string IATA { get; set; }
    }
}
