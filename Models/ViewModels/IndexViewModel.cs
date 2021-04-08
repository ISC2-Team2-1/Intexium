using Intexium.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models.ViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<Book> Books { get; set; }
    }
}
