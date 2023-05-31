using AvaloniaUI.Models;
using AvaloniaUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaUI.Services
{
    public class Database
    {
        public IEnumerable<ColorProfile> GetItems() => new[]
        {
            new ColorProfile { hexcolor = new GetColor().yourHex()},
            new ColorProfile { hexcolor = new GetColor().yourHex()},
            new ColorProfile { hexcolor = new GetColor().yourHex()}

        };
    }
}
