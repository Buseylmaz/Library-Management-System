using System.ComponentModel.DataAnnotations;

namespace LibraryManagementSystem
{
    class Library
    {
        [Key]
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int NumberPages { get; set; }
        public string PublishingHouse { get; set; }
    }
}
