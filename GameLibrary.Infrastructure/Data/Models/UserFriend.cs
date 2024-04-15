using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class UserFriend
	{
		[Comment("User identifier")]
		[Required]
		public string UserId = string.Empty;

		[Required]
		[ForeignKey(nameof(UserId))]
		public IdentityUser User { get; set; } = null!;

		[Comment("Friend identifier")]
		[Required]
		public string FriendId = string.Empty;

		[Required]
		[ForeignKey(nameof(FriendId))]
		public IdentityUser Friend { get; set; } = null!;
	}
}
