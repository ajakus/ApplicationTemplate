using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    public class Show : Media
    {
        private FileService _fileService;

        public UInt64 Season { get; set; }
        public UInt64 Episode { get; set; }

        public List<string> Writers { get; set; }

        public string Format { get; set; }

        public override string Display()
            {
                string file = "shows.csv";

                

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
                var results = _fileService.Shows.Where(x => x.Title.Contains(searchString));
                return results.FirstOrDefault();
            }

        }

    }
}
