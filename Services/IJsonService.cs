using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationTemplate.Services
{
    public interface IJsonService
    {
        public string Write();

        public void Read(string json);


    }
}
