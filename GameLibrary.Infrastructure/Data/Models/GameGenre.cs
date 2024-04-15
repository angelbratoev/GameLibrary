using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class GameGenre
	{
		[Comment("Game identifier")]
		[Required]
		public int GameId { get; set; }

		[Required]
		[ForeignKey(nameof(GameId))]
		public Game Game { get; set; } = null!;

		[Comment("Genre identifier")]
		[Required]
		public int GenreId { get; set; }

		[Required]
		[ForeignKey(nameof(GenreId))]
		public Genre Genre { get; set; } = null!;
	}
}
