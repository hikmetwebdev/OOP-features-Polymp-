using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_abstraction_home.Modes
{
    public interface IlabiraryItem
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int AvailableCopies { get; set; }

        void CheckOut(int count);
        void Return(int count,string author);
    }
}
