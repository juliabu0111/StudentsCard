using Newtonsoft.Json;
using StudentsCard.Domain.Attributes;
using System.ComponentModel.DataAnnotations;

namespace StudentsCard.Domain.Models
{
    [CollectionName("Personal Information")]
    public class PersonalInformation : BaseModel, ICloneable
    {
        [Required(ErrorMessage = "Last name is required.")]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [MaxLength(15)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Middle name is required.")]
        [MaxLength(20)]
        public string MiddleName { get; set; }

        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime Birthday { get; set; }

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
                Birthday = Birthday
            };
        }
    }
}