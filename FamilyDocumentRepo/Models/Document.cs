using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyDocumentRepo.Models;
public class Document
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string FileName { get; set; }

    [Required]
    public string FileUrl { get; set; } // Store file path or cloud URL

    public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

    [Required]
    public int UserId { get; set; }

    [ForeignKey("UserId")]
    public User UploadedBy { get; set; }

    public int CategoryId { get; set; }
    
    [ForeignKey("CategoryId")]
    public DocumentCategory Category { get; set; }
}
