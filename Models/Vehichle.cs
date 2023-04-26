using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPcastingDowncasting.Models
{
    abstract class Vehichle
    {
        public int Price { get; set; }
        public abstract void Drive();
    }
}
