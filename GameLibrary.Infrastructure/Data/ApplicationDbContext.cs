using GameLibrary.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameLibrary.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
		public DbSet<Friendship> Friendships { get; set; }
		public DbSet<Game> Games { get; set; }
        public DbSet<GameGenre> GamesGenres { get; set; }
        public DbSet<GamePlatform> GamesPlatforms { get; set; }
        public DbSet<GameReview> GamesReviews { get; set;}
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Platform> Platforms { get; set; }
        public DbSet<Playthrough> Playthroughs { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<UserConversation> UserConversations { get; set;}

		protected override void OnModelCreating(ModelBuilder builder)
		{
            builder
                .Entity<GameGenre>()
                .HasKey(pk => new { pk.GenreId, pk.GameId });

            builder
                .Entity<GamePlatform>()
                .HasKey(pk => new { pk.PlatformId, pk.GameId });

            builder
                .Entity<GameReview>()
                .HasKey(pk => new { pk.ReviewId, pk.GameId });

			builder
				.Entity<GameGenre>()
				.HasOne(gg => gg.Game)
				.WithMany(g => g.GamesGenres)
				.HasForeignKey(gg => gg.GameId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.Entity<GameGenre>()
				.HasOne(gg => gg.Genre)
				.WithMany(g => g.GamesGenres)
				.HasForeignKey(gg => gg.GenreId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.Entity<GamePlatform>()
				.HasOne(gp => gp.Game)
				.WithMany(g => g.GamesPlatforms)
				.HasForeignKey(gp => gp.GameId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.Entity<GamePlatform>()
				.HasOne(gp => gp.Platform)
				.WithMany(p => p.GamesPlatforms)
				.HasForeignKey(gp => gp.PlatformId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.Entity<GameReview>()
				.HasOne(gr => gr.Game)
				.WithMany(g => g.GamesReviews)
				.HasForeignKey(gr => gr.GameId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
				.Entity<GameReview>()
				.HasOne(gr => gr.Review)
				.WithMany(r => r.GamesReviews)
				.HasForeignKey(gr => gr.ReviewId)
				.OnDelete(DeleteBehavior.Restrict);

			builder
                .Entity<Favorite>()
                .HasOne(f => f.Game)
                .WithMany(g => g.Favorites)
                .HasForeignKey(f => f.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Friendship>()
                .HasOne(f => f.User)
                .WithMany()
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict);

			builder
				.Entity<Friendship>()
				.HasOne(f => f.Friend)
				.WithMany()
				.HasForeignKey(f => f.FriendId)
				.OnDelete(DeleteBehavior.Restrict);


			builder
                .Entity<Playthrough>()
                .HasOne(p => p.Game)
                .WithMany(g => g.Playthroughs)
                .HasForeignKey(p => p.GameId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .Entity<Message>()
                .HasOne(m => m.Conversation)
                .WithMany(c => c.Messages)
                .HasForeignKey(m => m.ConversationId)
                .OnDelete(DeleteBehavior.Restrict);

			builder
                .Entity<UserConversation>()
                .HasOne(uc => uc.Conversation)
                .WithMany(c => c.UserConversations)
                .HasForeignKey(uc => uc.ConversationId)
                .OnDelete(DeleteBehavior.Restrict);


			base.OnModelCreating(builder);
		}
	}
}