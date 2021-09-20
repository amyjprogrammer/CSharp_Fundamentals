using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Repository
{
    //Repository Pattern
    //CRUD
    //Create
    //Read
    //Update
    //Delete
    public class StreamingContentRepository
    {
        //Field
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //Create

        //could us void instead of bool and you wouldn't have the return method
        public bool AddContentToDirectory(StreamingContent content) 
        {
            int startingCount = _contentDirectory.Count; //starting count


            _contentDirectory.Add(content); //this actually adds to the list

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded; //logic to verify it was added 
        }

        //Read
        public List<StreamingContent> GetContents() 
        {
            return _contentDirectory;
        }

        //Get by Title
        public StreamingContent GetContentByTitle(string theTitleYouAreLookingFor)
        {
            foreach(StreamingContent content in _contentDirectory)
            {
                if(content.Title == theTitleYouAreLookingFor)
                {
                    return content;
                }
                
            }
            return null;
        }

        //Update

        public bool UpdateExistingContent(StreamingContent existingContent, StreamingContent newContent)
        {
            if(existingContent != null)
            {

                existingContent.Title = newContent.Title;
                existingContent.Description = newContent.Description;
                existingContent.RunTime = newContent.RunTime;
                existingContent.Genre = newContent.Genre;
                existingContent.RatingMaturity = newContent.RatingMaturity;
                existingContent.ReviewRating = newContent.ReviewRating;
                return true;
            } else
            {
                return false;
            }


        }


        //Delete
        public bool DeleteContent(StreamingContent existingContent)
        {
            bool result = _contentDirectory.Remove(existingContent);
            return result;
        }
    }
}
