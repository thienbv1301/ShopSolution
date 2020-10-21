﻿using Microsoft.AspNetCore.Identity;
using System;

namespace ShopSolution.Data.Entities
{
    public class AppRole : IdentityRole<Guid>
    {
        public string Description { get; set; }
    }
}
