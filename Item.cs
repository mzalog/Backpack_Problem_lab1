using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BackpackProblem
{
    public class Item
    {
        public int Id { get; }
        public int Value { get; set; }
        public int Weight { get; }
        public double ValuePerWeight => (double)Value / Weight;

        public Item(int id, int value, int weight)
        {
            Id = id;
            Value = value;
            Weight = weight;
        }
    }
}
