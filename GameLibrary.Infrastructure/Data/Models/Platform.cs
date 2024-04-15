using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static GameLibrary.Infrastructure.Constants.DataConstants;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class Platform
	{
		[Comment("Platform identifier")]
		[Key]
		public int Id { get; set; }

		[Comment("Name of the game platform")]
		[Required]
		[MaxLength(PlatformNameMaxLength)]
		public string Name { get; set; } = string.Empty;

		public IList<GamePlatform> GamesPlatforms { get; set; } = new List<GamePlatform>();
	}
}
