using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseLab05.Models
{
    internal class Book
    {
        string Title;
        string Author;
        string Genre;
        int YearPublished;
        double Price;

        public override string ToString()
        {
            return $"title:{Title} author:{Author} genre:{Genre} int:{YearPublished} price:{Price}";
        }

    }
}
