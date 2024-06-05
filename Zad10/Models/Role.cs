﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Zad10.Models;

[Table("Roles")]
public class Role
{
    [Key]
    [Column("PK_role")]
    public int RoleId { get; set; }
    
    [Required]
    [MaxLength(100)]
    [Column("name")]
    public string RoleName { get; set; }

    public ICollection<Account> Accounts { get; set; }
}