using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class Favorite
	{
		[Comment("Favorite pair game/user identifier")]
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
		public int UserId { get; set; }

		[Required]
		[ForeignKey(nameof(UserId))]
		public IdentityUser User { get; set; } = null!;
	}
}
