using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Feedback1.Models
{
    public class Questionnaire
    {
       
        public int QuestionnaireId { get; set; }
        public string Title { get; set; }
        public string Topic { get; set; }
        public virtual List<Question> Questions{ get; set; }

        
    }
}