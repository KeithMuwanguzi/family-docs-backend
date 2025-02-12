using System.ComponentModel.DataAnnotations;

namespace FamilyDocumentRepo.Models;

public class DocumentCategory
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(50)]
    public string Name { get; set; }
}
