using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyProject.Data
{
    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
      //  [MaxLength(250)]
      //  public string Description { get; set; }
        //
        public ICollection<User> Users { get; set; }
    }
}
