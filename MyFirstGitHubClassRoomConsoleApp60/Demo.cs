using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }

        public override string ToString() 
        {
            return $"{id}, {name} \n Beskrivelse: {description}";
        }
    }
}
