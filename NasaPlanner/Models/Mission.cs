using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;


namespace NasaPlanner.Models
{
    [Table("Missions")]
    public class Mission
    {
        [Key]
        public int MissionId { get; set; }
        public string MissionName { get; set; }
        public int Days { get; set; }
        public int Tasks { get; set; }

        private int _Days;
        private int _Tasks;
        private int _Astronauts;

        public Mission()
        {
        }


        public Mission(int days, int tasks)
        {
            _Days = days;
            _Tasks = tasks;
            if ((tasks/days) > 176)
            {
                _Astronauts = (int)Math.Ceiling((tasks / days) / 211.2);
            } 
            else 
            {
                _Astronauts = 1;
            }
        }

        public int GetAstronauts()
        {
            return _Astronauts;
        }

        //re-visit logic to include 20%/additional member
    }
}
