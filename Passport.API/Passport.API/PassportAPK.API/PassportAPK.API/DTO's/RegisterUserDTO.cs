﻿using System.ComponentModel.DataAnnotations;

namespace PassportAPK.API.DTO_s
{
    public class RegisterUserDTO
    {

        [Required(ErrorMessage = "First or Middle name must be required")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Enter Minimun 4 and maximum 50 character")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Surnmae name must be required")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Enter Minimun 4 and maximum 50 character")]
        public string LastName { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Enter a valid email address.")]
        public string EmailAddress { get; set; }

        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[A-Za-z\d]{1,}$", ErrorMessage = "LoginId must contain at least one uppercase letter, one lowercase letter, and one digit.")]
        public string LoginId { get; set; }


        [Required]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{6,12}$", ErrorMessage = "Password must be 6 to 12 characters long, contain at least one uppercase letter, one lowercase letter, one digit, and one special character.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Required]
        [Phone]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "Enter Minimun 10 and maximum 12 character")]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

      
    }
}
