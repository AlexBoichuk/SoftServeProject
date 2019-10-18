using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public class User : IdentityUser
    {
        public virtual List<Order> Orders { get; set; }
        public User()
        {
            Orders = new List<Order>();
        }
    }
}
