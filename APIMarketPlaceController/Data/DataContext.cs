namespace APIMarketPlaceController.Data;

public class DataContext : DbContext {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
    public DbSet<Api> Apis => Set<Api>();
    public DbSet<Thumbnail> Thumbnails => Set<Thumbnail>();
}