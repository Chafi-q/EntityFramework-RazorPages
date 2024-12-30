using System.ComponentModel.DataAnnotations;

public class Student
{
    public int Id { get; set; } // Clé primaire automatique

    [Required] // Champ obligatoire
    [StringLength(100)] // Limite de 100 caractères
    public string Name { get; set; }

    [Range(1, 120)] // Doit être entre 1 et 120
    public int Age { get; set; }

    [Required]
    [EmailAddress] // Valide un email
    public string Email { get; set; }
}