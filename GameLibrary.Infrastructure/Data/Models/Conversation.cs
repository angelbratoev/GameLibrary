using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static GameLibrary.Infrastructure.Constants.DataConstants;

namespace GameLibrary.Infrastructure.Data.Models
{
	public class Conversation
	{
		[Comment("Conversation identifier")]
		[Key]
		public int Id { get; set; }

		[Comment("Name of the conversation")]
		[MaxLength(ConversationNameMaxLength)]
		public string? Name { get; set; }

		[Comment("Timestamp when the conversation was created")]
		[Required]
		public DateTime CreatedAt { get; set; }

		[Comment("Timestamp when the conversation was updated")]
		[Required]
		public DateTime UpdatedAt { get; set; }

		public IList<Message> Messages { get; set; } = new List<Message>();

		public IList<UserConversation> UserConversations { get; set; } = new List<UserConversation>();
	}
}
