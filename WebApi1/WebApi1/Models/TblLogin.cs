﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApi1.Models
{
    public partial class TblLogin
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int IsAdmin { get; set; }
    }
}
