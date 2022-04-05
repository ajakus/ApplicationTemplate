using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    public class Video : Media
    {
        private FileService _fileService;
        public string Format { get; set; }
        public TimeSpan ? Duration { get; set; }

        public List<string> Regions { get; set; }
        public List<string> Genres { get; set; }

        public override string Display()


        {
            string file = "videos.csv";


            StreamReader sr = new StreamReader(file);

            string line = sr.ReadLine();

            while (!sr.EndOfStream)
            {
                line = sr.ReadLine();
                var column = line.Split(',');
                var sv = string.Join(',', column);
                Console.WriteLine(sv);

            }
            sr.Close();
            throw new NotImplementedException();
        }

        public Media Search(string searchString)
        {
            var results = _fileService.Videos.Where(x => x.Title.Contains(searchString));
            return results.FirstOrDefault();
        }
    }
}
