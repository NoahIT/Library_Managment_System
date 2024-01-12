using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS_VIKO_Nojus_Rascius_PI22A.Generators
{
    public interface IGenerator<T>
    {
        List<T> GetGenerateItems();
    }
}
