using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenPage.Shared.Models
{
    public class SideBase
    {
        public string Route { get; set; }

        public string? Title { get; set; }

        public SideBase(string route)
        {
            Route = route;
        }
    }
}
