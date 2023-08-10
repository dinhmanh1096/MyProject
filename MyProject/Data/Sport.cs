using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Data
{
    public class Sport
    {
        [Key]
        public int SportID { get; set; }
        public string SportName { get; set; }
        //
        public ICollection<Workout> Workouts { get; set; }
        
    }
}
