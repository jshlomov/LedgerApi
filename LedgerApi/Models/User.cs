using System.Text.Json.Serialization;


namespace LedgerApi.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [JsonIgnore]
        public List<Ladger>? Ladgers { get; set; }

    }
}
