using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    //POCO
    //Plain Old CSharp Object
    public class StreamingContent
    {
        public StreamingContent() { }
        
        public StreamingContent(string title, string description, double runTime, double reviewRating, string genre, MaturityRating ratingMaturity)
        {
            Title = title;
            Description = description;
            RunTime = runTime;
            ReviewRating = reviewRating;
            Genre = genre;
            RatingMaturity = ratingMaturity;
        }
      

        public string Title { get; set; }
        public string Description { get; set; }
        public double RunTime { get; set; }
        public double ReviewRating { get; set; }
        public string Genre { get; set; }
        public MaturityRating RatingMaturity { get; set; }

        // A challenge for the students now:
        /*
            Users have been complaining about their family friendly content. Some users have been reporting that when filtering for family friendly, they're getting some content with inappropriate maturity ratings. We need to fix this. Currently the maturity rating and family friendly bool are independent, we need to tie them together. If something is rated R (or another similar rating), it should never be able to have a IsFamilyFriendly of true. 

            We need you to refactor the code StreamingContent class. To help narrow down our problem, we want to replace the MaturityRating with a default set of options. Based on those options, we want our IsFamilyFriendly to return the appropriate true or false.
        */


        public bool IsFamilyFriendly 
        {
            get
            {
                switch (RatingMaturity)
                {
                    case MaturityRating.G:
                    case MaturityRating.PG:
                        return true;
                    case MaturityRating.PG13:
                    case MaturityRating.R:
                    case MaturityRating.NC17:
                    default:
                        return false;
                       
                }

                //this is an alternative way to do it

               /* if((int)RatingMaturity < 50)
                {
                    return true;
                } else 
                {
                    return false;
                }*/
            }
        }

    }

    //G and PG are 1 and 2
    public enum MaturityRating { G = 1 , PG , PG13, R, NC17}
}
