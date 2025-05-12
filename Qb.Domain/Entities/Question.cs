using System.ComponentModel.DataAnnotations;
using Qb.Domain.Enums;

namespace Qb.Domain.Entities;

public class Question
{
    [Key]
    public int Id { get; set; }
    
    [Required]
    public required string Text { get; set; }
    
    [Required]
    public required List<Answer> Answers { get; set; }
    
    required
    public Difficulty Difficulty { get; set; }
    
    [Required]
    public int Order { get; set; }
    
    public int QuizId { get; set; } // <-- adicione isso

}