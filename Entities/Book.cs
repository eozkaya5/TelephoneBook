
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Book :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public int TelephoneNumber { get; set; }
    }
}
