using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INGWeb_Rivadeneira.Models
{
    public class Scores
    {
        public int ScoresID { get; set; }
        public int UsersID { get; set; }
        public int? Score { get; set; }
        public string Mode { get; set; }
        public int? Combo { get; set; }
        public virtual Users UserVir { get; set; }
    }
}