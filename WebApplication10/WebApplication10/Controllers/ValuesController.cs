using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication10.Db;
using WebApplication10.Models;
using Math = WebApplication10.Models.Math;

namespace WebApplication10.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {

        private FController fController = new FController();

        [HttpGet]
        public String  index()
        {
            return "English , Math";
        }

        [HttpGet("SubjectName/{name}/Tests")]
        public List<Questions> Tests(String name)
        {
           return  fController.GetQuestions(name);
        }

        [HttpGet("ShowrightAnswers/SubjectName/{name}/")]
        public List<String> Answer(String name)
        {
           return  fController.GetAnswers( name);
        }

        /*addQuestion/ name /English/question/EnglishQ/answer1/AE/answer2/AE/answer3 /AE/answer4/AE/answer_r/AE*/

        [HttpGet("addQuestion/ name /{Name}/question/{question}/answer1/{answer1}/answer2/{answer2}/answer3 /{answer3}/answer4/{answer4}/answer_r/{answer_r}")]
        public String createTest(String name , String question , String answer1, String answer2, String answer3, String answer4, String answer_r)
        {
            fController.createQ(name, question, answer1, answer2, answer3, answer4, answer_r);
            return "Succesfull";

        }
        [HttpDelete("DeleteQuestion/name/{name}/id/{id}")]
        public IActionResult deleteQuestion()
        {
            return Ok();
        }

        [HttpGet("registStud/name/{name}/age/{age}")]
        public String AddStud(String name,int age) {

            using (ApplicationContext db = new ApplicationContext())
            {
                User user1 = new User { Name = name, Age = age };

                db.Users.Add(user1);
                db.SaveChanges();
          
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    return ($"{u.Id}.{u.Name} - {u.Age}");
                }
            }
            return "Ne dobavleno";
        }



    }


    }

