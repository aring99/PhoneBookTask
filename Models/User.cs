using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PhoneBookTask.Models
{
    public class User
    {
        public string Email { get; set; }
        public string Upassword { get; set; }
        public int IsAdmin { get; set; }
}
}