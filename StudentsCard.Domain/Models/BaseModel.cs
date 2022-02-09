using Newtonsoft.Json;

namespace StudentsCard.Domain.Models
{
    public abstract class BaseModel
    {
        // appear first
        [JsonProperty(Order = -int.MaxValue)]
        public string Id { get; set; }

        public BaseModel()
        {
            Id = Guid.NewGuid().ToString();
        }
    }
}