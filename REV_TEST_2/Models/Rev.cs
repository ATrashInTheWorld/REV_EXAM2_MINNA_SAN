using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace REV_TEST_2.Models
{
    public class Rev : IValidatableObject
    {
        [Required]
        [StringLength(5, ErrorMessage ="Max leng 5")]
        [MinLength(3, ErrorMessage ="Min Lenght is 3")]
        [DisplayName("YOOO, Enter ur Maofucking NAME BITCH")]
        public string name { get; set; }

        [Required(ErrorMessage ="I really needs you to be honest rn")]
        public bool isItTrue { get; set; }


        [Required]
        //[DataType(DataType.CreditCard, ErrorMessage ="Dont u know what a CC is like?")]
        public int credit { get; set; }

        [Required]
        [DataType(DataType.Date,ErrorMessage ="Enter a date bro")]
        public DateTime dob { get; set; }

        [MaxLength(500, ErrorMessage ="max 500 cuiortposdnaqwief, yeah chars")]
        public string comment { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if ((DateTime.Now.Year - dob.Year) < 18 )
                yield return (new ValidationResult(errorMessage: "Bro you gotta be 18 to have a credit card, the Fuck", memberNames: new[] { "dob" }));

            if (!isItTrue)
                yield return (new ValidationResult(errorMessage: "SRY, but guls not allowed, this is a straignt strip club for males only. Boss' oreder, not mine", memberNames: new[] { "isItTrue"}));
        }
    }
}