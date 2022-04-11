using System;

namespace ApplicationTemplate.Services;

/// <summary>
///     You would need to inject your interfaces here to execute the methods in Invoke()
///     See the commented out code as an example
/// </summary>
public class MainService : IMainService
{
    private IJsonService _iJsonServicej = new JsonService();
    public void Invoke()
    {
        Console.WriteLine("Read and write");
        _iJsonServicej.Write();
       // _iJsonServicej.Read(string json);

        /*
        var combiner = new CombinerService();

        Console.WriteLine("Enter search string: ");
        var searchString = Console.ReadLine();
        var results = combiner.SearchAllMedia(searchString);

        results.ForEach(Console.WriteLine);
        Console.WriteLine(results);

        */




        Media media = null;
    //    string choice;
        string choice1;
      //  do
      //  {
            Console.WriteLine("1) Work with Movie");
            Console.WriteLine("2) Work with Show");
            Console.WriteLine("3) Work with video");
            choice1 = Console.ReadLine();
            if (choice1 == "1")
            {
                media = new Movie();
                media.Display();

                
            }
            else if (choice1 == "2")
            {
                 media = new Show();
                 media.Display();
                 
            }
            else if (choice1 == "3")
            {
                 media = new Video();
                 media.Display();
                 
            }


        

        /*       Console.WriteLine("1) Add Movie");
               Console.WriteLine("2) Display All Movies");
               Console.WriteLine("3) Quit");
              choice = Console.ReadLine();

         Logic would need to exist to validate inputs and data prior to writing to the file
         You would need to decide where this logic would reside.
         Is it part of the FileService or some other service?
                 if (choice == "1")
                 {
                      _fileService.Write();
                  }
                 else if (choice == "2")
                 {
                     FileService.Movie
                     _fileService.Read();
                 }
            }
            while (choice != "3");              */
    }
}
