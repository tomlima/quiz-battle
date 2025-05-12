using Qb.Domain.DTO;

namespace Qb.Web.Models;
using Qb.Domain.Entities;

public class TemplateViewModel
{
    public required List<Category> Categories { get; set; }
    public required UserSessionDto? UserSession { get; set; }
    
    public required bool IsLoggedIn { get; set; }
}