using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuExercise
{
    public class Ticket
    {
        private string type;
        private int price;

        public string Type { get; set; }
        public int Price { get; set; }

        public Ticket() { }

        public Ticket(string type, int price)
        {
            Type = type;
            Price = price;
        }
    }
}
