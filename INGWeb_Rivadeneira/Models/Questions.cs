using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INGWeb_Rivadeneira.Models
{
    public class Questions
    {
        public int QuestionsID { get; set; }

        public string QuestionText { get; set; }
        public int QuestionDifficulty {get;set;}
        public ICollection<Options> Options { get; set; }
        
    }
}