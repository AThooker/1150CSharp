using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
   
    public enum GenreType
    {
        Horror =1,
        SciFi,
        Drama,
        Action,
        Comedy,
        Anime,
        Documentary,
        Thriller
    }

    public enum MaturityRating
    {
        G,
        PG,
        PG_13,
        R,
        NC_17,
        TV_MA
    }
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public int StarRating { get; set; }
        public bool IsFamilyFriendly 
        { 
            get 
            {
                switch(MaturityRating)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                        return true;
                    case MaturityRating.PG_13:
                    case MaturityRating.R:
                    case MaturityRating.NC_17:
                    case MaturityRating.TV_MA:
                    default:
                        return false;
                }
                
            }
        }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent()
        {

        }
        public StreamingContent(string title, string description, MaturityRating maturityRating, int starRating, GenreType typeOfGenre)
        {
            Title = title;
            Description = description;
            MaturityRating = maturityRating;
            StarRating = starRating;
            TypeOfGenre = typeOfGenre;
        }


    }
}
