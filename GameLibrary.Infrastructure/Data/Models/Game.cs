using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static GameLibrary.Infrastructure.Constants.DataConstants;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class Game
	{
		[Comment("Game identifier")]
		[Key]
		public int Id { get; set; }

		[Comment("Game title max length")]
		[Required]
		[MaxLength(GameTitleMaxLength)]
		public string Title { get; set; } = string.Empty;

		[Comment("Description of the game")]
		[Required]
		public string Description { get; set; } = string.Empty;

		[Comment("When the game was released")]
		[Required]
		public DateTime ReleaseDate { get; set; }

		[Comment("Publisher of the game")]
		[Required]
		[MaxLength(PublisherNameMaxLength)]
		public string Publisher { get; set; } = string.Empty;

		[Comment("Developer of the game")]
		[Required]
		[MaxLength(DeveloperNameMaxLength)]
		public string Developer { get; set; } = string.Empty;

		[Comment("Cover image of the game")]
		[Required]
		public string CoverImage = string.Empty;

		public IList<Playthrough> Playthroughs { get; set; } = new List<Playthrough>();

		public IList<Favorite> Favorites { get; set; } = new List<Favorite>();

		public IList<GameGenre> GamesGenres { get; set; } = new List<GameGenre>();

		public IList<GamePlatform> GamesPlatforms { get; set; } = new List<GamePlatform>();

		public IList<GameReview> GamesReviews { get; set; } = new List<GameReview>();
	}
}
