using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Models.ViewModel
{
    public class LoginModel
    {      
        public string UserName { get; set; }       
        public string Email { get; set; }      
        public string Password { get; set; }     
        public bool Persistent { get; set; }
        public bool Lock { get; set; }
    }
}
