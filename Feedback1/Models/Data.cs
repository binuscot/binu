using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Security;
using WebMatrix.WebData;
namespace Feedback1.Models
{
    public class Data : DropCreateDatabaseAlways<FeedbacksDB>
    {
        protected override void Seed(FeedbacksDB data)
        {
            List<Questionnaire> Questionnaires = new List<Questionnaire>();
            List<Question> Questions = new List<Question>();
            List<Answertype>Answertypes = new List<Answertype>();

            
            

            Questionnaires.Add(new Questionnaire { QuestionnaireId = 1, Title = "Title1", Topic = "Topic1", Questions = new List<Question>() });
           
                       

            Questions.Add(new Question { QuestionId = 1,QuestionnaireId=1, Content = "question1", Answertype = "Answertype1" });
            Questions.Add(new Question { QuestionId = 2, QuestionnaireId = 1, Content = "question2", Answertype = "yes/no" });
            Questions.Add(new Question { QuestionId = 3, QuestionnaireId = 1, Content = "question3", Answertype = "ansnwertype1" });
           
           
            
            Answertypes.Add(new Answertype { AnswertypeId = 1, Answer= "Yes" });
            Answertypes.Add(new Answertype { AnswertypeId = 2, Answer = "No" });
            Answertypes.Add(new Answertype { AnswertypeId = 3, Answer = "Ok" });
            Answertypes.Add(new Answertype { AnswertypeId = 4, Answer = "Not Ok" });
            Answertypes.Add(new Answertype { AnswertypeId = 5, Answer = "Agree" });
            Answertypes.Add(new Answertype { AnswertypeId = 6, Answer = "Disagree" });
            Answertypes.Add(new Answertype { AnswertypeId = 7, Answer = "Neutral" });
            Answertypes.Add(new Answertype { AnswertypeId = 8, Answer = "Strongly Agree" });
            Answertypes.Add(new Answertype { AnswertypeId = 9, Answer = "Strongly Disagree" });
            Answertypes.Add(new Answertype { AnswertypeId = 10, Answer = "Excellent" });
            Answertypes.Add(new Answertype { AnswertypeId = 11, Answer = "Very Good" });
            Answertypes.Add(new Answertype { AnswertypeId = 12, Answer = "Good" });
            Answertypes.Add(new Answertype { AnswertypeId = 13, Answer = "Average" });
            Answertypes.Add(new Answertype { AnswertypeId = 14, Answer = "Unsatisfactory" });
            Answertypes.Add(new Answertype { AnswertypeId = 15, Answer = "Very Often" }); 
            Answertypes.Add(new Answertype { AnswertypeId = 16, Answer = "Often" });
            Answertypes.Add(new Answertype { AnswertypeId = 17, Answer = "Sometimes" });
            Answertypes.Add(new Answertype { AnswertypeId = 18, Answer = "Rare" });
            Answertypes.Add(new Answertype { AnswertypeId = 19, Answer = "Very Rare" });
            Answertypes.Add(new Answertype { AnswertypeId = 20, Answer = "Dont Know" });

            foreach (Questionnaire questionnaire in Questionnaires)
                data.Questionnaires.Add(questionnaire);

            foreach (Question question in Questions)
                data.Questions.Add(question);

            foreach (Answertype answertype in Answertypes)
                data.Answertypes.Add(answertype);

            base.Seed(data);


        }     



    }
}