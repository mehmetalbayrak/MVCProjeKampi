using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Content
    {
        [Key]
        public int ContentId { get; set; }

        [StringLength(1000)]
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        public int TitleId { get; set; }
        public virtual Title Title { get; set; }

        public int? AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
