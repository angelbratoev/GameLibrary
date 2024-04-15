using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static GameLibrary.Infrastructure.Constants.DataConstants;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class Genre
	{
		[Comment("Genre identifier")]
		[Key]
		public int Id { get; set; }

		[Comment("Genre name")]
		[Required]
		[MaxLength(GenreNameMaxLength)]
		public string Name { get; set; } = string.Empty;

		public IList<GameGenre> GamesGenres { get; set; } = new List<GameGenre>();
	}
}
