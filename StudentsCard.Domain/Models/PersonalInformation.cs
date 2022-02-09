using Newtonsoft.Json;
using StudentsCard.Domain.Attributes;
using System.ComponentModel.DataAnnotations;

namespace StudentsCard.Domain.Models
{
    [CollectionName("Personal Information")]
    public class PersonalInformation : BaseModel, ICloneable
    {
        [Required]
        [MaxLength(30)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(30)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(30)]
        public string MiddleName { get; set; }

        public DateTime Birthday { get; set; }

        public string Citizenship { get; set; }

        public string CivilStatus { get; set; }

        [JsonIgnore]
        public string FullName => $"{ LastName } { FirstName } { MiddleName }";

        [JsonIgnore]
        public string LastNameAndInitials => $"{ LastName } { FirstName[0] }. { MiddleName[0] }.";

        public object Clone()
        {
            return new PersonalInformation()
            {
                Id = Id,
                LastName = LastName,
                FirstName = FirstName,
                MiddleName = MiddleName,
                Birthday = Birthday,
                Citizenship = Citizenship,
                CivilStatus = CivilStatus
            };
        }
    }
}