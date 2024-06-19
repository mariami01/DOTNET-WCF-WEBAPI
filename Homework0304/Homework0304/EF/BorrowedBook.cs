namespace Homework0304.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class BorrowedBook
    {
        public int Id { get; set; }

        public int BookId { get; set; }

        [Required]
        [StringLength(50)]
        public string BorrowerName { get; set; }

        [Required]
        [StringLength(50)]
        public string BorrowerLastName { get; set; }

        [Column(TypeName = "date")]
        public DateTime BorrowedDate { get; set; }

        public virtual Book Book { get; set; }
    }
}
