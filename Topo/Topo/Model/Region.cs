using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Topo.Model
{
    public class Region
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Image Photo { get; set; }
        public double PostionLat { get; set; }
        public double PostionLng { get; set; }
        public string Description { get; set; }
        public List<Rock> Rocks { get; set; }
    }
}
