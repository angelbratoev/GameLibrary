using GameLibrary.Infrastructure.Enumerables;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static GameLibrary.Infrastructure.Constants.DataConstants;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class Review
	{
		[Comment("Review identifier")]
		[Key]
		public int Id { get; set; }

		[Comment("Identifier of the reviewed game")]
		[Required]
		public int GameId { get; set; }

		[Required]
		[ForeignKey(nameof(GameId))]
		public Game Game { get; set; } = null!;

		[Comment("Identifier of the reviewer")]
		[Required]
		public string ReviewerId = string.Empty;

		[Required]
		[ForeignKey(nameof(ReviewerId))]
		public IdentityUser Reviewer { get; set; } = null!;

		[Comment("Whole number rating between 1 and 10")]
		[Required]
		public ReviewRating ReviewRating { get; set; }

		[Comment("Short text review of the game")]
		[Required]
		[MaxLength(ReviewTextMaxLength)]
		public string Text { get; set; } = string.Empty;

		[Comment("Count of the upvouts of the review")]
		[Required]
		public int UpvoteCounts { get; set; }

		[Comment("Count of the downvote of the review")]
		[Required]
		public int DownvoteCounts { get; set; }

		public IList<GameReview> GamesReviews { get; set; } = new List<GameReview>();
	}
}
