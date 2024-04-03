using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_abstraction_home.Modes
{
    public class Book : IlabiraryItem
    {
        public string Title { get ; set ; }
        public string Author { get ; set ; }
        public int AvailableCopies { get ; set; }


        public Book(string title, string author, int copies)
        {
            Title = title;
            Author = author;    
            AvailableCopies = copies;
        }
        public void CheckOut(int count)
        {
            if (count <=AvailableCopies)
            {
                AvailableCopies -= count;

                Console.WriteLine($"Current available copies is : {AvailableCopies}");
            }
            else
            {
                Console.WriteLine($" We don't have {count} book");
            }
        }

        public void Return(int count, string author)
        {
            if (author == Author && count ==AvailableCopies)
            {
                AvailableCopies += count;
                Console.WriteLine($"{count} book was returned by reader");
            }
            else
            {
                Console.WriteLine("Something went wrong");
            }
        }
    }
}
