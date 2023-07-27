using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Data
{
    public class Sport
    {
        [Key]

        [MaxLength (5)]
        public string SportID { get; set; }
        [MaxLength(50)]
        public string SportName { get; set; }
        //
        public ICollection<Workout> Workouts { get; set; }
        
    }
}
