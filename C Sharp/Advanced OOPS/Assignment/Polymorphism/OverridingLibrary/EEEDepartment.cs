using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverridingLibrary
{
    public class EEEDepartment : Library
    {
        public override string AuthorName {get; set;}
        public override string BookName {get; set;}
        public override string PublisherName {get; set;}
        public override DateTime Year {get; set;}
        public EEEDepartment(string authorName, string bookName, string publishername, DateTime year)
        {
            AuthorName = authorName;
            BookName = bookName;
            PublisherName = publishername;
            Year = year;
        }
        public override string SetBookInfo()
        {
            return ($"{AuthorName} | {BookName} | {PublisherName} | {Year}");
        }
        public override string DisplayInfo()
        {
            return ($"{BookName} | {PublisherName}");
        }
    }
}