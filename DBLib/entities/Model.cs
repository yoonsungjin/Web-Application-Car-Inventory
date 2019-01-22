using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.entities
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Model(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
