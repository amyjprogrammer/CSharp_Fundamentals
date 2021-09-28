using _06_RepositoryPattern_Repository;
using _07_StreamingContent_Console1.Consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console1
{
    public class ProgramUI
    {
        //creating one repo for all objects
        private StreamingContentRepository _repo = new StreamingContentRepository();
        private readonly IConsole _console;

        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            SeedData();//sets up the database with the seed data so we don't have to type data again
            RunMenu();
        }

        private void RunMenu()
        {
            bool isRunning = true;
            //Create a menu with options matching up to my Repository
            while (isRunning)
            {
                _console.Clear();

                _console.WriteLine
                    (
                        "Enter the number of your selection:\n" +
                        "1. Create new streaming content \n" +
                        "2. Show all streaming content\n" +
                        "3. Find streaming content by title\n" +
                        "4. Update content by title\n" +
                        "5. Remove content\n" +
                        "6. Exit"
                    );
                string userInput = _console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        //create new content
                        CreateNewContent();
                        break;
                    case "2":
                        ShowAllContent();
                        break;
                    case "3":
                        ShowContentTitle();
                        break;
                    case "4":
                        UpdateContent();
                        break;
                    case "5":
                        RemoveContentfromRepository();
                        break;
                    case "6":
                        isRunning = false;
                        break;

                    default:
                        _console.WriteLine("Please enter a valid number between 1-6.\n" +
                            "Press any key to continue.");
                        _console.ReadKey();
                        break;
                }
            }
        }
        //Creating Content
        private void CreateNewContent()
        {
            _console.Clear();

            //Creating the object first with all the properties

            StreamingContent createContent = new StreamingContent();

            //Title
            _console.WriteLine("Please enter a title: ");
            createContent.Title = _console.ReadLine();

            //Description
            _console.WriteLine("Please enter a description: ");
            createContent.Description = _console.ReadLine();

            //Runtime
            _console.WriteLine("What is the runtime of the content");
            createContent.RunTime = Convert.ToDouble(_console.ReadLine());

            //review rating
            _console.WriteLine("What is the review score (0-10):");
            createContent.ReviewRating = double.Parse(_console.ReadLine());

            //maturity rating
            /* G = 1, PG = 50, PG13, R, NC17*/
            _console.WriteLine("Select a maturity rating: \n" + "1. G\n" + "2. PG\n" + "3. PG13\n" + "4. R\n" + "5. NC17");

            string maturityRatingString = _console.ReadLine();
            int maturityRatingId = int.Parse(maturityRatingString);
            createContent.RatingMaturity = (MaturityRating)maturityRatingId;

            //an option to do it in one line
            //createContent.RatingMaturity = (MaturityRating)int.Parse(_console.ReadLine());

            //genre
            _console.WriteLine("What is the genre.");
            createContent.Genre = _console.ReadLine();

            //Creating the repo for the object

            _repo.AddContentToDirectory(createContent);

        }
        //Getting all content

        private void ShowAllContent()
        {
            //Clean slate to work from
            _console.Clear();

            List<StreamingContent> listOfAllContent = _repo.GetContents();

            foreach (StreamingContent content in listOfAllContent)
            {
                DisplayContent(content);

            }

            PauseProgram();
        }
        //Getting content by title
        private void ShowContentTitle()
        {
            _console.Clear();

            _console.WriteLine("What Title are you looking for?");
            string title = _console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);

            //Verify that content is in our repo
            if (content != null)
            {
                DisplayContent(content);
            }
            else
            {

                _console.WriteLine("Unfortunately we don't have that title.");
            }


            PauseProgram();
        }

        //Update Content
        //Try it tonight

        /*//My code
        private void UpdateContent2()
        {
            _console.Clear();

            _console.WriteLine("What Title are you looking to update?");
            string title = _console.ReadLine();

            StreamingContent content = _repo.GetContentByTitle(title);

            if (content == null)
            {
                _console.WriteLine("We are not able to find that title.");
            }
            else
            {
                _console.WriteLine($"What update did you want to make to the title: {content.Title}?");
                content.Title = _console.ReadLine();
                _console.WriteLine($"What update did you want to make to the description: {content.Description}?");
                content.Description = _console.ReadLine();
                _console.WriteLine($"What update did you want to make to the genre: {content.Genre}?");
                content.Genre = _console.ReadLine();
                _console.WriteLine("Select a new maturity rating: \n" + "1. G\n" + "2. PG\n" + "3. PG13\n" + "4. R\n" + "5. NC17");
                content.RatingMaturity = (MaturityRating)int.Parse(_console.ReadLine());
                _console.WriteLine($"What update did you want to make to the runtime: {content.RunTime}?");
                content.RunTime = Convert.ToDouble(_console.ReadLine());
                _console.WriteLine($"What update did you want to make to the review rating: {content.ReviewRating}?");
                content.ReviewRating = Convert.ToDouble(_console.ReadLine());
                _console.WriteLine("\n");
                _console.WriteLine("The new information you entered is:\n");
                DisplayContent(content);
            }
            PauseProgram();*//*
        }*/

        private void UpdateContent()
        {
            _console.Clear();

            _console.WriteLine("What is the title of the content you want to update: ");
            string targetTitle = _console.ReadLine();

            StreamingContent targetContent = _repo.GetContentByTitle(targetTitle);

            if (targetContent == null)
            {
                _console.WriteLine("We are not able to find that title.");
                PauseProgram();
                return;
            }

            StreamingContent updateContent = new StreamingContent();

            //Title
            _console.WriteLine($"Original title: {targetContent.Title}\n" +
                $"Please enter a new title: ");
            updateContent.Title = _console.ReadLine();

            //Description
            _console.WriteLine($"Original description: {targetContent.Description}");
            _console.WriteLine("Please enter a new description: ");
            updateContent.Description = _console.ReadLine();

            //Runtime
            _console.WriteLine($"Original Runtime: {targetContent.RunTime}\n" +
                $" What is the new runtime of the content");
            updateContent.RunTime = Convert.ToDouble(_console.ReadLine());

            //review rating
            _console.WriteLine($"Original: {targetContent.ReviewRating}\n" +
                $"What is the new review score (0-10):");
            updateContent.ReviewRating = double.Parse(_console.ReadLine());

            //maturity rating
            /* G = 1, PG = 50, PG13, R, NC17*/
            _console.WriteLine($"Old maturity rating: {targetContent.RatingMaturity}");
            _console.WriteLine("Select a maturity rating: \n" + "1. G\n" + "2. PG\n" + "3. PG13\n" + "4. R\n" + "5. NC17");

            string maturityRatingString = _console.ReadLine();
            int maturityRatingId = int.Parse(maturityRatingString);
            updateContent.RatingMaturity = (MaturityRating)maturityRatingId;

            //an option to do it in one line
            //createContent.RatingMaturity = (MaturityRating)int.Parse(_console.ReadLine());

            //genre
            _console.WriteLine($"Original genre: {targetContent.Genre} \n" +
                $"What is the new genre.");
            updateContent.Genre = _console.ReadLine();

            if(_repo.UpdateExistingContent(targetContent, updateContent))
            {
                _console.Clear();
                _console.WriteLine("Update successful \n");
                DisplayContent(updateContent);
            }
            else
            {
                _console.WriteLine("Update Failed.");
            }

            PauseProgram();
        }

        //Delete
        private void RemoveContentfromRepository()
        {
            _console.Clear();

            List<StreamingContent> contentList = _repo.GetContents();

            int index = 1;

            foreach (StreamingContent content in contentList)
            {
                _console.WriteLine($"{index}. {content.Title}");
                index++;
            }

            _console.WriteLine("What title would you like to remove?");
            int targetTitleId = int.Parse(_console.ReadLine());
            int targetIndex = targetTitleId - 1;

            if (targetIndex >= 0 && targetIndex < contentList.Count)
            {
                StreamingContent targetContent = contentList[targetIndex];

                if (_repo.DeleteContent(targetContent))
                {
                    _console.WriteLine($"{targetContent.Title} was successfully deleted.");
                }
                else
                {
                    _console.WriteLine("On no something went wrong!");
                }
            }
            else
            {
                _console.WriteLine("That is not a valid selection.");
            }

            PauseProgram();
        }


        //seed method
        private void SeedData()
        {
            StreamingContent starWars = new StreamingContent("Star Wars", "Space Opera", 2.1, 9.5, "SciFi", MaturityRating.PG);
            StreamingContent matrix = new StreamingContent("Matrix", "mind bending", 1.8, 8.9, "SciFi", MaturityRating.PG13);
            StreamingContent jaws = new StreamingContent("Jaws", "Ocean Horror", 2.15, 9.2, "Horror", MaturityRating.R);
            StreamingContent aliens = new StreamingContent("Aliens", "awesome", 2.15, 9.4, "Space Horror", MaturityRating.R);

            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(matrix);
            _repo.AddContentToDirectory(jaws);
            _repo.AddContentToDirectory(aliens);
        }

        private void DisplayContent(StreamingContent content)
        {
            _console.WriteLine($"Title: {content.Title}\n" +
                    $"Description: {content.Description}\n" +
                    $"Length: {content.RunTime}\n" +
                    $"Review Score: {content.ReviewRating}\n" +
                    $"Genre: {content.Genre}\n" +
                    $"Maturity Rating: {content.RatingMaturity}\n" +
                    $"Family Friendly: {content.IsFamilyFriendly}\n\n");
        }

        private void PauseProgram()
        {
            _console.WriteLine("Press any key to continue...");
            _console.ReadKey();
        }

    }
}
