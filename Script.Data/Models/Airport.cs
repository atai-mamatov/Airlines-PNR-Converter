namespace Script.Data.Models
{
    public class Airport : BaseEntity
    {
        public string Name { get; set; }
        public Country CountryName { get; set; }
        public int IATA { get; set; }
    }
}
