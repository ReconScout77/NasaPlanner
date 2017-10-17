using System;
namespace NasaPlanner.Models
{
    public class Mission
    {
        public int MissionId { get; set; }
        public int Days { get; set; }
        public int Tasks { get; set; }

        private int _Days;
        private int _Tasks;
        private int _Astronauts;


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
