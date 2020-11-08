using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CitySearch.Models
{
    interface ICityResult
    {
        ICollection<string> NextLetters { get; set; }
        ICollection<string> NextCities { get; set; }
    }
}
