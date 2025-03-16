public class BorrowingDTO
{
    public int BorrowingId { get; set; }
    public int BookId { get; set; }
    public string BookTitle { get; set; } // Titre du livre (pour affichage)
    public int AppUserId { get; set; }
    public string AppUserFullName { get; set; } // Nom complet de l'utilisateur (pour affichage)
    public DateTime BorrowDate { get; set; }
    public DateTime? ReturnDate { get; set; }
}