using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Topo.Model
{
    public class Rock
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public double PostionLat { get; set; }
        public double PostionLng { get; set; }
        public List<Route> Routes { get; set; }
        public List<Image> Photos { get; set; }
    }
}
