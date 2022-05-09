using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace INGWeb_Rivadeneira.Models
{
    public class Options
    {
        public int OptionsID { get; set; }
        public int QuestionsID {get;set;} 
        public string optionText { get; set; }
        public bool correctOption { get; set; }
        public virtual Questions Questions { get; set; }
    }
}