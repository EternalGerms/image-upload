using System.ComponentModel.DataAnnotations;

namespace ImageUploadService.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; } = string.Empty;
        [Required]
        public string PasswordHash { get; set; } = string.Empty;
        // Adicione outras propriedades conforme necessário
    }
} 