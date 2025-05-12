using System.ComponentModel.DataAnnotations;

namespace Qb.Domain.Entities;

public class Answer
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public string Text { get; set; }
    
    [Required]
    public bool Correct { get; set; }
    
    public int QuestionId { get; set; }
}