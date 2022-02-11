using Newtonsoft.Json;
using StudentsCard.Domain.Attributes;
using System.ComponentModel.DataAnnotations;

namespace StudentsCard.Domain.Models
{
    [CollectionName("Contact Information")]
    public class ContactInformation : BaseModel, ICloneable
    {
        [RegularExpression(@"\d{5}*$", ErrorMessage = "Invalid Zip Code")]
        public string ZipCode { get; set; }

        [RegularExpression(@"^[a-zA-Zа-яА-Я]*$")]
        public string Region { get; set; }

        [RegularExpression(@"^[a-zA-Zа-яА-Я]*$")]
        public string District { get; set; }

        public string SettlementName { get; set; }

        public string Street { get; set; }

        [RegularExpression(@"^[a-zA-Z0-9]*$")]
        public string HouseNumber { get; set; }

        [RegularExpression(@"^[0-9]*$")]
        public string ApartmentNumber { get; set; }

        public string ResidenceAddress => $"{ SettlementName }, { Street }, { HouseNumber }, { ApartmentNumber }.";

        [Required(ErrorMessage = "Phone number is required.")]
        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        public object Clone()
        {
            return new ContactInformation()
            {
                Id = Id,
                ZipCode = ZipCode,
                Region = Region,
                District = District,
                SettlementName = SettlementName,
                Street = Street,
                HouseNumber = HouseNumber,
                ApartmentNumber = ApartmentNumber,
                PhoneNumber = PhoneNumber,
                Email = Email
            };
        }
    }
}