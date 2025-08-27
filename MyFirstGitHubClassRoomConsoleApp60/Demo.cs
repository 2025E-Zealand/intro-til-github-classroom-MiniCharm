using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstGitHubClassRoomConsoleApp60
{
    public class Demo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public override string ToString() 
        {
            return $"{Id}:{Name} \n Beskrivelse: {Description}";
        }

        public Demo(int id,string name, string descriotion)
        {
            Id = id;
            Name = name;
            Description = descriotion;
        }
    }
}
