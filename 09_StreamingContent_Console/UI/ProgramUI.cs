using _07_RepositoryPattern_Repository;
using _09_StreamingContent_Console.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _09_StreamingContent_Console.UI
{
    public class ProgramUI
    {
        private readonly IConsole _console;
        private readonly StreamingContentRepository _streamingRepo = new StreamingContentRepository();

        public ProgramUI(IConsole console)
        {
            _console = console;
        }
        public void Run()
        {
            SeedContentList();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();

                _console.WriteLine(
                    "Enter the number of the option you'd like to select:\n" +
                    "1. Show all streaming content \n" +
                    "2. Find streaming content by title \n" +
                    "3. Add new streaming content \n" +
                    "4. Remove streaming content \n" +
                    "5. Exit");

                string userInput = _console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //show all
                        ShowAllContent();
                        break;
                    case "2":
                        //find by title
                        ShowContentByTitle();
                        break;
                    case "3":
                        //add new
                        CreateNewContent();
                        break;
                    case "4":
                        //remove
                        RemoveContentFromList();
                        break;
                    case "5":
                        //exit
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("We asked for a number between 1-5 ya big dummy. \n" +
                            "Press any key to continue....");
                        _console.ReadKey();
                        break;
                }

            }
        }

        private void CreateNewContent()

        
        {
            _console.Clear();
            StreamingContent content = new StreamingContent();
            //title
            _console.WriteLine("Please enter the title of the content: ");
            content.Title = _console.ReadLine();
            //description
            _console.WriteLine("Please enter the description: ");
            content.Description = _console.ReadLine();
            //MRating
            _console.WriteLine("Select a Maturity Rating: \n" +
                "G \n" +
                "PG \n" +
                "PG 13 \n" +
                "R \n" +
                "NC 17 \n" +
                "TV MA \n");
            string maturityRating = _console.ReadLine();
            switch (maturityRating)
            {
                case "G":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "PG":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "PG 13":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "R":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "NC 17":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "TV MA":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;
            }
             
            //star rating
            _console.WriteLine("Please enter the star-rating (1-5): ");
            content.StarRating = Convert.ToInt32(_console.ReadLine());
            //type of genre
            _console.WriteLine("Select a Genre: \n" +
                "1: Horror \n" +
                "2: Sci-Fi \n" +
                "3: Drama \n" +
                "4: Action \n" +
                "5: Comedy \n" +
                "6: Anime \n" +
                "7: Documentary \n" +
                "8: Thriller");
            string genreInput = _console.ReadLine();
            int genreID = int.Parse(genreInput);
            content.TypeOfGenre = (GenreType)genreID;
            _streamingRepo.AddContentToDirectory(content);

        }

        private void ShowAllContent()
        {
            _console.Clear();
            List<StreamingContent> listOfContent = _streamingRepo.GetContents();

            foreach(StreamingContent contentVariable in listOfContent)
            {
                DisplayContent(contentVariable);
                _console.WriteLine("------------------");
            }

            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }

        private void ShowContentByTitle()
        {
            _console.Clear();
            _console.WriteLine("Please enter a title: ");
            string title = _console.ReadLine();
            StreamingContent foundTitle = _streamingRepo.GetContentByTitle(title);
            if(foundTitle != null)
            {
                DisplayContent(foundTitle);
            }
            else
            {
                _console.WriteLine("Invalid title. No results.");
            }
            _console.WriteLine("Press any key to continue");
            _console.ReadKey();
        }

        private void RemoveContentFromList()
        {
            _console.WriteLine("Which item would you like to remove?:");
            List<StreamingContent> contentList = _streamingRepo.GetContents();
            int count = 0;
            foreach(StreamingContent content in contentList)
            {
                count++;
                _console.WriteLine($"{count}. {content.Title}");
            }
            int targetContentId = int.Parse(_console.ReadLine());
            int targetIndex = targetContentId - 1;
            if(targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[targetIndex];
                if(_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    _console.WriteLine($"{desiredContent.Title} successfully removed.");
                }
                else
                {
                    _console.WriteLine("Sorry pal, ain't gon happen");
                }
            }
            else
            {
                _console.WriteLine("No content has that ID");
            }
            _console.WriteLine("Press any key to continue");
            _console.ReadKey();
        }
        private void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"Title: {content.Title} \n" +
                $"Description: {content.Description} \n" +
                $"Genre: {content.TypeOfGenre} \n" +
                $"Stars: {content.StarRating} \n" +
                $"Family Friendly: {content.IsFamilyFriendly} \n" +
                $"Rating: {content.MaturityRating}");
        }
        private void SeedContentList()
        {
            StreamingContent movieOne = new StreamingContent("Mr. Right", "Hitman falls in love", MaturityRating.R, 5, GenreType.Action);
            StreamingContent movieTwo = new StreamingContent("Iron Man", "Genius becomes hero", MaturityRating.PG_13, 5, GenreType.Action);
            StreamingContent movieThree = new StreamingContent("Silence of The Lambs", "Serial Killer helps find serial Killer", MaturityRating.R, 5, GenreType.Horror);

            _streamingRepo.AddContentToDirectory(movieOne);
            _streamingRepo.AddContentToDirectory(movieTwo);
            _streamingRepo.AddContentToDirectory(movieThree);

        }
    }
}
