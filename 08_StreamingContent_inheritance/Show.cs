using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_inheritance
{
   public class Show : StreamingContent
    {
        public List<Episode> Episodes { get; set; }
        public int SeasonCount { get; set; }
        public int Episodecount { get; set; }
        public double AverageRunTime { get; set; }
    }

   public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
    }
}
