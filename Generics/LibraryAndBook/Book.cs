﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activities.Generics.LibraryAndBook
{
    public class Book
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        public override string ToString()
        {
            return $"{Title} ({Genre})";
        }
    }
}
