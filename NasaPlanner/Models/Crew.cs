using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NasaPlanner.Models
{
    [Table("Crews")]
    public class Crew
    {   
        [Key]
        public int CrewId { get; set; }
        public string Name { get; set; }
    }
}
