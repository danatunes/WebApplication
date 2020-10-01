using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication10.Models;

namespace WebApplication10
{
    public class FController 
    {
        Proxy proxy = new Proxy();
        List<String> asn  = new List<String>();
                 
        
                    public  FController(){

                    }

                    public void  createQ(String name ,String question, String answer1, String answer2, String answer3, String answer4, String answer_r){
                      proxy = new Proxy(name , question , answer1 , answer2 , answer3 , answer4 , answer_r);
                    }

                    public List<Questions>  GetQuestions(String name){
                        proxy = new Proxy(name);
                        return proxy.GetQuestions();
                    }

                    public List<String> GetAnswers(String name){
                       return  asn= proxy.GiveME(name);
                    }
    }
}
