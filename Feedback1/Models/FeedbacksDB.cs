using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Feedback1.Models;

namespace Feedback1.Models
{
    public class FeedbacksDB : DbContext
    {
        public FeedbacksDB(): base("DefaultConnection")
        {

            Database.SetInitializer<FeedbacksDB>(new Data());


        }

        public DbSet<Questionnaire> Questionnaires { get; set; }
        public DbSet<Question> Questions { get; set; }

        public DbSet<Answertype> Answertypes { get; set; }
    }
}