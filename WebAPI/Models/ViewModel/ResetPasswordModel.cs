﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models.ViewModel
{
    public class ResetPasswordModel:IEntity
    {       
        public string Email { get; set; }
    }
}
