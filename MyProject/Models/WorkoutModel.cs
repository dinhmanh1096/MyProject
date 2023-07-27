using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class WorkoutModel
    {
        [MaxLength(5)]
        public string WorkoutID { get; set; }
        [MaxLength(50)]
        public string WorkoutName { get; set; }
        public string Distance { get; set; }
        public string Speed { get; set; }
        public string Time { get; set; }
        [MaxLength(5)]
        public string SportID { get; set; }
        [MaxLength(5)]
        public string UserID { get; set; }

    }
}
