namespace SharpExam.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Questions
    {
        [Key]
        public int QuestionId { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string QuestionName { get; set; }

        [Required]
        [StringLength(50)]
        public string QuestionAsked { get; set; }

        [StringLength(50)]
        public string Answer { get; set; }

        public virtual Users Users { get; set; }
    }
}
