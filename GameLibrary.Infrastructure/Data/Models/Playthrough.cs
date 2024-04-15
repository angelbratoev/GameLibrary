using GameLibrary.Infrastructure.Enumerables;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class Playthrough
	{
		[Comment("Playthrough identifier")]
		[Key]
		public int Id { get; set; }

		[Comment("Game identifier")]
		[Required]
		public int GameId { get; set; }

		[Required]
		[ForeignKey(nameof(GameId))]
		public Game Game { get; set; } = null!;

		[Comment("User identifier")]
		[Required]
		public string UserId { get; set; } = string.Empty;

		[Required]
		[ForeignKey(nameof(UserId))]
		public IdentityUser User { get; set; } = null!;

		[Comment("Completion status of the game")]
		[Required]
		public CompletionStatus CompletionStatus { get; set; }
	}
}
