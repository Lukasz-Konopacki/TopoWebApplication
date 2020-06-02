using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Topo.Model;

namespace Topo.ViewModel
{
    public class SaveRegionViewModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public double PostionLat { get; set; }
        [Required]
        public double PostionLng { get; set; }
        public string Description { get; set; }
        [Required]
        public IFormFile File { get; set; }
    }
}
