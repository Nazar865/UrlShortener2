using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrlShortener2.Data.Enums;

namespace UrlShortener2.Data.Entities
{
    public class User : IdentityUser<Guid>
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public UserRole Role { get; set; } = UserRole.User;
    }
}