using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    public class Movie : Media
    {
        public List<string> Genres { get; set; }

        private FileService _fileService;

        
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
