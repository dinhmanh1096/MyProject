using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class WorkoutModel
    {
        [MaxLength(5)]
        public int WorkoutID { get; set; }
        [MaxLength(50)]
        public string WorkoutName { get; set; }
        public string Distance { get; set; }
        public string Speed { get; set; }
        public string Time { get; set; }

        public int SportID { get; set; }

        public int UserID { get; set; }

    }
    public class RequestWorkoutModel
    {
        public string WorkoutName { get; set; }
        public string Distance { get; set; }
        public string Speed { get; set; }
        public string Time { get; set; }
        public int SportID { get; set; }
        public int UserID { get; set; }
    }
}
