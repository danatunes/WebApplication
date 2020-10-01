using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class Math : Subject
    {

        public List<Questions> qm;
        public List<String> answer_R = new List<string>();
        public String name;

        public Math()
        {
            qm = new List<Questions>() {
                   new Questions () {id_q =1 , question = "Good q" ,answer1="lol kek1",answer2="2", answer3="3",answer4 = "4"},
                    new Questions(){ id_q = 2 , question="ggwp" ,answer1="lol kek1",answer2="2", answer3="3",answer4 = "4"}
            };
            answer_R.Add("65");
            answer_R.Add("321");
        }

        public String CreateMathQ(String question, String answer1, String answer2, String answer3, String answer4, String answer_r){
            qm.Add(new Questions() { question = question, answer1 = answer1, answer2 = answer2, answer3 = answer3, answer4 = answer4, answer_r = answer_r });
            return "All right";
        }

        public override Questions CreateQ(Questions q,String answer_r){
            qm.Add(q);
            answer_R.Add(answer_r);
            return q;
        }

        public override List<Questions> GetQuestions(){
        return qm;
        }

        public override List<string> giveRight(){
            return answer_R;
        }
    }
}
