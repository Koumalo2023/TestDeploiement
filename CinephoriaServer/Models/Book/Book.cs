public class Book
{
    public int BookId { get; set; } // Identifiant unique du livre
    public string Title { get; set; } // Titre du livre
    public string Author { get; set; } // Auteur du livre
    public string ISBN { get; set; } // Numéro ISBN du livre
    public int PublicationYear { get; set; } // Année de publication
    public int AvailableCopies { get; set; } // Nombre de copies disponibles
    public ICollection<Borrowing> Borrowings { get; set; } // Liste des emprunts associés à ce livre
}