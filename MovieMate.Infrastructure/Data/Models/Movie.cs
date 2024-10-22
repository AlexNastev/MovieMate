using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MovieMate.Infrastructure.Data.DataConstants.MovieConstants;

namespace MovieMate.Infrastructure.Data.Models
{
    public class Movie
    {
        [Key]
        [Comment("Movie identifier")]
        public int Id { get; set; }
        [Required]
        [MaxLength(TitleMaxLength)]
        public string Title { get; set; } = null!;
        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;
        [Required]
        public DateTime ReleaseYear { get; set; }
        [Required]
        public int GenreId { get; set; }
        [Required]
        [ForeignKey(nameof(GenreId))]
        public Genre Genre { get; set; } = null!;
        public List<Actor> Cast { get; set; } = new List<Actor>();
        [Required]
        [MaxLength(DurationMaxLength)]
        public int Duration { get; set; }
        [Required]
        [MaxLength(RentalPriceMaxLength)]
        public decimal RentalPrice { get; set; }


    }
}
