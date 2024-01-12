using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_VIKO_Nojus_Rascius_PI22A.Classes.Books_And_Journals_Interfaces
{
    public interface IPublishable
    {
        int Id { get; set; }
        string Title { get; set; }
        string Author { get; set; }
    }
}
