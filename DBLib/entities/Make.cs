using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.entities
{
    public class Make
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public Make(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
