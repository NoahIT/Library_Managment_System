using LMS_VIKO_Nojus_Rascius_PI22A.Classes.Books_And_Journals_Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_VIKO_Nojus_Rascius_PI22A.Models
{
    public class Book : IPublishable
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
    }

}
