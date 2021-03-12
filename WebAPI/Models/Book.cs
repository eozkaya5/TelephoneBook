
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public int TelephoneNumber { get; set; }
        public int UserId { get; set; }

    }
}
