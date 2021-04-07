using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intexium.Models
{
    public class IAppRepository
    {
        IQueryable<Book> Books { get; }
    }
}
