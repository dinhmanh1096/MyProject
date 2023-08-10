﻿using System.ComponentModel.DataAnnotations;

namespace MyProject.Models
{
    public class RoleModel
    {       
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }

    public class RequestRoleModel
    {
       public string RoleName { get; set; }
    }
}
