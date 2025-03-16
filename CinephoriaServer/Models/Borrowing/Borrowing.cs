public class Borrowing
{
    public int BorrowingId { get; set; } // Identifiant unique de l'emprunt
    public int BookId { get; set; } // Identifiant du livre emprunté
    public Book Book { get; set; } // Livre emprunté
    public int AppUserId { get; set; } // Identifiant de l'utilisateur qui a emprunté
    public AppUser AppUser { get; set; } // Utilisateur qui a emprunté
    public DateTime BorrowDate { get; set; } // Date d'emprunt
    public DateTime? ReturnDate { get; set; } // Date de retour (nullable si non retourné)
}