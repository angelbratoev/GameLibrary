using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class UserConversation
	{
		[Comment("UserConversation identifier")]
		[Key]
		public int Id { get; set; }

		[Comment("User identifier")]
		[Required]
		public string UserId = string.Empty;

		[Required]
		[ForeignKey(nameof(UserId))]
		public IdentityUser User { get; set; } = null!;

		[Comment("Conversation identifier")]
		[Required]
		public int ConversationId { get; set; }

		[Required]
		[ForeignKey(nameof(ConversationId))]
		public Conversation Conversation { get; set; } = null!;

		[Comment("Identifier of the last message that the user read from this conversation")]
		public int? LastReadMessageId { get; set; }

		public Message? Message { get; set; }
	}
}
