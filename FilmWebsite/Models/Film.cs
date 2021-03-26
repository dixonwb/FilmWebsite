using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

/* The only fields that are not required are Edited, Lent To, and Notes */
/* Everything else is required */
/* We don't want the "Note" field to be too long, so we need to limit the length */

namespace FilmWebsite.Models
{
    public class Film
    {
        [Key]
        public int MovieId { get; set; } // This key is important because it enables us to lookup films when we need to update or delete
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public string Edited { get; set; }
        [DisplayName("Lent To")]
        public string PersonLent { get; set; }
        // Limit the length to 25 characters
        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
