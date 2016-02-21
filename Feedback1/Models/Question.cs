using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Feedback1.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int QuestionnaireId { get; set; }
        public string Content { get; set; }
        public string Answertype { get; set; }


    }

   





}