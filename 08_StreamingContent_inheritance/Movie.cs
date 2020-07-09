using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_inheritance
{
    public class Movie : StreamingContent
    {
        public double RunTime { get; set; }
        public Movie()
        {

        }
        public Movie(string title, string description, MaturityRating maturityRating, int starRating, GenreType typeOfGenre, double runTime)
            :base(title, description, maturityRating, starRating, typeOfGenre)
        {
            RunTime = runTime;
        }
    }
}
