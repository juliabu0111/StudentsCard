using StudentsCard.Domain.Attributes;
using System.ComponentModel.DataAnnotations;

namespace StudentsCard.Domain.Models
{
    [CollectionName("Passport Information")]
    public class PassportInformation : BaseModel, ICloneable
    {
        [Required(ErrorMessage = "Passport series is required.")]
        [RegularExpression(@"^[A-ZА-Я]{2}*$", ErrorMessage = "Only alphabets should be entered")]
        public string Series { get; set; }

        [Required(ErrorMessage = "Passport number is required.")]
        [RegularExpression(@"^[0-9]{6}*$", ErrorMessage = "Only 6 numbers should be entered")]
        public string Number { get; set; }

        [Required(ErrorMessage = "Date of issue is required.")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: dd/MM/yyyy}")]
        public DateTime DateOfIssue { get; set; }
        
        [Required(ErrorMessage = "Authority is required.")]
        public string Authority { get; set; }

        [Required(ErrorMessage = "Nationality is required.")]
        public string Nationality { get; set; }

        public string CivilStatus { get; set; }

        public object Clone()
        {
            return new PassportInformation()
            {
                Series = Series,
                Number = Number,
                DateOfIssue = DateOfIssue,
                Authority = Authority,
                Nationality = Nationality,
                CivilStatus = CivilStatus
            };
        }
    }
}
