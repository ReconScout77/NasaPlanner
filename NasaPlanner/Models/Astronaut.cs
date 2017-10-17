using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace NasaPlanner.Models
{
    public class Astronaut
    {
        private int _TasksPerDay = 11; 
      
        public int GetTasksPerDay()
        {
            return _TasksPerDay;
        }

        //public int CalculateTasks()
        //{
        //    _TasksPerDay = 11 + 
        //}
    }
}
