using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.ViewModel
{
    public class UserModel
    {
        public int Id { get; set; }      
        public string Name { get; set; }
        public string SurName { get; set; }      
        public string UserName { get; set; }    
        public string Email { get; set; }    
        public string Password { get; set; }    
        public bool Persistent { get; set; }
        public bool Lock { get; set; }
    }
}
