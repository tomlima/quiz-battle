using System.ComponentModel.DataAnnotations;
using Qb.Domain.Enums;

namespace Qb.Domain.Entities;

public class User
{
    [Key]
    public int Id { get; set; }
    
    [Required] 
    public required string Name { get; set; }
    
    [Required]
    public required string Email { get; set; }
    
    public string? Nickname { get; set; }
    
    [Required] 
    public required string Password { get; set; }
    
    [Required]
    public required bool Status { get; set; }
    
    [Required] 
    public required DateTime CreatedAt { get; set; }

    [Required]
    public required string Avatar { get; set; }
    
    [Required]
    public required Roles Role { get; set; }
}