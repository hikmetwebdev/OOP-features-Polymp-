using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_abstraction_home.Modes
{
    public class DVD:IlabiraryItem
    {
        public string Title { get ; set ; }
        public string Author { get ; set ; }
        public int AvailableCopies { get ; set ; }


        public DVD(string title, string author, int copies)
        {
            Title = title;
            Author = author;
            AvailableCopies = copies;
        }
        public void CheckOut(int count)
        {
            if (count > 0)
            {
                AvailableCopies -= count;

                Console.WriteLine($"Current available copies is : {AvailableCopies}");
            }
        }

        public void Return(int count, string author)
        {
            if (author == Author)
            {
                AvailableCopies += count;
            }
        }
    }
}
