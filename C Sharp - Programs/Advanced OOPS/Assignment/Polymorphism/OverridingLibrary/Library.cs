using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverridingLibrary
{
    public abstract class Library
    {
        public abstract string AuthorName {get; set;}
        public abstract string BookName {get; set;}
        public abstract string PublisherName {get; set;}
        public abstract DateTime Year {get; set;}
        public abstract string SetBookInfo();
        public abstract string DisplayInfo();
    }
}