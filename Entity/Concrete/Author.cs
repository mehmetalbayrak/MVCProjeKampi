using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [StringLength(50)]
        public string AuthorName { get; set; }

        [StringLength(50)]
        public string AuthorSurname { get; set; }

        [StringLength(100)]
        public string AuthorImage { get; set; }

        [StringLength(100)]
        public string AuthorAbout { get; set; }

        [StringLength(200)]
        public string AuthorEmail { get; set; }

        [StringLength(200)]
        public string AuthorPassword { get; set; }

        [StringLength(50)]
        public string AuthorTitle { get; set; }

        public ICollection<Title> Titles { get; set; }
        public ICollection<Content> Contents { get; set; }

    }
}
