﻿using System.Diagnostics.Eventing.Reader;

namespace ASP.Net_Inlamningsuppgift.Models.Forms
{
    public class RegisterForm
    {
        public string? ReturnUrl { get; set; }

        
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string? Company { get; set; }

        public string Email { get; set; } = null!;
        
        public string? PhoneNumber { get; set; } 
        //sätt required på dessa
        public string Password { get; set; } = null!;
        
        public string ConfirmPassword { get; set; } = null!;

        public string StreetName { get; set; } = null!;

        public string PostalCode { get; set; } = null!;

        public string City { get; set; } = null!; 
        
        public bool TermsAndAggreements { get; set; }
    }
}
