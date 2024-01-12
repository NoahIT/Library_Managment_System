using LMS_VIKO_Nojus_Rascius_PI22A.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_VIKO_Nojus_Rascius_PI22A.Generators
{
    public class GenerateJournals : IGenerator<Journal>
    {
        public List<Journal> GetGenerateItems()
        {
            var journals = new List<Journal>();
            for (int i = 1; i <= 50; i++)
            {
                journals.Add(new Journal
                {
                    Id = i,
                    Title = $"Journal Title {i}",
                    ISSN = $"ISSN {i:0000-0000}",
                    Author = $"Author {i}"
                });
            }
            return journals;
        }
    }
}
