using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class GameReview
	{
		[Comment("Game identifier")]
		[Required]
		public int GameId { get; set; }

		[Required]
		[ForeignKey(nameof(GameId))]
		public Game Game { get; set; } = null!;

		[Comment("Review identifier")]
		[Required]
		public int ReviewId { get; set; }

		[Required]
		[ForeignKey(nameof(ReviewId))]
		public Review Review { get; set; } = null!;
	}
}
