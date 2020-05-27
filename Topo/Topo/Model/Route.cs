using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Topo.Model
{
    public enum Difficulty
    {
        _4am = 10, _4a = 11, _4ap = 12, _4bm = 13, _4b = 14, _4bp = 15, _4cm = 16, _4c = 17, _4cp = 18,
        _5am = 20, _5a = 21, _5ap = 22, _5bm = 23, _5b = 24, _5bp = 25, _5cm = 26, _5c = 27, _5cp = 28,
        _6am = 30, _6a = 31, _6ap = 32, _6bm = 33, _6b = 34, _6bp = 35, _6cm = 36, _6c = 37, _6cp = 38,
        _7am = 40, _7a = 41, _7ap = 42, _7bm = 43, _7b = 44, _7bp = 45, _7cm = 46, _7c = 47, _7cp = 48,
        _8am = 50, _8a = 51, _8ap = 52, _8bm = 53, _8b = 54, _8bp = 55, _8cm = 56, _8c = 57, _8cp = 58,
        _9am = 60, _9a = 61, _9ap = 62, _9bm = 63, _9b = 64, _9bp = 65, _9cm = 66, _9c = 67, _9cp = 68
    }


    public class Route
    {
        public int Id { get; set; }
        public int? NumberOnPhoto { get; set; }
        public string Author { get; set; }
        public string Desciption { get; set; }
        [Required]
        public string Name { get; set; }
        public Difficulty Difficulty { get; set; }

    }
}
