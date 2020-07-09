using RobTheBank_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RobTheBank_Console
{
    public class ProgramUI
    {
        BankRepository repo = new BankRepository();
        void SeedQuestionList()

        {
            Questions questionOne = new Questions();
            questionOne.QuestionDescription = "What time would be best to rob a bank?";
            questionOne.Question = 1;
            questionOne.AnswerOne = "1.) Morning";
            questionOne.AnswerTwo = "2.) Afternoon";
            questionOne.AnswerThree = "3.) Night";

            Questions questionTwo = new Questions();
            questionTwo.QuestionDescription = "What weapon would you use to rob the bank?";
            questionTwo.Question = 2;
            questionTwo.AnswerOne = "1.) Knife";
            questionTwo.AnswerTwo = "2.) Bomb";
            questionTwo.AnswerThree = "3.) Gun";

            Questions questionThree = new Questions();
            questionThree.QuestionDescription = "How many members would you have on your crew?";
            questionThree.Question = 3;
            questionThree.AnswerOne = "1.) 1";
            questionThree.AnswerTwo = "2.) 2";
            questionThree.AnswerThree = "3.) 4";

            Questions questionFour = new Questions();
            questionFour.QuestionDescription = "Choose your method of escape!";
            questionFour.Question = 4;
            questionFour.AnswerOne = "1.) Hot Air Baloon";
            questionFour.AnswerTwo = "2.) Private Jet";
            questionFour.AnswerThree = "3.) Moped";


            BankRepository repo = new BankRepository();
            repo.AddQuestionsToList(questionOne);
            repo.AddQuestionsToList(questionTwo);
            repo.AddQuestionsToList(questionThree);
            repo.AddQuestionsToList(questionFour);

            Responses oneOne = new Responses("Too Early", "1.) Morning");
            Responses two = new Responses("Too Many People", "2.) Afternoon");
            Responses three = new Responses("Just Right - Proceed to next question", "3.) Night");
            Responses four = new Responses("Pocket Knife isn't Big Enough!", "1.) Knife");
            Responses five = new Responses("Perfect Solution - Very Scary - Proceed to next question", "2.) Bomb");
            Responses six = new Responses("No Bullets!", "3.) Gun");
            Responses seven = new Responses("All by Yourself!", "1.) 1");
            Responses eight = new Responses("You and Your Best Friend?", "2.) 2");
            Responses nine = new Responses("Enough Peope to Provide 2 on Lookout and 2 to Carry the Money - Proceed to next question", "3.) 4");
            Responses ten = new Responses("Hot Air Ballon, UP UP and Away - Success!!!!", "1.) Hot Air Baloon");
            Responses eleven = new Responses("You Spent the Money too Soon!", "2.) Private Jet");
            Responses twelve = new Responses("Too Many People for One Moped!", "3.) Moped");

            repo.AddResponsetoList(oneOne);
            repo.AddResponsetoList(two);
            repo.AddResponsetoList(three);
            repo.AddResponsetoList(four);
            repo.AddResponsetoList(five);
            repo.AddResponsetoList(six);
            repo.AddResponsetoList(seven);
            repo.AddResponsetoList(eight);
            repo.AddResponsetoList(nine);
            repo.AddResponsetoList(ten);
            repo.AddResponsetoList(eleven);
            repo.AddResponsetoList(twelve);





        }
        public void Run()
        {
            SeedQuestionList();
            RunMenu();

        }
        public void RunMenu()
        {
            Console.WriteLine("You are playing ROB THE BANK\n" +
                "Rules of the game:\n" +
                "Read each question and respond with whatever number is positioned next to your desired answer\n" +
                "Example: \n" +
                "What is your favorite color:\n" +
                "1. Green\n" +
                "Answer = 1"
                );
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("What is your name?: ");
            Player one = new Player();
            one.Name = Console.ReadLine();
            string interpol = $"Well, well, well, {one.Name} , let's see if you can rob a bank and get away with it!";
            Console.WriteLine(interpol);

            int numberVariable = 1;
            bool gameOn = true;
            while (gameOn)
            {
                Console.Clear();
                string reply = NewQuestion(numberVariable);
                Console.ReadLine();

                switch (numberVariable)
                {
                    case 1:

                        if(reply =="1")
                        {
                            ReadResponse("1). Morning");
                        }
                        if(reply == "2")
                        {
                            ReadResponse("2). Afternoon");
                        }
                        if(reply == "3")
                        {
                            ReadResponse("3). Night");
                            numberVariable = 2;
                        }
                        if(reply != "1" && reply != "2" && reply != "3")
                        {
                            ReadResponse("1). Morning");
                        }
                        //ReadResponse(shortAnswer);
                        
                        break;
                    case 2:
                        if (reply =="1")
                        {
                            ReadResponse("1) Knife");
                        }
                        if (reply == "2")
                        {
                            ReadResponse("2). Bomb");
                            numberVariable = 3;
                        }
                        if (reply == "3")
                        {
                            ReadResponse("3). Gun");
                        }
                        if (reply != "1" && reply != "2" && reply != "3")
                        {
                            Console.WriteLine("Nope try again");
                        }
                        break;
                    case 3:
                        if (reply == "1")
                        {
                            ReadResponse("1). 1");
                        }
                        if (reply == "2")
                        {
                            ReadResponse("2). 2");
                        }
                        if (reply == "3")
                        {
                            ReadResponse("3). 4");
                            numberVariable = 4;
                        }
                        if (reply != "1" && reply != "2" && reply != "3")
                        {
                            Console.WriteLine("Nope try again");
                        }
                        break;
                    case 4:
                        if (reply == "1")
                        {
                            ReadResponse("1). Hot Air Balloon");
                            gameOn = false;
                            Console.WriteLine("YOU ARE THE WINNER!! GO SPEND YA MONEY YOU FILTHY ANIMAL");
                            
                        }
                        if (reply == "2")
                        {
                            ReadResponse("2). Private Jet");
                        }
                        if (reply == "3")
                        {
                            ReadResponse("3). Moped");
                            
                        }
                        if (reply != "1" && reply != "2" && reply != "3")
                        {
                            Console.WriteLine("Nope try again");
                        }
                        break;
                    default:
                        gameOn = false;
                        break;
                }

            }
            string NewQuestion(int number)
            {
                
                Questions questioninfo = repo.GetQuestionByNumber(number);
                Console.WriteLine(questioninfo.QuestionDescription);
                Console.WriteLine(questioninfo.AnswerOne);
                Console.WriteLine(questioninfo.AnswerTwo);
                Console.WriteLine(questioninfo.AnswerThree);
                string reply = Console.ReadLine();
                return (reply);

            }
            void ReadResponse(string description)
            {
                Responses responseInfo = repo.GetResponseByNumber(description);
                Console.WriteLine(responseInfo.Answer);
                Console.WriteLine(responseInfo.Response);

                Console.ReadKey();

            }

        }
    }
}