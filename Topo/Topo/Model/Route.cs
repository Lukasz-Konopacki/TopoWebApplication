using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Topo.Model
{
    public class Route
    {
        public int Id { get; set; }
        public int? NumberOnPhoto { get; set; }
        public string author { get; set; }
        public string Desciption { get; set; }
        [Required]
        public string Name { get; set; }

    }
}
