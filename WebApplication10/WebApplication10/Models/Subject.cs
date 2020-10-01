using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public  abstract class Subject : IWork
    {
        public List<Subject> subj;

           public Subject(Subject subject){
            subj.Add(subject);
        }

        public Subject()
        {

        }
       
        public abstract List<Questions> GetQuestions();
        public abstract Questions CreateQ(Questions q,String right_a);
        public abstract List<string> giveRight();
    }
}
