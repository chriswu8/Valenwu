using Microsoft.EntityFrameworkCore;

public class BoardGamesDBContext : DbContext
{
    public BoardGamesDBContext(DbContextOptions<BoardGamesDBContext> options)
        : base(options) { }

    public DbSet<BoardGame> BoardGames { get; set; }
}