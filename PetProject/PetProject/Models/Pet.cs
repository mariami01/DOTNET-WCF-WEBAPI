namespace PetProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Pet
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(10)]
        public string Gender { get; set; }

        [StringLength(50)]
        public string Color { get; set; }

        public int Age { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(500)]
        public string Characteristic { get; set; }

        [Required]
        [StringLength(50)]
        public string Species { get; set; }

        public float Weight { get; set; }

        [StringLength(100)]
        public string Location { get; set; }

        public int AddedBy { get; set; }

        public bool IsAdopted { get; set; }

        public DateTime AddedDate { get; set; }

        public virtual User User { get; set; }
    }
}
