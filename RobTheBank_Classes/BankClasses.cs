using RobTheBank_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobTheBank_Classes
{
    public class Player
    {
        public string Name { get; set; }
    }

    public class Questions
    {
        public int Question { get; set; }
        public string QuestionDescription { get; set; }
        public string AnswerOne { get; set; }
        public string AnswerTwo { get; set; }
        public string AnswerThree { get; set; }
    }
    public class Responses
    {
        public string Response { get; set; }
        public string Answer { get; set; }

        public Responses() { }

        public Responses(string response, string answer)
        {
            Response = response;
            Answer = answer;
        }
    }

}

