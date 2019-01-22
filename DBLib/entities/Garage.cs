using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBLib.entities
{
    public class Garage
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int CarId { get; set; }

        public Garage(int id, int memberId, int carId)
        {
            Id = id;
            MemberId = memberId;
            CarId = carId;
        }
    }
}
