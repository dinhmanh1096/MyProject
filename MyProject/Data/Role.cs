using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Data
{
    public class Role
    {
        [Key]
        [MaxLength(5)]
        public string RoleID { get; set; }
        [MaxLength(50)]
        public string RoleName { get; set; }

        //
        public ICollection<User> Users { get; set; }
    }
}
