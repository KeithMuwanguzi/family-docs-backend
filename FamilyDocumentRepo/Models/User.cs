using System.ComponentModel.DataAnnotations;

namespace FamilyDocumentRepo.Models;


public class User
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(100)]
    public string FullName { get; set; }

    [Required, EmailAddress]
    public string Email { get; set; }

    [Required]
    public string PasswordHash { get; set; }

    public ICollection<Document> Documents { get; set; } = new List<Document>();
}
