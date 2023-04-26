using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPcastingDowncasting.Models
{
    internal class Bus:Vehichle
    {
        public override void Drive()
        {
            Console.WriteLine("Drive Bus");
        }
    }
}
