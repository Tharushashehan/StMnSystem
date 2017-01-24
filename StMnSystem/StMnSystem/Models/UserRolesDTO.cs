using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StMnSystem.Models
{
    public class ExpandedUserDTO
    {
        [Key]
        [Display(Name = "User Name")]
        public string UserName
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public string Password
        {
            get; set;
        }
        [Display(Name = "Lockout End Date Utc")]
        public DateTime? LockoutEndDateUtc
        {
            get; set;
        }
        public int AccessFailedCount
        {
            get; set;
        }

        [Display (Name ="Marks")]
        public string PhoneNumber
        {
            get; set;
        }

       
        [Display(Name = "Mark")]
        public int Marks
        {
            get; set;
        }

        
        [Display(Name = "Level")]
        public string Level
        {
            get; set;
        }

        
        [Display(Name = "Subject")]
        public string Subject
        {
            get; set;
        }
        public IEnumerable<UserRolesDTO> Roles
        {
            get; set;
        }
    }
    public class UserRolesDTO
    {
        [Key]
        [Display(Name = "Role Name")]
        public string RoleName
        {
            get; set;
        }
    }
    public class UserRoleDTO
    {
        [Key]
        [Display(Name = "User Name")]
        public string UserName
        {
            get; set;
        }
        [Display(Name = "Role Name")]
        public string RoleName
        {
            get; set;
        }
    }
    public class RoleDTO
    {
        [Key]
        public string Id
        {
            get; set;
        }
        [Display(Name = "Role Name")]
        public string RoleName
        {
            get; set;
        }
    }
    public class UserAndRolesDTO
    {
        [Key]
        [Display(Name = "User Name")]
        public string UserName
        {
            get; set;
        }
        public List<UserRoleDTO> colUserRoleDTO
        {
            get; set;
        }
    }
}