using System.ComponentModel.DataAnnotations;

namespace ContactManager.Models
{
    public class Contact
    {

        public int ContactId { get; set; }
        [Required]  
        public string? Name { get; set; }
        [Required]
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string? Email { get; set; }


        // user ID from AspNetUser table.
        public string? OwnerID { get; set; }

        public ContactStatus Status { get; set; }
    }

    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
}
