using System;
using Microsoft.AspNetCore.Identity;

namespace Invoice.Infrastructure
{
    public class AppUser : IdentityUser<Guid>
    {
        public string DisplayName { get; set; }
    }
}