using System.Text.Json.Serialization;

namespace LedgerApi.Models
{
    public class Ladger
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [JsonIgnore]
        public List<User>? Users { get; set; }
    }
}
