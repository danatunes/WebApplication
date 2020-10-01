using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication10.Models
{
    public class Questions
    {
        public int id_q { get; set; }
        public String question { get; set; }
        public string answer1 { get; set; }
        public string answer2 { get; set; }
        public string answer3 { get; set; }
        public string answer4 { get; set; }
        public string answer_r { get; set; }

        public Questions(){
            id_q++;
        }

    }
}
