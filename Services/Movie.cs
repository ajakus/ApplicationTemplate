using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;

namespace ApplicationTemplate.Services
{
    public class Movie : Media
    {
        public List<string> Genres { get; set; }

        public FileService _fileService = new FileService();


        public override string Display()
        {

            return $"Id: {mediaId}\nTitle: {Title}\nGenres: {string.Join(", ", Genres)}\n";
        }


        public Media Search(string searchString)
            {
            var results = _fileService.Movies.Where(x => x.Title.Contains(searchString));
            return results.FirstOrDefault();
        }


        }

    }
