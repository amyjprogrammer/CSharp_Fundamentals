using _06_RepositoryPattern_Repository;
using _08_StreamingContent_Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StreamingContent_InheritanceTests
{
    public class MovieShowRepo : StreamingContentRepository
    {
        //Get all shows
        //accessable outside- public, multiple shows, GetAllShows, Any info needed
        public List<Show> GetAllShows()
        {
            List<Show> allShows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Show show)
                {
                    allShows.Add(show);
                }
            }
            return allShows;
        }

        //Get all movies

        //Get Movie by title
        //accessable outside, single movie, descriptive name, any info needed 
        public Movie GetMovieByTitle(string movieTitle)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == movieTitle.ToLower() && content is Movie movie)
                {
                    return movie;
                }
            }
            return null;
        }
    }
}
