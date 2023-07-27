﻿using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class UserModel
    {
        [MaxLength(5)]
        public string UserID { get; set; }
        [MaxLength(50)]
        public string UserName { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }

        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        public string RoleID { get; set; }
        [MaxLength(20)]
        public string Password { get; set; }
    }
}
