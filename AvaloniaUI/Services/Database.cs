using AvaloniaUI.Models;
using AvaloniaUI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Drawing;

namespace AvaloniaUI.Services
{
    public class Database
    {

        public void connection()
        {
            using var conn = new NpgsqlConnection("Host=10.11.36.92;Username=postgres;Password=9fwvOI;Database=logoper");
            conn.Open();
            
        }

        public IEnumerable<ColorProfile> GetItems() => new[]
        {

            new ColorProfile { hexcolor = new GetColor().yourHex()},
            new ColorProfile { hexcolor = new GetColor().yourHex()},
            new ColorProfile { hexcolor = new GetColor().yourHex()},
            new ColorProfile { hexcolor = new GetColor().yourHex()},
            new ColorProfile { hexcolor = new GetColor().yourHex()},
            new ColorProfile { hexcolor = new GetColor().yourHex()},
            new ColorProfile { hexcolor = new GetColor().yourHex()},
            new ColorProfile { hexcolor = new GetColor().yourHex()},
            new ColorProfile { hexcolor = new GetColor().yourHex()},

        };

        public void addEl()
        {

        }
    }
}
