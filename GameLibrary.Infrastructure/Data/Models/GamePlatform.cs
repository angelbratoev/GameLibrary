using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class GamePlatform
	{
		[Comment("Game identifier")]
		[Required]
		public int GameId { get; set; }

		[Required]
		[ForeignKey(nameof(GameId))]
		public Game Game { get; set; } = null!;

		[Comment("Platform identifier")]
		[Required]
		public int PlatformId { get; set; }

		[Required]
		[ForeignKey(nameof(PlatformId))]
		public Platform Platform { get; set; } = null!;
	}
}
