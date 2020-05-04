using System;
using System.ComponentModel.DataAnnotations;

namespace ChatApp.API.Dtos
{
    public class UserForRegisterDto
    {
        public string Username { get; set;}

        [Required]
        [StringLength(8, MinimumLength = 4, ErrorMessage ="You can specify between 4 and 8 characters" )]
        public string Password { get; set;}
    }

}