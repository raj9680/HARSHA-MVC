﻿using System.ComponentModel.DataAnnotations;

namespace Model_Validations_1.Models
{
    public class PersonModel
    {
        [Required(ErrorMessage ="{0} can't be empty or null")]
        [Display(Name= "Person Name")]
        [StringLength(40, MinimumLength = 3, ErrorMessage = "{0} should be between {2} and {1} characters long")]
        public string? PersonName { get; set; }

        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Password { get; set; }
        public string? ConfirmPassword { get; set; }

        [Range(0, 999.99, ErrorMessage = "{0} should be between ${1} and ${2}")]
        public string? Price { get; set; }

        public override string ToString()
        {
            return $"Person Name: {PersonName}, Email: {Email}, Phone: {Phone}, Password: {Password}, Confirm Password: {ConfirmPassword}, Price: {Price}";
        }
    }
}
