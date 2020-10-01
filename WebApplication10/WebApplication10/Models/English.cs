using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class English : Subject
    {

        public List<Questions> ql;
        public List<String> answer_R = new List<string>();
        public Questions newQuestions;



               public  English(Questions q){
                    ql.Add(q);
                }
              
                public English(){
                ql = new List<Questions>() 
                    {
                    new Questions () {id_q =1 , question = "Good English" ,answer1="lol English",answer2="2English", answer3="3English",answer4 = "4",answer_r="null"},
                    new Questions(){ id_q = 2 , question="Ques 2" ,answer1="lol kek1",answer2="2", answer3="3",answer4 = "4",answer_r="null"}
                    };
                answer_R.Add("Singleton");
                answer_R.Add("Merge");
                }
                   
               
                public override List<Questions> GetQuestions(){
                    return ql;
                }

                public override Questions CreateQ(Questions q,String right_a){
                     ql.Add(q);
                    answer_R.Add(right_a);
                    return q;
                }

                public override List<string> giveRight(){
                    return answer_R;
                }
    }
}
