using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10
{
    interface IWork
    {
        public Questions CreateQ(Questions q,String answer_r);
        public List<Questions> GetQuestions();
        public List<String> giveRight();

    }
}
