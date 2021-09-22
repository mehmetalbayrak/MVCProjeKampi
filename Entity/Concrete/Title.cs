using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Title
    {
        [Key]
        public int TitleId { get; set; }

        [StringLength(50)]
        public string TitleName { get; set; }
        public DateTime TitleDate { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        public ICollection<Content> Contents { get; set; }
    }
}
