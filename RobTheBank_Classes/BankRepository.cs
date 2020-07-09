using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace RobTheBank_Classes
{
    public class BankRepository
    {
        List<Questions> questionList = new List<Questions>();
        List<Responses> responseList = new List<Responses>();

        public void AddQuestionsToList(Questions content)
        {
            questionList.Add(content);
        }

        public void AddResponsetoList(Responses content)
        {
            responseList.Add(content);
        }

        public Questions GetQuestionByNumber(int number)
        {
          foreach(Questions content in questionList)
            {
                if(content.Question == number)
                {
                    return content;
                }
            }
            return null;
        }

        public Responses GetResponseByNumber(string selection)
        {
            foreach (Responses content in responseList)
            {
                if (content.Answer == selection)
                {
                    return content;
                }
            }
            return null;
        }

    }
}
