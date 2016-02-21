using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Feedback1.Models;
namespace Feedback1.Controllers
{
    public class HomeController : Controller
    {
        FeedbacksDB Db = new FeedbacksDB();


        public ActionResult DeleteQuestionnaire()
        {

            return View(Db.Questionnaires.ToList());
        }

        [HttpPost]
        public ActionResult DeleteQuestionnaire(int id)
        {
            Questionnaire questionnaire = Db.Questionnaires.SingleOrDefault(q => q.QuestionnaireId == id);
           
            Db.Questionnaires.Remove(questionnaire );
            Db.SaveChanges();
            return RedirectToAction("Index");
            //return RedirectToAction("Login","Account");
        }




        public ActionResult Index()
        {
            ViewBag.Message = Db.Questions.ToList(); ;

            return View();
        }
        public ActionResult NewQuestionnaire()
        {
            //ViewBag.Message = Db.Questions.ToList(); ;

            return View();
        }

        [HttpPost]
        public ActionResult NewQuestionnaire(Questionnaire postedquestionnaire)   
        {

            

            
            Db.Questionnaires.Add(postedquestionnaire);

            Db.SaveChanges();
            return RedirectToAction("Index");
            
                    }


        public ActionResult SelectQuestionnaire()
        {
            //ViewBag.Message = Db.Questions.ToList(); ;

            return View(Db.Questionnaires.ToList());
        }

        public ActionResult AddQuestions( int id)
        {

            Questionnaire questionnaire = Db.Questionnaires.SingleOrDefault(q=>q.QuestionnaireId==id);
            Question newquestion = new Question();
            ViewBag.Title = questionnaire.Title;
            newquestion.QuestionnaireId = id;
            return View(newquestion);
        }


        [HttpPost]
        public ActionResult AddQuestions(Question postedquestion,string dowlist)
        {


            
            postedquestion.Answertype = dowlist;
            Db.Questions.Add(postedquestion);

            Db.SaveChanges();
            ModelState.Remove("Content");
            


            
            return View();
        }


       

        
        public ActionResult SetQuestionnaire()
        {
            


           
             return View(Db.Questionnaires.ToList());

        }

        public ActionResult DisplayQuestionnaire(int id)
        {
           // List<Question> questions = new List<Question>();
            //questions = Db.Questions.Where(q => q.QuestionnaireId == id).ToList();
            Questionnaire questionnaire=Db.Questionnaires.SingleOrDefault(q=>q.QuestionnaireId==id);
            ViewBag.Title =  questionnaire.Title;

            return View(Db.Questions.Where(q => q.QuestionnaireId == id).ToList());
        }


        public ActionResult Edit(int id)
        {

            Question question = Db.Questions.SingleOrDefault(q => q.QuestionId == id);
            return View(question);
        }

        [HttpPost]
        public ActionResult Edit(Question postedquestion)
        {

             Question question = Db.Questions.SingleOrDefault(q => q.QuestionId ==postedquestion.QuestionId);
             question.QuestionnaireId = postedquestion.QuestionnaireId;
             question.Content = postedquestion.Content;
             question.Answertype = postedquestion.Answertype;
            Db.SaveChanges();

            return View();
        }


        public ActionResult Delete(int id)
        {

            Question question = Db.Questions.SingleOrDefault(q => q.QuestionId == id);
            if (question == null)
                return View("Error");
            Db.Questions.Remove(question);
               Db.SaveChanges();
            return View("Index");
        }

        //[HttpPost]
        //public ActionResult Delete( Question question)
        //{

        //   // Question questiontodelete = Db.Questions.SingleOrDefault(q => q.QuestionId == postedquestion.QuestionId);
        //    Db.Questions.Remove(question);
        //    Db.SaveChanges();
        //    return View();
        //}



        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
