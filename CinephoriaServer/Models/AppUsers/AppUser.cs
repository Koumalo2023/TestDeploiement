public class AppUser
{
    public int AppUserId { get; set; } 
    public string FirstName { get; set; } 
    public string LastName { get; set; } 
    public string Email { get; set; } 
    public string PhoneNumber { get; set; }
    public DateTime RegistrationDate { get; set; } 
    public ICollection<Borrowing> Borrowings { get; set; } 
}