using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INGWeb_Rivadeneira.Models
{
    public class Users
    {
        public int UsersID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public ICollection<Scores> Scores { get; set; }
    }
}