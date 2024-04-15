using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static GameLibrary.Infrastructure.Constants.DataConstants;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class Message
	{
		[Comment("Message identifier")]
		[Key]
		public int Id { get; set; }

		[Comment("Conversation identifier")]
		[Required]
		public int ConversationId { get; set; }

		[Required]
		[ForeignKey(nameof(ConversationId))]
		public Conversation Conversation { get; set; } = null!;

		[Comment("User sender identifier")]
		[Required]
		public string SenderId { get; set; } = string.Empty;

		[Required]
		[ForeignKey(nameof(SenderId))]
		public IdentityUser Sender { get; set; } = null!;

		[Comment("Text of the sent message")]
		[Required]
		[MaxLength(MessageContentMaxLength)]
		public string Content = string.Empty;

		[Comment("Timestamp when the message was sent")]
		[Required]
		public DateTime SentAt { get; set; }
	}
}
